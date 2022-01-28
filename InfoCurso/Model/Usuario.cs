using Infocurso.Controller;
using System;

namespace Infocurso.Model.Entities
{
    public enum Sexo
    {
        Masculino = 1,
        Feminino
    }

    public class Usuario : UsuarioController
    {
        private int id;
        private string nomeCompleto;
        private string email;
        private string telefone1;
        private string telefone2;
        private string cpf;
        private string rg;
        private string senha;
        private DateTime dataNascimento;
        private int sexoUsuario;

        public Usuario() { }

        public Usuario(int id, string nomeCompleto, string email, string telefone1, string cpf, string rg, string senha, DateTime dataNascimento, int sexoUsuario)
        {
            this.id = id;
            this.nomeCompleto = nomeCompleto;
            this.email = email;
            this.telefone1 = telefone1;
            this.cpf = cpf;
            this.rg = rg;
            this.senha = senha;
            this.dataNascimento = dataNascimento;
            this.sexoUsuario = sexoUsuario;
        }

        public Usuario(int id, string nomeCompleto, string email, string telefone1, string telefone2, string cpf, string rg, string senha, DateTime dataNascimento, int sexoUsuario)
        {
            this.id = id;
            this.nomeCompleto = nomeCompleto;
            this.email = email;
            this.telefone1 = telefone1;
            this.telefone2 = telefone2;
            this.cpf = cpf;
            this.rg = rg;
            this.senha = senha;
            this.dataNascimento = dataNascimento;
            this.sexoUsuario = sexoUsuario;
        }

        public int Id { get => id; set => id = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone1 { get => telefone1; set => telefone1 = value; }
        public string Telefone2 { get => telefone2; set => telefone2 = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Senha { get => senha; set => senha = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int SexoUsuario { get => sexoUsuario; set => sexoUsuario = value; }
    }
}
