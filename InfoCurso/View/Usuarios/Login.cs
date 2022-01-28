using Infocurso.Model.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Infocurso.Forms
{
    public partial class Login : Form
    {
        Utils utils = new Utils();
        InfoCurso mainForm;

        int letrasCpf = 0;
        private bool nonNumberEntered = false;

        public Login(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = (InfoCurso) mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarFormulario();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            utils.mascaraCpf(txtLogin, ref letrasCpf);
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Enter)
            {
                validarFormulario();
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                validarFormulario();
        }

        private void validarFormulario()
        {
            foreach (Usuario usuario in Usuario.FindAll())
            {
                if(txtLogin.Text.Equals(usuario.Cpf) && txtSenha.Text.Equals(usuario.Senha))
                {
                    InfoCurso.user = usuario.NomeCompleto.Split(' ')[0];
                    InfoCurso.userId = usuario.Id;
                    mainForm.iniciarUsuario();
                    InfoCurso.ShowNewForm(new MenuPrincipal());
                }
            }
            if(InfoCurso.user.Equals(""))
            lblErroLogin.Text = "Usuário ou Senha incorretos.";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new CadastroUsuario());
        }
    }
}
