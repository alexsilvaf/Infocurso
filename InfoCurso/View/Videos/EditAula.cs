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

namespace Infocurso.Forms.VIdeos
{
    public partial class EditAula : Form
    {
        Aula aula = null;
        Curso curso = null;
        int aulaAtual = 0;
        string FileName = "";

        public EditAula(Aula aula, int aulaAtual)
        {
            InitializeComponent();
            this.aula = aula;
            curso = Curso.FindById(aula.IdCurs);
            this.aulaAtual = aulaAtual;
        }

        private void EditAula_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Focus();
            lblTitulo.Text = curso.Nome;
            txtNomeAula.Text = aula.Titulo;
            txtFileVideo.Text = aula.Video;
        }

        private void ptbVoltar_MouseEnter(object sender, EventArgs e)
        {
            ptbVoltarR.Show();
            ptbVoltar.Hide();
        }

        private void ptbVoltar_MouseLeave(object sender, EventArgs e)
        {
            ptbVoltar.Show();
            ptbVoltarR.Hide();
        }

        private void ptbVoltarR_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new Videos(curso,aulaAtual));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            aula.Video = txtFileVideo.Text;
            aula.Titulo = txtNomeAula.Text;
            int i = 1;
            foreach (Aula aula in curso.Aulas)
            {
                if(aula.Titulo.Equals(txtNomeAula.Text) && aula.Id != this.aula.Id)
                {
                    lblSucesso.ForeColor = Color.Red;
                    lblSucesso.Text = "Erro: Nome da aula já existe neste curso!";
                    return;
                }
                if(aula.Video.Equals(txtFileVideo.Text) && aula.Id != this.aula.Id)
                {
                    lblSucesso.ForeColor = Color.Red;
                    lblSucesso.Text = "Erro: Vídeo da aula já existe neste curso!";
                    return;
                }
                i++;
            }
            if (Aula.Edit(aula))
            {
                lblSucesso.ForeColor = Color.LimeGreen;
                lblSucesso.Text = "Alteraçoes salvas com sucesso!";
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Video Files (*.mp4)|*.mp4|" +
                "Video Files (*.m4v)|*.m4v| " +
                "Video Files (*.mov)|*.mov| " +
                "Video Files (*.avi)|*.avi| " +
                "Video Files (*.mpg)|*.mpg| " +
                "Video Files (*.mpeg)|*.mpeg| " +
                "Video Files (*.wmv)|*.wmv";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                txtFileVideo.Text = FileName;
            }
        }
    }
}
