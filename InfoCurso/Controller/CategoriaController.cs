using Infocurso;
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
    public class CategoriaController
    {
        public static List<Categoria> FindAll()
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    List<Categoria> categorias = new List<Categoria>();
                    string sql = "SELECT `catg`.`idCatg`,`catg`.`nome` " +
                                 "FROM `db_infocourse`.`catg` order by `idCatg`;";


                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);
                    
                    con.Open();

                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        Categoria categoria = new Categoria();
                        categoria.Id = leitor.GetInt32("idCatg");
                        categoria.Nome = leitor.GetString("nome");

                        categorias.Add(categoria);
                    }
                    con.Close();
                    return categorias;
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }

        public static bool Insert(Categoria categoria)
        {
            try
            {
                int afetados = 0;
                string sql = "INSERT INTO `db_infocourse`.`catg` (`nome`) VALUES (@nome);";

                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@nome", categoria.Nome);

                    
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
