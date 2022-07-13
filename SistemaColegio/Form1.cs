using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassColegio;

namespace SistemaColegio
{
    public partial class FrmEstudiante : Form
    {
        readonly Ctrl_Conexion ctrl = new Ctrl_Conexion();

        public FrmEstudiante()
        {
            InitializeComponent();
            ctrl.EstadoConexion(dgvEstudiantes);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox) c.Text = string.Empty;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string cod = txtDNI.Text;
            ctrl.Visualizar(cod, dgvEstudiantes);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar(dgvEstudiantes);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                string dni = dgvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                ctrl.Eliminar(dni);
                btnNuevo.PerformClick();
                ctrl.Visualizar(null, dgvEstudiantes);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de salir del programa?", "Salir", MessageBoxButtons.YesNo);
            if (result== DialogResult.Yes)  { Application.Exit(); }
        }

        private void Calcular()
        {
            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtAma.Text) || string.IsNullOrEmpty(txtApa.Text)
                || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtCurso.Text) || string.IsNullOrEmpty(txtEdad.Text))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                ValidacionNota vv = new ValidacionNota();
                if (vv.EsEntero(txtEdad.Text) && vv.EsEntero(txtNota1.Text) && vv.EsEntero(txtNota2.Text) && vv.EsEntero(txtNota3.Text))
                {
                    if (vv.ValidarRango(int.Parse(txtNota1.Text)) && vv.ValidarRango(int.Parse(txtNota2.Text)) && vv.ValidarRango(int.Parse(txtNota3.Text)))
                    {
                        Evalucion eva = new Evalucion();

                    }
                    else
                    {
                        MessageBox.Show("Notas fuera de rango");
                    }
                }
                else
                {
                    MessageBox.Show("Notas fuera de rango");
                }
            }
        }

        private void Guardar()
        {
            bool sentinela;

            string apa = txtApa.Text;
            string ama = txtAma.Text;
            string nom = txtNom.Text;
            string curso = txtCurso.Text;

            ValidacionNota vv = new ValidacionNota();

            if (!string.IsNullOrEmpty(apa) && !string.IsNullOrEmpty(ama) && !string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(curso)
                && vv.EsEntero(txtEdad.Text) && vv.EsEntero(txtNota1.Text) && vv.EsEntero(txtNota2.Text) && vv.EsEntero(txtNota3.Text))
            {
                if (vv.ValidarRango(int.Parse(txtNota1.Text)) && vv.ValidarRango(int.Parse(txtNota2.Text)) && vv.ValidarRango(int.Parse(txtNota3.Text)))
                {
                    Estudiante est = new Estudiante
                    {
                        Apaterno = apa,
                        Amaterno = ama,
                        Nombres = nom,
                        Cursos = curso,
                        Edad = int.Parse(txtEdad.Text),
                        Nota1 = int.Parse(txtNota1.Text),
                        Nota2 = int.Parse(txtNota2.Text),
                        Nota3 = int.Parse(txtNota3.Text)
                    };

                    if (txtDNI.Text != "")
                    {
                        est.Dni = txtDNI.Text;
                        sentinela = ctrl.Actualizar(est);
                    }
                    else { sentinela = ctrl.Insertar(est); }

                    if (sentinela)
                    {
                        MessageBox.Show("Registro guardado");
                        btnNuevo.PerformClick();
                        ctrl.Visualizar(null, dgvEstudiantes);
                    }
                }
                else
                {
                    MessageBox.Show("Notas fuera de rango");
                }
            }
            else
            {
                MessageBox.Show("Ingresar datos correctamente");
            }
        }

        private void Modificar(DataGridView dgv)
        {
            txtDNI.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtApa.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtAma.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtNom.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtCurso.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            txtEdad.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            txtNota1.Text = dgv.CurrentRow.Cells[6].Value.ToString();
            txtNota2.Text = dgv.CurrentRow.Cells[7].Value.ToString();
            txtNota3.Text = dgv.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
