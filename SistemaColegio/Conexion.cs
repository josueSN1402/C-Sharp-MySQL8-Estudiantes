using MySql.Data.MySqlClient;
using System;

namespace SistemaColegio
{
    public class Conexion
    {
        public MySqlConnection Connexion()
        {
            string ip = "localhost";
            string bd = "bbcolegio";
            string user = "root";
            string pass = "mysql2022";
            string sql = "Database=" + bd + "; Data Source=" + ip + "; User Id= " + user + "; Password=" + pass + "";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(sql);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
