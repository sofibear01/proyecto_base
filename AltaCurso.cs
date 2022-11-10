using proyecto_base.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_base
{
    public partial class AltaCurso : Form
    {
        public AltaCurso()
        {
            InitializeComponent();
        }

        private void AltaCurso_Load(object sender, EventArgs e)
        {
            CargarFecha();
        }

        private void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            ObtenerUltimoIdCurso();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ObtenerUltimoIdCurso()
        {
            int id = AD_Cursos.ObtenerUltimoIdCurso();
            txtNumeroCurso.Text = (id + 1).ToString();
        }

        private void btnBuscarCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Carreras.ObtenerCarrerasPorId(int.Parse(txtNumeroCarrera.Text));
                if(tablaResultado.Rows.Count > 0)
                {
                    txtCarrera.Text = tablaResultado.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Carerra inexistente");
                    txtNumeroCarrera.Focus();
                    txtCarrera.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener carrera...");
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Personas.ObtenerPersonaPorDocumento(txtDni.Text.Trim());
                if(tablaResultado.Rows.Count > 0)
                {
                    txtNombreAlumno.Text = tablaResultado.Rows[0][1].ToString();
                    txtApellidoAlumno.Text = tablaResultado.Rows[0][2].ToString();
                    txtIdPersona.Text = tablaResultado.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Alumno no encontrado");
                    txtDni.Text = "";
                    txtDni.Focus();
                    txtNombreAlumno.Text = "";
                    txtApellidoAlumno.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener alumno...");

            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            grillaAlumnos.Rows.Add(txtIdPersona.Text, txtDni.Text, txtNombreAlumno.Text, txtApellidoAlumno.Text);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<int> listaAlumnos = new List<int>();
            for(int i = 0; i < grillaAlumnos.Rows.Count; i++)
            {
                listaAlumnos.Add(int.Parse(grillaAlumnos.Rows[i].Cells[0].Value.ToString()));
            }

            bool resultado = AD_Cursos.AltaNuevoCurso(int.Parse(txtNumeroCurso.Text),txtNombreCurso.Text.Trim(),txtDescripcionCurso.Text.Trim(),int.Parse(txtNumeroCarrera.Text),listaAlumnos);

            if (resultado)
            {
                MessageBox.Show("Curso dado de alta con exito");
            }
            else
            {
                MessageBox.Show("Error al agregar nuevo curso");
            }
        }
    }
}
