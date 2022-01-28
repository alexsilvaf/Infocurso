using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infocurso.Model.Entities;
using Infocurso;

namespace Infocurso.Forms.VIdeos
{
    public partial class AddAula : Form
    {
        Curso curso = new Curso();
        string FileName = "";
        int aulaAtual = 0;

        public AddAula(Curso curso, int aulaAtual)
        {
            InitializeComponent();
            this.curso = curso;
            this.aulaAtual = aulaAtual;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula();
            aula.Titulo = txtNomeAula.Text;
            aula.Video = FileName;
            aula.IdCurs = curso.Id;

            if (aula.Titulo.Equals(""))
            {
                lblSucesso.ForeColor = Color.Red;
                lblSucesso.Text = "O título não pode estar vazio!";
                return;
            }
            if (Aula.FindByName(aula.Titulo, curso.Id) != null)
            {
                lblSucesso.ForeColor = Color.Red;
                lblSucesso.Text = "Já existe uma aula com este título!";
                return;
            }
            if (aula.Video.Equals(""))
            {
                lblSucesso.ForeColor = Color.Red;
                lblSucesso.Text = "O vídeo não pode estar vazio!";
                return;
            }
            else if (Aula.Insert(aula))
            {
                lblSucesso.ForeColor = Color.LimeGreen;
                lblSucesso.Text = "Aula cadastrada com Sucesso!";
            }
            else
            {
                lblSucesso.ForeColor = Color.Red;
                lblSucesso.Text = "Erro ao cadastrar!";
                return;
            }
            txtNomeAula.Text = "";
            txtFileVideo.Text = "";
            FileName = "";
            lblAula.Text = "Aula " + (Aula.FindAll(curso.Id).Count + 1).ToString() + " - ";

        }

		private void AddAula_Load(object sender, EventArgs e)
		{
            lblTitulo.Text = curso.Nome;
            lblAula.Text = "Aula " + (Aula.FindAll(curso.Id).Count + 1).ToString() + " - ";
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
            if (Aula.FindAll(curso.Id).Count > 0)
                InfoCurso.ShowNewForm(new Videos(curso, aulaAtual));
            else
            {
                InfoCurso.ShowNewForm(new NoVideo(curso));
            }
        }
    }
}
