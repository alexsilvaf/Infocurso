using Infocurso;
using Infocurso.Model.Entities;
using InfoCurso.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infocurso.Controller
{
    public class CursoController
    {
        public static bool Insert(Curso curso)
        {
            int idNivel = 0;
            if (curso.Nivel.Equals(Nivel.Básico))
            {
                idNivel = 1;
            }
            else if(curso.Nivel.Equals(Nivel.Intermediário))
            {
                idNivel = 2;
            }
            else
            {
                idNivel = 3;
            }

            try
            {
                int afetados = 0;
                string sql = "INSERT INTO `db_infocourse`.`curs` (`nome`, `descricao`, `idProfessor`, `idNivl`, `idCatg`) VALUES (@nome, @descricao, @idProfessor, @idNivl, @idCatg);";


                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@nome", curso.Nome);
                    cmd.Parameters.AddWithValue("@descricao", curso.Descricao);
                    cmd.Parameters.AddWithValue("@idProfessor", curso.Professor.Id);
                    cmd.Parameters.AddWithValue("@idNivl", idNivel);
                    cmd.Parameters.AddWithValue("@idCatg", curso.Categoria.Id);

                    con.Open();
                    afetados = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return (afetados > 0);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return false;
            }
        }
        public static bool Delete(Curso curso)
        {
            try
            {
                int afetados = 0;
                string sql = "DELETE FROM `db_infocourse`.`curs` WHERE idCurs = @Id";

                Aula.DeleteAll(curso.Id);
                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@Id", curso.Id);

                    con.Open();
                    afetados = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return (afetados > 0);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return false;
            }
        }

        public static bool Edit(Curso curso)
        {
            int idNivel = 0;
            if (curso.Nivel.Equals(Nivel.Básico))
            {
                idNivel = 1;
            }
            else if (curso.Nivel.Equals(Nivel.Intermediário))
            {
                idNivel = 2;
            }
            else
            {
                idNivel = 3;
            }

            try
            {
                int afetados = 0;
                string sql = "UPDATE `db_infocourse`.`curs` SET `nome` = @nome, `descricao` = @descricao, `idProfessor` = @idProfessor,`idNivl` = @idNivl, `idCatg` = @idCatg  WHERE `idCurs` = @idCurs;";


                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@nome", curso.Nome);
                    cmd.Parameters.AddWithValue("@descricao", curso.Descricao);
                    cmd.Parameters.AddWithValue("@idProfessor", curso.Professor.Id);
                    cmd.Parameters.AddWithValue("@idNivl", idNivel);
                    cmd.Parameters.AddWithValue("@idCatg", curso.Categoria.Id);
                    cmd.Parameters.AddWithValue("@idCurs", curso.Id);

                    con.Open();
                    afetados = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return (afetados > 0);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return false;
            }
        }

        public static List<Curso> FindAll()
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    List<Curso> cursos = new List<Curso>();
                    string sql = "SELECT curs.*, usua.nome AS nomeProf, usua.email, usua.telefone1, usua.telefone2, usua.cpf, usua.rg, usua.senha, usua.dataNascimento, usua.idSexo FROM db_infocourse.curs "
                                + "INNER JOIN usua ON(usua.idUsua = curs.idProfessor); ";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);
                    
                    con.Open();

                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        Curso curso = new Curso();
                        curso.Id = Convert.ToInt32(leitor["idCurs"]);
                        curso.Nome = Convert.ToString(leitor["nome"]);
                        curso.Descricao = Convert.ToString(leitor["descricao"]);
                        curso.Professor = new Usuario(leitor.GetInt32("idProfessor"),leitor.GetString("nomeProf"),leitor.GetString("email"),leitor.GetString("telefone1"),leitor.GetString("cpf"),leitor.GetString("rg"), leitor.GetString("senha"), Convert.ToDateTime(leitor.GetString("dataNascimento")), leitor.GetInt32("idSexo"));
                        if (!leitor["telefone2"].ToString().Equals(""))
                            curso.Professor.Telefone2 = leitor.GetString("telefone2");
                        curso.Nivel = (Nivel)Convert.ToInt32(leitor["idNivl"]);
                        curso.Categoria = InfoCurso.categorias[leitor.GetInt32("idCatg") - 1];                        

                        cursos.Add(curso);
                    }
                    con.Close();
                    return cursos;
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }

        public static Curso FindByName(string nome)
        {
            List<Curso> cursos = Curso.FindAll();
            foreach (Curso curso in cursos)
            {
                if (curso.Nome.Equals(nome))
                {
                    foreach (Aula aula in Aula.FindAll(curso.Id))
                        curso.Aulas.Add(aula);
                    return curso;
                }
            }
            return null;
        }

        public static Curso FindById(int Id)
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {

                    Curso curso = new Curso();
                    curso.Aulas = Aula.FindAll(Id);

                    string sql = "SELECT *, usua.nome AS nomeProf, usua.email, usua.telefone1, usua.telefone2, usua.cpf, usua.rg, usua.senha, usua.dataNascimento, usua.idSexo FROM db_infocourse.curs "
                                + "INNER JOIN usua ON(usua.idUsua = curs.idProfessor) WHERE idCurs = @idCurs;";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);
                    cmd.Parameters.AddWithValue("@idCurs", Id);
                    con.Open();

                    MySqlDataReader leitor = cmd.ExecuteReader();

                    if (leitor.Read())
                    {
                        curso.Id = Convert.ToInt32(leitor["idCurs"]);
                        curso.Nome = Convert.ToString(leitor["nome"]);
                        curso.Descricao = Convert.ToString(leitor["descricao"]);
                        curso.Professor = new Usuario(leitor.GetInt32("idProfessor"), leitor.GetString("nomeProf"), leitor.GetString("email"), leitor.GetString("telefone1"), leitor.GetString("cpf"), leitor.GetString("rg"), leitor.GetString("senha"), Convert.ToDateTime(leitor.GetString("dataNascimento")), leitor.GetInt32("idSexo"));
                        if (!leitor["telefone2"].ToString().Equals(""))
                            curso.Professor.Telefone2 = leitor.GetString("telefone2");
                        curso.Nivel = (Nivel)Convert.ToInt32(leitor["idNivl"]);
                        curso.Categoria = InfoCurso.categorias[leitor.GetInt32("idCatg") - 1];
                        return curso;
                    }
                    else
                    {
                        return null;
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }

        public static List<Curso> FindByUser(Usuario usuario)
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    List<Curso> cursos = new List<Curso>();

                    string sql = "SELECT * FROM db_infocourse.curs WHERE idProfessor = @idUsua;";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);
                    cmd.Parameters.AddWithValue("@idUsua", usuario.Id);

                    con.Open();

                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        Curso curso = new Curso();
                        curso.Id = Convert.ToInt32(leitor["idCurs"]);
                        curso.Nome = Convert.ToString(leitor["nome"]);
                        curso.Descricao = Convert.ToString(leitor["descricao"]);
                        curso.Professor = usuario;
                        curso.Nivel = (Nivel)Convert.ToInt32(leitor["idNivl"]);
                        curso.Categoria = InfoCurso.categorias[leitor.GetInt32("idCatg") - 1];
                        cursos.Add(curso);
                    }
                    con.Close();
                    return cursos;
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }

        public static List<Curso> FindByNameHaving(string nome, Usuario usuario)
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    List<Curso> cursos = new List<Curso>();
                    string sql = "SELECT * FROM `db_infocourse`.`curs` WHERE `nome` LIKE @nome AND `idProfessor` = @idProfessor;";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    con.Open();

                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                    cmd.Parameters.AddWithValue("@idProfessor", usuario.Id);
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        Curso curso = new Curso();
                        curso.Id = Convert.ToInt32(leitor["idCurs"]);
                        curso.Nome = Convert.ToString(leitor["nome"]);
                        curso.Descricao = Convert.ToString(leitor["descricao"]);
                        curso.Professor = usuario;
                        curso.Nivel = (Nivel)Convert.ToInt32(leitor["idNivl"]);
                        curso.Categoria = InfoCurso.categorias[leitor.GetInt32("idCatg") - 1];
                        cursos.Add(curso);
                    }
                    con.Close();
                    return cursos;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return null;
            }
        }
    }
}
