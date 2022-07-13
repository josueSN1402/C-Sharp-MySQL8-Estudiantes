using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaColegio
{
    public class Ctrl_Conexion : Control_Estudiante
    {
        private bool ComprobarConexion(MySqlConnection cn)
        {
            if (cn == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void EstadoConexion(DataGridView dgv)
        {
            bool conec = ComprobarConexion(base.Connexion());

            if (!conec) { MessageBox.Show("No pudo conectarse a la base de datos"); }
            else { Visualizar("", dgv); }
        }

        private void Visualizar(string filtro, DataGridView dgv)
        {
            dgv.DataSource = base.Consulta(filtro);
        }
    }
}
