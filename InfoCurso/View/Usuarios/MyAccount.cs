using Infocurso.Forms;
using Infocurso.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infocurso
{
    public partial class MyAccount : Form
    {
        Usuario usuario = null;
        public MyAccount(int userId)
        {
            InitializeComponent();
            this.usuario = Usuario.FindById(userId);
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            lblNome.Text = usuario.NomeCompleto.ToString();
            if (usuario.SexoUsuario == 1)
                lblSexo.Text = "Masculino";
            else
                lblSexo.Text = "Feminino";

            if(DateTime.Now.DayOfYear < usuario.DataNascimento.DayOfYear)
            {
                lblIdade.Text = (DateTime.Now.Year - usuario.DataNascimento.Year - 1).ToString() + " Anos";
            }
            else
                lblIdade.Text = (DateTime.Now.Year - usuario.DataNascimento.Year).ToString() + " Anos";

            lblCpf.Text = usuario.Cpf;
            lblRg.Text = usuario.Rg;
            lblEmail.Text = usuario.Email;
            lblDataNascimento.Text = usuario.DataNascimento.ToString("dd/MM/yyyy");

            lblTelefone1.Text = usuario.Telefone1;
            if (usuario.Telefone2 != null) {
                labelTelefone.Visible = true;
                lblTelefone2.Visible = true;
                lblTelefone2.Text = usuario.Telefone2;
            }

            foreach (Curso curso in Curso.FindByUser(usuario))
            {
                dgvCursos.Rows.Add(curso.Nome, "Editar", "Deletar");
            }

        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvCursos.SelectedCells[0].RowIndex;
            int colunaSelecionada = dgvCursos.SelectedCells[0].ColumnIndex;
            string nomeCurso = dgvCursos.Rows[linhaSelecionada].Cells[0].Value.ToString();
            if (colunaSelecionada == 1)
            {
                InfoCurso.ShowNewForm(new EditCurso(Curso.FindByName(nomeCurso).Id));
            }
            if (colunaSelecionada == 2)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir o curso " + nomeCurso + "?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK) { 
                    Curso.Delete(Curso.FindByName(nomeCurso));
                    dgvCursos.Rows.RemoveAt(linhaSelecionada);
                }
            }
        }

        private void dgvCursos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvCursos.SelectedCells[0].RowIndex;
            int colunaSelecionada = dgvCursos.SelectedCells[0].ColumnIndex;
            string nomeCurso = dgvCursos.Rows[linhaSelecionada].Cells[0].Value.ToString();
            Curso curso = Curso.FindByName(nomeCurso);
            if (colunaSelecionada == 0)
            {
                if (curso.Aulas.Count > 0)
                    InfoCurso.ShowNewForm(new Videos(curso, 1));
                else
                    InfoCurso.ShowNewForm(new NoVideo(curso));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new Login(ActiveForm));
        }

        private void ptbEditar_MouseEnter(object sender, EventArgs e)
        {
            ptbEditarR.Show();
            ptbEditar.Hide();
        }

        private void ptbEditarR_MouseLeave(object sender, EventArgs e)
        {
            ptbEditar.Show();
            ptbEditarR.Hide();
        }

        private void ptbEditarR_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new EditarUsuario(usuario));
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dgvCursos.Rows.Clear();

            if(!txtPesquisa.Text.Equals(""))
                foreach (Curso curso in Curso.FindByNameHaving(txtPesquisa.Text, usuario))
                {
                    dgvCursos.Rows.Add(curso.Nome, "Editar", "Deletar");
                }
            else
                foreach (Curso curso in Curso.FindByUser(usuario))
                {
                    dgvCursos.Rows.Add(curso.Nome, "Editar", "Deletar");
                }
        }
    }
}
