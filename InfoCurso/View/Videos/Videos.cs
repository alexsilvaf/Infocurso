using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Infocurso.Forms.VIdeos;
using Infocurso.Model.Entities;
using WMPLib;

namespace Infocurso.Forms
{
    public partial class Videos : Form
    {
        bool dgvAulasState = false;
        Curso cursoAtual = null;
        int aulaSelecionada = 1;
        Aula aula = null;

        public Videos(Curso curso, int aulaSelecionada)
        {
            InitializeComponent();
            cursoAtual = curso;
            this.aulaSelecionada = aulaSelecionada;
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            wmpVideo.URL = "C:\\Users\\Alex\\Videos\\teste.mp4";
            pnlMenuAulas.Location = new Point(this.Width - 42, 10);
            lblTitulo.Text = cursoAtual.Nome;
            if (Aula.FindAll(cursoAtual.Id).Count() > 0)
            {
                this.aula = Aula.FindAll(cursoAtual.Id)[aulaSelecionada - 1];
                lblTituloAula.Text = "Aula " + aulaSelecionada + " - " + aula.Titulo;
                wmpVideo.URL = aula.Video;
                wmpVideo.Ctlcontrols.stop();
            }

            int i = 1;
            foreach (Aula aula in Aula.FindAll(cursoAtual.Id))
            {
                dgvAulas.Rows.Add("Aula " + i + " - " + aula.Titulo);
                i++;
            }


            if (InfoCurso.user.Equals(cursoAtual.Professor.NomeCompleto.Split(' ')[0]))
            {
                ptbAdicionar.Show();
                ptbEditar.Show();
                ptbExcluir.Show();
            }
        }

        private void Videos_SizeChanged(object sender, EventArgs e)
        {
            pnlMenuAulas.Location = new Point(this.Width - 42, 10);
            lblTituloAula.MaximumSize = new Size(wmpVideo.Width, 0);
            if (Width > 1400)
            {
                lblTitulo.Font = new Font(lblTituloAula.Font.FontFamily, 24.0f, lblTituloAula.Font.Style, lblTituloAula.Font.Unit, lblTituloAula.Font.GdiCharSet, lblTituloAula.Font.GdiVerticalFont);
            }
            else
            {
                lblTitulo.Font = new Font(lblTituloAula.Font.FontFamily, 18.0f, lblTituloAula.Font.Style, lblTituloAula.Font.Unit, lblTituloAula.Font.GdiCharSet, lblTituloAula.Font.GdiVerticalFont);
            }
        }

        private void dgvAulas_Click(object sender, EventArgs e)
        {
            string aulaSelecionada = dgvAulas.SelectedCells[0].Value.ToString();
            int i = 1;
            foreach (Aula aula in Aula.FindAll(cursoAtual.Id))
            {
                if ("Aula " + i + " - " + aula.Titulo == aulaSelecionada)
                {
                    lblTituloAula.Text = "Aula " + i + " - " + aula.Titulo;
                    wmpVideo.URL = aula.Video;
                    wmpVideo.Ctlcontrols.stop();
                    this.aulaSelecionada = dgvAulas.CurrentCell.RowIndex + 1;
                    this.aula = Aula.FindByName(aula.Titulo, cursoAtual.Id);
                }
                i++;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (dgvAulasState)
            {
                pnlAulas.Hide();
                dgvAulasState = false;
            }

            InfoCurso.ShowNewForm(new AddAula(cursoAtual, aulaSelecionada));
        }

        private void ptbAulasB_MouseLeave(object sender, EventArgs e)
        {
            ptbAulas.Show();
            ptbAulasB.Hide();
        }

        private void ptbAulas_MouseEnter(object sender, EventArgs e)
        {
            ptbAulasB.Show();
            ptbAulas.Hide();
        }

        private void ptbAulasB_Click(object sender, EventArgs e)
        {
            if (dgvAulasState)
            {
                tlpMenu.Hide();
                dgvAulasState = false;
            }
            else
            {
                tlpMenu.Show();
                dgvAulasState = true;
            }
            dgvAulas.CurrentCell = this.dgvAulas[0, aulaSelecionada - 1];
        }

        private void ptbAdicionar_MouseEnter(object sender, EventArgs e)
        {
            ptbAdicionarR.Show();
            ptbAdicionar.Hide();
        }

        private void ptbEditar_MouseEnter(object sender, EventArgs e)
        {
            ptbEditarR.Show();
            ptbEditar.Hide();
        }

        private void ptbExcluir_MouseEnter(object sender, EventArgs e)
        {
            ptbExcluirR.Show();
            ptbExcluir.Hide();
        }

        private void ptbAdicionarR_MouseLeave(object sender, EventArgs e)
        {

            ptbAdicionar.Show();
            ptbAdicionarR.Hide();
        }

        private void ptbEditarR_MouseLeave(object sender, EventArgs e)
        {
            ptbEditar.Show();
            ptbEditarR.Hide();
        }

        private void ptbExcluirR_MouseLeave(object sender, EventArgs e)
        {
            ptbExcluir.Show();
            ptbExcluirR.Hide();
        }

        private void ptbPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
        }

        private void ptbPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void ptbStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void ptbFull_Click(object sender, EventArgs e)
        {
            wmpVideo.fullScreen = true;
        }

        private void ptbAdicionarR_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new AddAula(cursoAtual, aulaSelecionada));
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
            InfoCurso.ShowNewForm(new Cursos());
        }

        private void ptbEditarR_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new EditAula(aula, aulaSelecionada));
        }

        private void ptbExcluirR_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Tem certeza que deseja excluir a Aula " + aulaSelecionada + "?",
                "Alerta!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                Aula.Delete(aula.Id);
                if (Aula.FindAll(cursoAtual.Id).Count == 0)
                    InfoCurso.ShowNewForm(new NoVideo(cursoAtual));
                else if(Aula.FindAll(cursoAtual.Id).Count == aulaSelecionada - 1)
                    InfoCurso.ShowNewForm(new Videos(cursoAtual, aulaSelecionada - 1));
                else
                    InfoCurso.ShowNewForm(new Videos(cursoAtual, aulaSelecionada));
            }
        }
    }
}
