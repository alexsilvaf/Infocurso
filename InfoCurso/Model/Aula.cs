using Infocurso.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infocurso.Model.Entities
{
    public class Aula : AulaController
    {
        private int id;
        private string titulo;
        private string video;
        private int idCurs;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Video { get => video; set => video = value; }
        public int IdCurs { get => idCurs; set => idCurs = value; }

        public Aula() { }
        public Aula(string Titulo, string Video, int idCurs)
        {
            this.Titulo = Titulo;
            this.Video = Video;
            this.IdCurs = idCurs;
        }
    }
}
