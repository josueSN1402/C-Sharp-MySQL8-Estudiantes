using ClassColegio;
using System;
using System.Windows.Forms;

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
            Limpiar();
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
                Limpiar();
                ctrl.Visualizar(null, dgvEstudiantes);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de salir del programa?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { Application.Exit(); }
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
                        double nota1 = double.Parse(txtNota1.Text);
                        double nota2 = double.Parse(txtNota2.Text);
                        double nota3 = double.Parse(txtNota3.Text);
                        double prom = eva.CalcPromedio(nota1, nota2, nota3);
                        txtProm.Text = Convert.ToString(prom);
                        txtSitu.Text = eva.EvaSituacion(prom);
                    }
                    else { MessageBox.Show("Notas fuera de rango"); }
                }
                else { MessageBox.Show("Ingrese correctamente las notas"); }
            }
        }

        private void Guardar()
        {
            bool sentinela;

            string dni = txtDNI.Text;
            string apa = txtApa.Text;
            string ama = txtAma.Text;
            string nom = txtNom.Text;
            string curso = txtCurso.Text;

            ValidacionNota vv = new ValidacionNota();

            if (!string.IsNullOrEmpty(dni) && !string.IsNullOrEmpty(apa) && !string.IsNullOrEmpty(ama) && !string.IsNullOrEmpty(nom)
                && !string.IsNullOrEmpty(curso) && vv.EsEntero(txtEdad.Text) && vv.EsEntero(txtNota1.Text) 
                && vv.EsEntero(txtNota2.Text) && vv.EsEntero(txtNota3.Text))
            {
                if (vv.ValidarRango(int.Parse(txtNota1.Text)) && vv.ValidarRango(int.Parse(txtNota2.Text)) && vv.ValidarRango(int.Parse(txtNota3.Text)))
                {
                    Estudiante est = new Estudiante
                    {
                        Dni = dni,
                        Apaterno = apa,
                        Amaterno = ama,
                        Nombres = nom,
                        Cursos = curso,
                        Edad = int.Parse(txtEdad.Text),
                        Nota1 = int.Parse(txtNota1.Text),
                        Nota2 = int.Parse(txtNota2.Text),
                        Nota3 = int.Parse(txtNota3.Text)
                    };

                   DialogResult result = MessageBox.Show("¿Desa guardar un nuevo registro? \n(Si pulsa NO se actualizara un registro existente según el DNI ingresado)", "Guardar o actualizar", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        sentinela = ctrl.Insertar(est);
                    }
                    else if (result == DialogResult.No)
                    {
                        sentinela = ctrl.Actualizar(est);
                    }
                    else { sentinela = false; }

                    if (sentinela)
                    {
                        MessageBox.Show("Registro guardado");
                        Limpiar();
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

        private void Limpiar()
        {
            txtDNI.Text = string.Empty;
            txtApa.Text = string.Empty;
            txtAma.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtCurso.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtDNI.Focus();
        }
    }
}
