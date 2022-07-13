using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaColegio
{
    public class Control_Estudiante : Conexion
    {
        public List<Object> Consulta(string filtro)
        {
            MySqlDataReader reader;
            List<Object> listProduc = new List<object>();
            string sql;

            if (filtro == null)
            {
                sql = "SELECT DNI, Apaterno, Amaterno, Nombres, Cursos, Edad, Nota1, Nota2, Nota3 FROM estudiante";
            }
            else
            {
                sql = "SELECT DNI, Apaterno, Amaterno, Nombres, Cursos, Edad, Nota1, Nota2, Nota3 FROM estudiante WHERE DNI LIKE '%" + filtro + "%'";
            }

            try
            {
                MySqlConnection cnBD = base.Connexion();
                cnBD.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnBD);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Estudiante estu = new Estudiante
                    {
                        Dni = reader.GetString("DNI"),
                        Apaterno = reader.GetString("Apaterno"),
                        Amaterno = reader.GetString("Amaterno"),
                        Nombres = reader.GetString("Nombres"),
                        Cursos = reader.GetString("Cursos"),
                        Edad = int.Parse(reader.GetString("Edad")),
                        Nota1 = int.Parse(reader.GetString("Nota1")),
                        Nota2 = int.Parse(reader.GetString("Nota2")),
                        Nota3 = int.Parse(reader.GetString("Nota3"))
                    };
                    listProduc.Add(estu);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return listProduc;
        }

        public bool Insertar(Estudiante est)
        {
            bool sentinela;
            string sql = "INSERT INTO estudiante (DNI, Apaterno, Amaterno, Nombres, Cursos, Edad, Nota1, Nota2, Nota3) VALUES ('" + est.Dni + "', '" + est.Apaterno + "','" + est.Amaterno + "','" + est.Nombres + "', '" + est.Cursos + "', '" + est.Edad + "', '" + est.Nota1 + "', '" + est.Nota2 + "', '" + est.Nota3 + "')";

            try
            {
                MySqlConnection cnBD = base.Connexion();
                cnBD.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnBD);
                cmd.ExecuteNonQuery();
                sentinela = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                sentinela = false;
            }
            return sentinela;
        }

        public bool Actualizar(Estudiante est)
        {
            bool sentinela;
            string sql = "UPDATE estudiante SET Apaterno='" + est.Apaterno + "', Amaterno='" + est.Amaterno + "', Nombres='" + est.Nombres + "', Cursos='" + est.Cursos + "', Edad='" + est.Edad + "', Nota1='" + est.Nota1 + "', Nota2='" + est.Nota2 + "', Nota3='" + est.Nota3 + "' WHERE DNI='" + est.Dni + "'";

            try
            {
                MySqlConnection cnBD = base.Connexion();
                cnBD.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnBD);
                cmd.ExecuteNonQuery();
                sentinela = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                sentinela = false;
            }
            return sentinela;
        }

        public bool Eliminar(string dni)
        {
            bool sentinela;
            string sql = "DELETE FROM estudiante WHERE DNI='" + dni + "'";

            try
            {
                MySqlConnection cnBD = base.Connexion();
                cnBD.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnBD);
                cmd.ExecuteNonQuery();
                sentinela = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                sentinela = false;
            }
            return sentinela;
        }
    }
}
