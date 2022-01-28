using Infocurso;
using Infocurso.Model.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infocurso.Controller
{

    public class UsuarioController
    {
        public static bool Insert(Usuario usuario)
        {

            try
            {
                int afetados = 0;
                string sql = "INSERT INTO `db_infocourse`.`usua` (`nome`, `email`, `telefone1`, `telefone2`, `cpf`, `rg`, `senha`, `dataNascimento`, `idSexo`) VALUES (@nome, @email, @telefone1, @telefone2, @cpf, @rg, @senha, @dataNascimento, @idSexo);";


                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@nome", usuario.NomeCompleto);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@telefone1", usuario.Telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", usuario.Telefone2);
                    cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                    cmd.Parameters.AddWithValue("@rg", usuario.Rg);
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@dataNascimento", usuario.DataNascimento);
                    cmd.Parameters.AddWithValue("@idSexo", usuario.SexoUsuario);

                    
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

        public static bool Edit(Usuario usuario)
        {
            try
            {
                int afetados = 0;
                string sql = "UPDATE `db_infocourse`.`usua` SET `nome` = @nome, `email` = @email, `telefone1` = @telefone1, `telefone2` = @telefone2, `senha` = @senha, `dataNascimento` = @dataNascimento, `idSexo` = @idSexo WHERE `idUsua` = @idUsua";

                using (MySqlConnection con = Conn.db)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    cmd.Parameters.AddWithValue("@nome", usuario.NomeCompleto);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@telefone1", usuario.Telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", usuario.Telefone2);
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@dataNascimento", usuario.DataNascimento);
                    cmd.Parameters.AddWithValue("@idSexo", usuario.SexoUsuario);
                    cmd.Parameters.AddWithValue("@idUsua", usuario.Id);


                    con.Open();
                    afetados = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return false;
            }
        }

        public static List<Usuario> FindAll()
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    List<Usuario> usuarios = new List<Usuario>();
                    string sql = "SELECT * FROM `db_infocourse`.`usua`;";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);
                    
                    con.Open();

                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(leitor["idUsua"]);
                        usuario.NomeCompleto = leitor.GetString("nome");
                        usuario.Email = leitor.GetString("email");
                        usuario.Telefone1 = leitor.GetString("telefone1");
                        if (leitor["telefone2"].Equals(""))
                            usuario.Telefone2 = leitor.GetString("telefone2");
                        usuario.Cpf = leitor.GetString("cpf");
                        usuario.Rg = leitor.GetString("rg");
                        usuario.Senha = leitor.GetString("senha");
                        usuario.DataNascimento = Convert.ToDateTime(leitor["dataNascimento"]);
                        usuario.SexoUsuario = leitor.GetInt32("idSexo");
                        
                        usuarios.Add(usuario);
                    }
                    con.Close();
                    return usuarios;
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }

        public static Usuario FindById(int Id)
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    Usuario usuario = new Usuario();
                    string sql = "SELECT * FROM `db_infocourse`.`usua` WHERE idUsua = @Id;";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);
                    
                    con.Open();

                    cmd.Parameters.AddWithValue("@Id", Id);
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    if(leitor.Read())
                    {
                        usuario.Id = Convert.ToInt32(leitor["idUsua"]);
                        usuario.NomeCompleto = leitor.GetString("nome");
                        usuario.Email = leitor.GetString("email");
                        usuario.Telefone1 = leitor.GetString("telefone1");
                        if (!leitor["telefone2"].ToString().Equals(""))
                            usuario.Telefone2 = leitor.GetString("telefone2");
                        usuario.Cpf = leitor.GetString("cpf");
                        usuario.Rg = leitor.GetString("rg");
                        usuario.Senha = leitor.GetString("senha");
                        usuario.DataNascimento = Convert.ToDateTime(leitor["dataNascimento"]);
                        usuario.SexoUsuario = leitor.GetInt32("idSexo");
                    }
                    con.Close();
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return null;
            }
        }

        public static List<Usuario> FindByNameHaving(string nome)
        {
            try
            {
                using (MySqlConnection con = Conn.db)
                {
                    List<Usuario> usuarios = new List<Usuario>();
                    string sql = "SELECT * FROM `db_infocourse`.`usua` WHERE `nome` LIKE @nome;";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.db);

                    con.Open();

                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(leitor["idUsua"]);
                        usuario.NomeCompleto = leitor.GetString("nome");
                        usuario.Email = leitor.GetString("email");
                        usuario.Telefone1 = leitor.GetString("telefone1");
                        if (!leitor["telefone2"].ToString().Equals(""))
                            usuario.Telefone2 = leitor.GetString("telefone2");
                        usuario.Cpf = leitor.GetString("cpf");
                        usuario.Rg = leitor.GetString("rg");
                        usuario.Senha = leitor.GetString("senha");
                        usuario.DataNascimento = Convert.ToDateTime(leitor["dataNascimento"]);
                        usuario.SexoUsuario = leitor.GetInt32("idSexo");
                        usuarios.Add(usuario);
                    }
                    con.Close();
                    return usuarios;
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
