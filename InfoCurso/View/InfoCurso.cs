using Infocurso.Forms;
using Infocurso.Model.Entities;
using InfoCurso.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Infocurso
{
    public partial class InfoCurso : Form
    {
        public static List<Categoria> categorias = Categoria.FindAll();
        public static string user = "";
        public static int userId = 0;
        private bool tlpMenuState = false;
        public static Form thisForm = new Form();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public InfoCurso()
        {
            InitializeComponent();
        }

        public void AbrirPrograma(Form childForm)
        {
            thisForm.Dispose();
            childForm.MdiParent = this;
            childForm.ControlBox = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            thisForm = childForm;
        }
        public static void ShowNewForm(Form childForm)
        {
            thisForm.Dispose();
            childForm.MdiParent = ActiveForm;
            childForm.ControlBox = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            thisForm = childForm;
        }

        private void InfoCurso_Load(object sender, EventArgs e)
        {
            //Exibir o Formulário de Login
            AbrirPrograma(new Login(this));
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //PAINEL       
        private void btnMenuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimizarR_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void ptbMaximizarR_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) { 
                WindowState = FormWindowState.Normal;
                ReposicionarBordas();
            }
            else { 
                WindowState=FormWindowState.Maximized;
                ReposicionarBordas();
            }
        }

        private void ReposicionarBordas()
        {
            pnlLeft.Height = this.Height - tlpMenuStrip.Height;
            pnlUp.Width = this.Width;
            pnlRight.Height = this.Height - tlpMenuStrip.Height;
            pnlDown.Width = this.Width;
            if (tlpMenu.Visible)
                pnlLeft.Location = new Point(tlpMenu.Width, tlpMenuStrip.Height);
            else
                pnlLeft.Location = new Point(0, tlpMenuStrip.Height);
            pnlUp.Location = new Point(0, tlpMenuStrip.Height);
            pnlRight.Location = new Point(this.Width - 2, tlpMenuStrip.Height);
            pnlDown.Location = new Point(0, this.Height - 2);
        }

        public void iniciarUsuario()
        {
            ptbMenuBar.Visible = true;
            lblUser.Text = user;
            dgvItens.Rows.Add("Página Inicial");
            dgvItens.Rows.Add("Cursos");
            if (user.Equals("Admin"))
                dgvItens.Rows.Add("Listar Usuários");
            dgvItens.Rows.Add("Cadastrar Curso");
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string menuSelect = dgvItens.SelectedCells[0].Value.ToString();
            switch (menuSelect)
            {
                case "Página Inicial":
                    ShowNewForm(new MenuPrincipal());
                    break;
                case "Cursos":
                    ShowNewForm(new Cursos());
                    break;
                case "Listar Usuários":
                    ShowNewForm(new Usuarios());
                    break;
                case "Cadastrar Curso":
                    ShowNewForm(new CadastroCurso());
                    break;
                default:
                    MessageBox.Show("O programa não reconhece o valor selecionado", "Opção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ptbMyAccount_MouseEnter(object sender, EventArgs e)
        {
            ptbMyAccount.Hide();
            ptbMyAccountG.Show();
        }

        private void ptbMyAccountG_MouseLeave(object sender, EventArgs e)
        {
            ptbMyAccountG.Hide();
            ptbMyAccount.Show();
        }

        private void ptbMenuBarR_MouseLeave(object sender, EventArgs e)
        {
            ptbMenuBar.Show();
            ptbMenuBarR.Hide();
        }

        private void ptbMenuBarR_Click(object sender, EventArgs e)
        {
            if (tlpMenuState)
            {
                tlpMenu.Hide();
                tlpMenuState = false;
                pnlLeft.Location = new Point(0, tlpMenuStrip.Height);
            }
            else
            {
                tlpMenu.Show();
                tlpMenuState = true;
                pnlLeft.Location = new Point(tlpMenu.Width, tlpMenuStrip.Height);
            }
        }

        private void ptbMenuBar_MouseEnter(object sender, EventArgs e)
        {
            ptbMenuBarR.Show();
            ptbMenuBar.Hide();
        }

        private void ptbMaximizar_MouseEnter(object sender, EventArgs e)
        {
            ptbMaximizarR.Show();
            ptbMaximizar.Hide();
        }

        private void ptbMaximizarR_MouseLeave(object sender, EventArgs e)
        {
            ptbMaximizar.Show();
            ptbMaximizarR.Hide();
        }

        private void ptbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            ptbMinimizarR.Show();
            ptbMinimizar.Hide();
        }

        private void ptbMinimizarR_MouseLeave(object sender, EventArgs e)
        {
            ptbMinimizar.Show();
            ptbMinimizarR.Hide();
        }

        private void lblUser_SizeChanged(object sender, EventArgs e)
        {
            lblUser.Location = new Point(this.Width - 160 - lblUser.Size.Width, lblUser.Location.Y);
        }

        private void ptbMyAccountG_Click(object sender, EventArgs e)
        {
            if(userId != 0)
                ShowNewForm(new MyAccount(userId));
        }
    }
}
