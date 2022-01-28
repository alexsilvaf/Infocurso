using Infocurso.Controller;
using InfoCurso.Model;
using System.Collections.Generic;

namespace Infocurso.Model.Entities
{
    public enum Nivel
    {
        Básico = 1,
        Intermediário,
        Avançado
    }

    public class Curso : CursoController
    {
        private int id;
        private string nome;
        private string descricao;
        private Categoria categoria;
        private Nivel nivel;
        private Usuario professor;

        public List<Aula> Aulas = new List<Aula>();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public Nivel Nivel { get => nivel; set => nivel = value; }
        public Usuario Professor { get => professor; set => professor = value; }

        public Curso() { }
        public Curso(string Nome, string Descricao, Categoria Categoria, Nivel Nivel, Usuario Professor)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Categoria = Categoria;
            this.Nivel = Nivel;
            this.Professor = Professor;
        }
    }
}
