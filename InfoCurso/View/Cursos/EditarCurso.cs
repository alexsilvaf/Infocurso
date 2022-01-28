using Infocurso.Model.Entities;
using InfoCurso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infocurso.Forms
{
    public partial class EditCurso : Form
    {
        public bool isSelecton = false;
        public int erro = 0;
        Curso curso = new Curso();

        public EditCurso(int Id)
        {
            InitializeComponent();
            this.curso = Curso.FindById(Id);
        }

        private void EditCurso_Load(object sender, EventArgs e)
        {
            txtNomeCurso.Text = curso.Nome;
            txtProfessor.Text = curso.Professor.NomeCompleto;
            txtNivel.Text = curso.Nivel.ToString();
            txtCategoria.Text = curso.Categoria.Nome.ToString();
            txtDescricao.Text = curso.Descricao.ToString();

            if (InfoCurso.user == "Admin")
                btnCategoria.Show();

            foreach (Categoria categoria in Categoria.FindAll())
                lbxCategoria.Items.Add(categoria.Nome);
        }
        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (isSelecton == false && !lbxCategoria.Focused)
            {
                lbxCategoria.Visible = true;
                lbxCategoria.Focus();
            }
            else
            {
                isSelecton = false;
            }
        }

        private void lbxCategoria_TabIndexChanged(object sender, EventArgs e) => txtCategoria.Text = lbxCategoria.SelectedItem.ToString();

        private void lbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbxCategoria.Hide();
                lbxNivel.Focus();
            }
        }

        private void lbxCategoria_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && lbxCategoria.Focused)
            {
                lbxCategoria.Hide();
            }
        }

        private void lbxCategoria_Leave(object sender, EventArgs e)
        {
            if (!lbxCategoria.Focused)
            {
                lbxCategoria.Hide();
            }
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            lbxCategoria.Show();
            lbxCategoria.Focus();
        }

        private void txtNivel_Enter(object sender, EventArgs e)
        {
            if (isSelecton == false && !lbxNivel.Focused)
            {
                lbxNivel.Visible = true;
                lbxNivel.Focus();
            }
            else
            {
                isSelecton = false;
            }
        }

        private void lbxNivel_TabIndexChanged(object sender, EventArgs e) => txtNivel.Text = lbxNivel.SelectedItem.ToString();

        private void lbxNivel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbxNivel.Hide();
                txtNivel.Focus();
            }
        }

        private void lbxNivel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && lbxNivel.Focused)
            {
                lbxNivel.Hide();
            }
        }

        private void lbxNivel_Leave(object sender, EventArgs e)
        {
            if (!lbxNivel.Focused)
            {
                lbxNivel.Hide();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) => Editrar();

        private void CadastroCurso_MouseClick(object sender, MouseEventArgs e)
        {
            lbxCategoria.Hide();
            lbxNivel.Hide();
        }

        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            lbxNivel.Show();
            lbxNivel.Focus();
        }

        private void lbxCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            lbxCategoria.Hide();
            if (lbxCategoria.SelectedItem.ToString().Equals(txtCategoria.Text))
            {
                tableLayoutPanel1.Focus();
            }
        }

        private void lbxNivel_MouseClick(object sender, MouseEventArgs e)
        {
            lbxNivel.Hide();
            if (lbxNivel.SelectedItem.ToString().Equals(txtNivel.Text))
            {
                tableLayoutPanel1.Focus();
            }
        }

        private void CadastroCurso_Load(object sender, EventArgs e)
        {
            txtProfessor.Text = Usuario.FindById(InfoCurso.userId).NomeCompleto;
            if (InfoCurso.user.Equals("Admin"))
                btnCategoria.Show();
            foreach (Categoria cat in Categoria.FindAll())
            {
                lbxCategoria.Items.Add(cat.Nome);
            }
        }

        private void Editrar()
        {
            lblErroNomeCurso.Text = "";
            lblErroProfessor.Text = "";
            lblErroCategoria.Text = "";
            lblErroNivel.Text = "";
            lblSucesso.Text = "";

            Curso cursoEncontrado = Curso.FindByName(txtNomeCurso.Text);
            if (cursoEncontrado != null && cursoEncontrado.Id != this.curso.Id)
            {
                lblErroNomeCurso.Text = "Nome já existe!";
                erro++;
            }
            if (txtNomeCurso.Text.Equals(""))
            {
                lblErroNomeCurso.Text = "Campo obrigatório!";
                erro++;
            }
            if (txtProfessor.Text.Equals(""))
            {
                lblErroProfessor.Text = "Campo obrigatório!";
                erro++;
            }
            if (txtCategoria.Text.Equals(""))
            {
                lblErroCategoria.Text = "Campo obrigatório!";
                erro++;
            }
            if (txtNivel.Text.Equals(""))
            {
                lblErroNivel.Text = "Campo obrigatório!";
                erro++;
            }

            if (erro > 0)
            {
                erro = 0;
                return;
            }

            Curso curso = new Curso();

            curso.Id = this.curso.Id;
            curso.Nome = txtNomeCurso.Text;
            curso.Professor = Usuario.FindById(InfoCurso.userId);
            if (lbxCategoria.SelectedIndex == -1)
                curso.Categoria = this.curso.Categoria;
            else
                curso.Categoria = Categoria.FindAll()[lbxCategoria.SelectedIndex];
            if (lbxNivel.SelectedIndex == -1)
                curso.Nivel = this.curso.Nivel;
            else
                curso.Nivel = (Nivel)lbxNivel.SelectedIndex + 1;
            curso.Descricao = txtDescricao.Text;

            if (Curso.Edit(curso))
            {
                lblSucesso.ForeColor = Color.LimeGreen;
                lblSucesso.Text = "Curso cadastrado com sucesso!";
                txtNomeCurso.Focus();
            }
            else
            {
                lblSucesso.ForeColor = Color.Red;
                lblSucesso.Text = "Falha ao editar.";
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new CadCategoria());
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            lbxCategoria.Focus();
        }

        private void txtNivel_TextChanged(object sender, EventArgs e)
        {
            lbxNivel.Focus();
        }

        private void ptbVoltar_MouseEnter(object sender, EventArgs e)
        {
            ptbVoltarR.Show();
            ptbVoltar.Hide();
        }

        private void ptbVoltarR_MouseLeave(object sender, EventArgs e)
        {
            ptbVoltar.Show();
            ptbVoltarR.Hide();
        }

        private void ptbVoltarR_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new MyAccount(curso.Professor.Id));
        }
    }
}
