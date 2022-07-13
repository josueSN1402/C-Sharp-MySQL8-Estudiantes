using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaColegio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            visualizar(null);
        }

        private void visualizar(string filtro)
        {
            Control_Estudiante ctrl = new Control_Estudiante();
            dgvEstudiantes.DataSource = ctrl.consulta(filtro);
        }

    }
}
