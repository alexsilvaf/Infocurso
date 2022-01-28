using Infocurso;
using Infocurso.Model.Entities;
using System;
using System.Windows.Forms;

namespace Infocurso
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Alunos_Load(object sender, EventArgs e)
        {
            foreach (var usuario in Usuario.FindAll())
            {
                dgvAlunoLista.Rows.Add(usuario.Id, usuario.NomeCompleto, usuario.Email, usuario.DataNascimento.ToString("dd/MM/yyyy"),usuario.Telefone1, usuario.Telefone2, usuario.Rg, usuario.Cpf, usuario.SexoUsuario);
            }
            if (Usuario.FindAll().Count == 0)
            {
                lblInfo.Show();
            }
            dgvAlunoLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dgvAlunoLista.Rows.Clear();
            if (!txtPesquisa.Text.Equals(""))
            {
                foreach(Usuario usuario in Usuario.FindByNameHaving(txtPesquisa.Text))
                {
                    dgvAlunoLista.Rows.Add(usuario.Id, usuario.NomeCompleto, usuario.Email, usuario.DataNascimento, usuario.Telefone1, usuario.Telefone2, usuario.Rg, usuario.Cpf, usuario.SexoUsuario);
                }
            }
            else
            {
                foreach (Usuario usuario in Usuario.FindAll())
                {
                    dgvAlunoLista.Rows.Add(usuario.Id, usuario.NomeCompleto, usuario.Email, usuario.DataNascimento, usuario.Telefone1, usuario.Telefone2, usuario.Rg, usuario.Cpf, usuario.SexoUsuario);
                }
            }
        }
    }
}
