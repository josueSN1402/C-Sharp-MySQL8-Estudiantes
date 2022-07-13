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

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de salir del programa?", "Salir", MessageBoxButtons.YesNo);
            if (result== DialogResult.Yes)  { Application.Exit(); }
        }

        private void Calcular()
        {
            throw new NotImplementedException();
        }

        private void Guardar()
        {
            bool sentinela;

            string apa = txtApa.Text;
            string ama = txtAma.Text;
            string nom = txtNom.Text;

            ValidacionNota vv = new ValidacionNota();

            if (!string.IsNullOrEmpty(apa) && !string.IsNullOrEmpty(ama) && !string.IsNullOrEmpty(nom) 
                && vv.EsEntero(txtEdad.Text) && vv.EsEntero(txtNota1.Text) && vv.EsEntero(txtNota2.Text) && vv.EsEntero(txtNota3.Text))
            {
                Estudiante est = new Estudiante();
                est.Apaterno = apa;
                est.Amaterno = ama;
                est.Nombres = nom;
                est.Edad = int.Parse(txtEdad.Text);
                est.Nota1 = int.Parse(txtNota1.Text);
                est.Nota2 = int.Parse(txtNota2.Text);
                est.Nota3 = int.Parse(txtNota3.Text);

                if (txtDNI.Text != "")
                {
                    est.Dni = txtDNI.Text;
                    sentinela = ctrl.Actualizar(est);
                }
                else {  sentinela = ctrl.Insertar(est); }

                if (sentinela)
                {
                    MessageBox.Show("Registro guardado");
                    btnNuevo.PerformClick();
                    ctrl.Visualizar(null, dgvEstudiantes);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }
    }
}
