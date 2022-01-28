using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infocurso.Forms;
using Infocurso.Model.Entities;

namespace Infocurso
{
    public partial class EditarUsuario : Form
    {
        Utils utils = new Utils();
        Usuario usuario = null;
        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;
        int[] letrasTelefone = new int[3];
        int letrasCpf = 0;
        int letrasRg = 0;

        public EditarUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            txtNomeCompleto.Text = usuario.NomeCompleto;
            txtSenha.Text = usuario.Senha;
            txtTelefone1.Text = usuario.Telefone1;
            txtTelefone2.Text = usuario.Telefone2;
            txtEmail.Text = usuario.Email;
            txtRg.Text = usuario.Rg;
            txtCpf.Text = usuario.Cpf;
            dtpDataNascimento.Value = usuario.DataNascimento;

            if(usuario.SexoUsuario == 1)
            {
                rdbMasculino.Checked = true;
            }
            else
            {
                rdbFeminino.Checked = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int AnoDataNascimento = dtpDataNascimento.Value.Year;
            int AnoAtual = DateTime.Now.Year;
            int AnoAluno = AnoAtual - AnoDataNascimento;

            lblSucesso.Text = "";
            lblErroSenha.Text = "";
            lblErroNomeCompleto.Text = "";
            lblErroEmail.Text = "";
            lblErroTelefone.Text = "";
            lblErroTelefone2.Text = "";
            lblErroDataNascimento.Text = "";
            lblErroSexo.Text = "";
            lblErroRg.Text = "";
            lblErroCpf.Text = "";

            Usuario novoUsuario = new Usuario();

            int erro = 0;
            if (txtNomeCompleto.Text.Equals(""))
            {
                lblErroNomeCompleto.Text = "Campo Obrigatório!";
                erro++;
            }
            else if (!txtNomeCompleto.Text.Contains(" "))
            {
                lblErroNomeCompleto.Text = "Por favor, insira o nome completo";
                erro++;
            }
            if (txtEmail.Text.Equals(""))
            {
                lblErroEmail.Text = "Campo Obrigatório!";
                erro++;
            }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                lblErroEmail.Text = "Campo incorreto.";
                erro++;
            }
            if (txtSenha.Text.Equals(""))
            {
                lblErroSenha.Text = "Campo Obrigatório!";
            }
            if (txtSenha.TextLength < 8)
            {
                lblErroSenha.Text = "A senha precisa ter pelo menos 8 caracteres.";
            }
            if (txtTelefone1.Text.Equals(""))
            {
                lblErroTelefone.Text = "Campo Obrigatório!";
                erro++;
            }
            else if (txtTelefone1.TextLength < 14)
            {
                lblErroTelefone.Text = "Campo incompleto.";
                erro++;
            }
            if (txtTelefone2.TextLength > 0)
            {
                if (txtTelefone2.TextLength < 14)
                {
                    lblErroTelefone2.Text = "Campo incompleto.";
                    erro++;
                }
            }
            if (AnoAluno <= 12 || AnoAluno >= 122)
            {
                lblErroDataNascimento.Text = "Idade Incorreta";
                erro++;
            }
            if (rdbMasculino.Checked)
            {
                novoUsuario.SexoUsuario = 1;
            }
            else if (rdbFeminino.Checked)
            {
                novoUsuario.SexoUsuario = 2;
            }
            else
            {
                lblErroSexo.Text = "Campo Obrigatório!";
                erro++;
            }
            if (txtRg.TextLength == 0)
            {
                lblErroRg.Text = "Campo Obrigatório!";
                erro++;
            }
            else if (txtRg.TextLength < 9)
            {
                lblErroRg.Text = "Campo incompleto.";
                erro++;
            }
            if (txtCpf.TextLength == 0)
            {
                lblErroCpf.Text = "Campo Obrigatório!";
                erro++;
            }
            else if (txtCpf.TextLength < 14)
            {
                lblErroCpf.Text = "Campo incompleto.";
                erro++;
            }
            if (erro > 0)
                return;

            novoUsuario.Id = usuario.Id;
            novoUsuario.NomeCompleto = txtNomeCompleto.Text;
            novoUsuario.Senha = txtSenha.Text;
            novoUsuario.Email = txtEmail.Text;
            novoUsuario.Telefone1 = txtTelefone1.Text;
            novoUsuario.Telefone2 = txtTelefone2.Text;
            novoUsuario.Cpf = txtCpf.Text;
            novoUsuario.Rg = txtRg.Text;
            novoUsuario.DataNascimento = dtpDataNascimento.Value;

            if (Usuario.Edit(novoUsuario)) {
                lblSucesso.ForeColor = Color.LimeGreen;
                lblSucesso.Text = "Dados salvos com sucesso!";;
            }
            else
            {
                lblSucesso.ForeColor = Color.Red;
                lblSucesso.Text = "Falha ao salvar";
            }
            lblSucesso.Location = new Point(pnlDados.Width - lblSucesso.Width - 12, lblSucesso.Location.Y);
        }

        private void txtTelefone1_TextChanged(object sender, EventArgs e)
        {
            utils.mascaraTelefone(txtTelefone1, ref letrasTelefone[0]);
        }

        private void txtTelefone2_TextChanged(object sender, EventArgs e)
        {
            utils.mascaraTelefone(txtTelefone2, ref letrasTelefone[1]);
        }


        //DOC: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.control.keypress?view=windowsdesktop-6.0
        // Handle the KeyDown event to determine the type of character entered into the control.
        private void txtTelefone_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This event occurs after the KeyDown event and can be used to prevent
            // characters from entering the control.
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

       private void btnVoltar_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new Login(ActiveForm));
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
            InfoCurso.ShowNewForm(new MyAccount(usuario.Id));
        }
    }
}
