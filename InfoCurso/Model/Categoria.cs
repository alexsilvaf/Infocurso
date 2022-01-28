using Infocurso.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCurso.Model
{
    public class Categoria : CategoriaController
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public Categoria() { }
        public Categoria(int Id, string Nome)
        {
            this.id = Id;
            this.nome = Nome;
        }
    }
}
