using MySql.Data.MySqlClient;

namespace Infocurso
{
    public static class Conn
    {
        public static bool estadoConexao = false;
        private static string strConnection = "Server=localhost;Database=db_infocourse;Uid=root;Pwd=123456";
        public static readonly MySqlConnection db = new MySqlConnection(strConnection);
        public static void Open()
        {
            db.Open();
            estadoConexao = true;
        }

        public static void Close()
        {
            db.Close();
            estadoConexao = false;
        }
    }
}
