using Infocurso.Model.Entities;
using InfoCurso.Model;
using System;
using System.Windows.Forms;

namespace Infocurso.Forms
{
    public partial class CadastroCurso : Form
    {
        public bool isSelecton = false;
        public int erro = 0;

        public CadastroCurso()
        {
            InitializeComponent();
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

        private void lbxCategoria_TabIndexChanged(object sender, EventArgs e)
        {
            if(lbxCategoria.SelectedItem != null)
                txtCategoria.Text = lbxCategoria.SelectedItem.ToString();
        }

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

        private void btnCadastrar_Click(object sender, EventArgs e) => Cadastrar();

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
            if (lbxCategoria.SelectedItem != null) { 
                if (lbxCategoria.SelectedItem.ToString().Equals(txtCategoria.Text))
                {
                    tableLayoutPanel1.Focus();
                }
                lbxCategoria.Hide();
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
                lbxCategoria.Items.Add(cat.Nome);
        }

        private void Cadastrar()
        {
            lblErroNomeCurso.Text = "";
            lblErroProfessor.Text = "";
            lblErroCategoria.Text = "";
            lblErroNivel.Text = "";
            lblSucesso.Text = "";

            if (Curso.FindByName(txtNomeCurso.Text) != null)
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

            curso.Nome = txtNomeCurso.Text;
            curso.Professor = Usuario.FindById(InfoCurso.userId);
            curso.Categoria = Categoria.FindAll()[lbxCategoria.SelectedIndex];
            curso.Nivel = (Nivel)lbxNivel.SelectedIndex + 1;
            curso.Descricao = txtDescricao.Text;

            Curso.Insert(curso);

            txtNomeCurso.Text = "";
            txtCategoria.Text = "";
            txtNivel.Text = "";
            txtDescricao.Text = "";
            lblSucesso.Text = "Curso cadastrado com sucesso!";
            txtNomeCurso.Focus();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new CadCategoria());
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            lbxCategoria.Focus();
        }
    }
}
