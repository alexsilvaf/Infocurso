using Infocurso.Forms;
using Infocurso.Model.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Infocurso{
    public partial class Cursos : Form
    {
        public static Curso CursoSelecionado = new Curso();
        public List<Curso> cursos = Curso.FindAll();

        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            foreach (Curso curso in cursos)
            {
                dgvCursos.Rows.Add(curso.Nome);
            }
        }

        private void dgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? quantAulas = 0;
            quantAulas = Aula.FindAll(CursoSelecionado.Id).Count;
            if (Aula.FindAll(CursoSelecionado.Id).Count > 0)
                InfoCurso.ShowNewForm(new Videos(CursoSelecionado, 1));
            else
                InfoCurso.ShowNewForm(new NoVideo(CursoSelecionado));
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            dgvCursos.Focus();
        }

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            string nomeCurso = dgvCursos.SelectedCells[0].Value.ToString();
            CursoSelecionado.Nome = nomeCurso;
            foreach (Curso x in Curso.FindAll())
            {
                if (x.Nome == nomeCurso)
                {
                    txtDescricao.Text = "Professor: " + x.Professor.NomeCompleto + "\r\nCategoria: " + x.Categoria.Nome + "\r\nNível: " + x.Nivel + "\r\n\r\nDescrição:\r\n" + x.Descricao;
                    CursoSelecionado = x;
                }
            }
        }
    }
}
