using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infocurso.Forms.VIdeos;
using Infocurso.Model.Entities;
using Infocurso;

namespace Infocurso
{
    public partial class NoVideo : Form
    {
        Curso curso = new Curso();
        public NoVideo(Curso Curso)
        {
            InitializeComponent();
            curso = Curso;
        }

        private void NoVideo_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = curso.Nome;
            if(curso.Professor.Id == InfoCurso.userId)
            {
                btnAdicionar.Show();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new AddAula(curso, 1));
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

        private void NoVideo_SizeChanged(object sender, EventArgs e)
        {
            lblTitulo.Location = new Point(lblTituloAula.Location.X - pnlVoltar.Width, lblTitulo.Location.Y);
        }
    }
}
