using Infocurso;
using Infocurso.Model.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Infocurso.Controller
{
    public class AulaController
    {
        public static bool Insert(Aula aula)
        {
            try
            {
                int afetados = 0;
                string sql = "INSERT INTO `db_infocourse`.`aula` "+
                             "(`titulo`, `video`, idCurs) VALUES "+
                             "(@titulo, @video, @idCurs);";

                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@titulo", aula.Titulo);
                    cmd.Parameters.AddWithValue("@video", aula.Video);
                    cmd.Parameters.AddWithValue("@idCurs", aula.IdCurs);

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

        public static List<Aula> FindAll(int idCurso)
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    List<Aula> alunos = new List<Aula>();
                    string sql = "SELECT `aula`.`idAula`,`aula`.`titulo`,`aula`.`video`,`aula`.`idCurs` " +
                                 "FROM `db_infocourse`.`aula` WHERE idCurs = @idCurs;";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@idCurs", idCurso);


                    con.Open();

                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        Aula aula = new Aula();
                        aula.Id = Convert.ToInt32(leitor["idAula"]);
                        aula.Titulo = Convert.ToString(leitor["titulo"]);
                        aula.Video = Convert.ToString(leitor["video"]);
                        aula.IdCurs = Convert.ToInt32(leitor["idCurs"]);

                        alunos.Add(aula);
                    }
                    con.Close();
                    return alunos;
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }

        public static Aula FindByName(string nome, int idCurso)
        {
            List<Aula> aulas = Aula.FindAll(idCurso);
            foreach (Aula aula in aulas)
            {
                if (aula.Titulo.Equals(nome))
                {
                    return aula;
                }
            }
            return null;
        }

        public static bool Edit(Aula aula)
        {
            try
            {
                int afetados = 0;
                string sql = "UPDATE `db_infocourse`.`aula` SET `titulo` = @titulo, `video` = @video, `idCurs` = @idCurs WHERE (`idAula` = @idAula);";

                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@titulo", aula.Titulo);
                    cmd.Parameters.AddWithValue("@video", aula.Video);
                    cmd.Parameters.AddWithValue("@idCurs", aula.IdCurs);
                    cmd.Parameters.AddWithValue("@idAula", aula.Id);

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

        public static bool Delete(int Id)
        {
            try
            {
                int afetados = 0;
                string sql = "DELETE FROM `db_infocourse`.`aula` WHERE idAula = @idAula";

                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@idAula", Id);

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

        public static bool DeleteAll(int IdCurso)
        {
            try
            {
                int afetados = 0;
                string sql = "DELETE FROM `db_infocourse`.`aula` WHERE idCurs = @idCurs";

                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@idCurs", IdCurso);

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
    }
}
