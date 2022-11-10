using proyecto_base.AccesoADatos;
using proyecto_base.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_base
{
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtCantidadHijos.Enabled = false;
            btnActualizarPersona.Enabled = false;

            CargarComboTiposDocumentos();
            CargarComboCarreras();

            CargarGrilla();

        }

        private void CargarGrilla()
        {
            try
            {
                gdrPersonas.DataSource = AD_Personas.ObtenerListadoPersonasReducido();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener personas");
            }
        }

        private void CargarComboTiposDocumentos()
        {
            try
            {
                cmbTipoDocumento.DataSource = AD_Varios.ObtenerTiposDocumentos();
                cmbTipoDocumento.DisplayMember = "Nombre";
                cmbTipoDocumento.ValueMember = "Id";
                cmbTipoDocumento.SelectedIndex = -1; //es para que no haya ninguna opcion seleccionada la primera vez
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipo de documento");
            }
          
        }

        private void CargarComboCarreras()
        {
            try
            {
                cmbCarrera.DataSource = AD_Varios.ObtenerCarreras();
                cmbCarrera.DisplayMember = "Nombre";
                cmbCarrera.ValueMember = "Id";
                cmbCarrera.SelectedIndex = -1; 
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo carrera");
            }
        
        }

        private Persona ObtenerDatosPersona()
        {
            Persona p = new Persona();
            p.NombrePersona = txtNombre.Text.Trim(); //Trim elimina espacios
            p.ApellidoPersona = txtApellido.Text.Trim();
            p.FechaNacimientoPersona = DateTime.Parse(txtFechaNacimiento.Text);
            if (rdMasculino.Checked)
            {
                p.SexoPersona = 1;
            }
            else if (rdFemenino.Checked)
            {
                p.SexoPersona = 2;
            }
            else
            {
                p.SexoPersona = 3;
            }

            p.TipoDocumentoPersona = (int)cmbTipoDocumento.SelectedValue;
            p.DocumentoPersona = txtNumeroDocumento.Text.Trim();
            p.CallePersona = txtCalle.Text.Trim();
            p.NroCasaPersona = txtNumeroCasa.Text.Trim();
            if (chkSoltero.Checked)
            {
                p.SolteroPersona = true;
            }
            else
            {
                p.SolteroPersona = false;

            }
            if (chkCasado.Checked)
            {
                p.CasadoPersona = true;
            }
            else
            {
                p.CasadoPersona = false;

            }
            if (chkHijos.Checked)
            {
                p.HijosPersona = true;
            }
            else
            {
                p.HijosPersona = false;
            }

            if (txtCantidadHijos.Text.Equals(""))
            {
                p.CantidadHijosPersona = 0;
            }
            else
            {
                p.CantidadHijosPersona = int.Parse(txtCantidadHijos.Text);
            }

            p.CarreraPersona = (int)cmbCarrera.SelectedValue;

            return p;
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {

            Persona p = ObtenerDatosPersona();
            
            bool resultado = AD_Varios.AgregarPersonaBD(p);
            if(resultado == true)
            {
                MessageBox.Show("Persona agregada con exito");
                LimpiarCampos();
                CargarComboCarreras();
                CargarComboTiposDocumentos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar la persona");
            }
        }


        private void AgregarPersona(Persona per)
        {
            DataGridViewRow fila = new DataGridViewRow();  //creo objeto fila 

            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
            celdaDocumento.Value = per.DocumentoPersona;   //creo objeto fila 
            fila.Cells.Add(celdaDocumento);   //agrego al celda a la fila 


            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = per.NombrePersona;   
            fila.Cells.Add(celdaNombre);   

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = per.ApellidoPersona;  
            fila.Cells.Add(celdaApellido);

            gdrPersonas.Rows.Add(fila);
            MessageBox.Show("Persona agregada con exito");
            LimpiarCampos();
            txtNombre.Focus(); //deja el cursor listo para agregar una nueva persona 

        }

        private void chkHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHijos.Checked)
            {
                txtCantidadHijos.Enabled = true;
            }
            else
            {
                txtCantidadHijos.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtNumeroDocumento.Text = "";
            rdMasculino.Checked = true; //dejamos masculino por defecto
            txtNumeroCasa.Text = "";
            txtCalle.Text = "";
            chkSoltero.Checked = false;
            chkCasado.Checked = false;
            chkHijos.Checked = false;
        }

        private void gdrPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarPersona.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrPersonas.Rows[indice];
            string documento = filaSeleccionada.Cells["Documento"].Value.ToString();
            Persona p = ObtenerPersona(documento);
            LimpiarCampos();
            CargarCampos(p);
        }

        private void CargarCampos(Persona p)
        {
            txtNombre.Text = p.NombrePersona;
            txtApellido.Text = p.ApellidoPersona;
            DateTime fecha = p.FechaNacimientoPersona;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if(dia.Length == 1)
            {
                dia = "0" + dia;
            }

            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }

            año = fecha.Date.Year.ToString();

            txtFechaNacimiento.Text = dia + mes + año;
            if(p.SexoPersona == 1)
            {
                rdMasculino.Checked = true;
            }
            else if (p.SexoPersona == 2)
            {
                rdFemenino.Checked = true;
            }
            else
            {
                rdOtro.Checked = true;
            }

            cmbTipoDocumento.SelectedValue = p.TipoDocumentoPersona;
            txtNumeroDocumento.Text = p.DocumentoPersona;
            txtCalle.Text = p.CallePersona;
            txtNumeroCasa.Text = p.NroCasaPersona.ToString();
            if (p.CasadoPersona)
            {
                chkCasado.Checked = true;
            }
            else
            {
                chkCasado.Checked = false;
            }
            if (p.SolteroPersona)
            {
                chkSoltero.Checked = true;
            }
            else
            {
                chkSoltero.Checked = false;

            }
            if (p.HijosPersona)
            {
                chkHijos.Checked = true;
            }
            else
            {
                chkHijos.Checked = false;
            }
            if(p.CantidadHijosPersona > 0)
            {
                txtCantidadHijos.Text = p.CantidadHijosPersona.ToString();
            }
            else
            {
                txtCantidadHijos.Text = "";
            }
            cmbCarrera.SelectedValue = p.CarreraPersona;
        }

        private Persona ObtenerPersona(string documento)
        {
            //bool resultado = false; ??
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Persona p = new Persona();
           
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personas WHERE NroDocumento LIKE @documento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", documento);
           
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr != null && dr.Read())
                {
                    p.NombrePersona = dr["Nombre"].ToString();
                    p.ApellidoPersona = dr["Apellido"].ToString();
                    p.FechaNacimientoPersona = DateTime.Parse(dr["FechaNacimiento"].ToString());
                    p.SexoPersona = int.Parse(dr["IdSexo"].ToString());
                    p.TipoDocumentoPersona = int.Parse(dr["IdTipoDocumento"].ToString());
                    p.SexoPersona = int.Parse(dr["IdSexo"].ToString());
                    p.DocumentoPersona = dr["NroDocumento"].ToString();
                    p.CallePersona = dr["Calle"].ToString();
                    p.NroCasaPersona = dr["NroCasa"].ToString();
                    p.SolteroPersona = bool.Parse(dr["Soltero"].ToString());
                    p.CasadoPersona = bool.Parse(dr["Casado"].ToString());
                    p.HijosPersona = bool.Parse(dr["Hijos"].ToString());
                    p.CantidadHijosPersona = int.Parse(dr["CantidadHijos"].ToString());
                    p.CarreraPersona = int.Parse(dr["IdCarrera"].ToString());
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar usuario");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        private void btnActualizarPersona_Click(object sender, EventArgs e)
        {
            Persona p = ObtenerDatosPersona();
            bool resultado = ActualizarPersona(p);
            if(resultado == true)
            {
                MessageBox.Show("Persona actualizada con exito..");
                LimpiarCampos();
                CargarGrilla();
                CargarComboCarreras();
                CargarComboTiposDocumentos();
            }
            else
            {
                MessageBox.Show("Error, no se pudo actualizar");
            }
        }

        private bool ActualizarPersona(Persona per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE personas SET Nombre = @nombre, Apellido = @apellido, FechaNacimiento = @fechaNacimiento, IdSexo = @idSexo, IdTipoDocumento = @idTipoDocumento, NumeroDocumento = @nroDocumento, Calle = @calle, NumeroCasa = @nroCasa, Soltero = @soltero, Casado = @casado, Hijos = @hijos, CantidadHijos = @cantHijos, IdCarrera = @idCarrera WHERE NroDocumento LIKE @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", per.NombrePersona);
                cmd.Parameters.AddWithValue("@apellido", per.ApellidoPersona);
                cmd.Parameters.AddWithValue("@fechaNacimiento", per.FechaNacimientoPersona);
                cmd.Parameters.AddWithValue("@idSexo", per.SexoPersona);
                cmd.Parameters.AddWithValue("@idTipoDocumento", per.TipoDocumentoPersona);
                cmd.Parameters.AddWithValue("@nroDocumento", per.DocumentoPersona);
                cmd.Parameters.AddWithValue("@calle", per.CallePersona);
                cmd.Parameters.AddWithValue("@nroCasa", per.NroCasaPersona);
                cmd.Parameters.AddWithValue("@soltero", per.SolteroPersona);
                cmd.Parameters.AddWithValue("@casado", per.CasadoPersona);
                cmd.Parameters.AddWithValue("@hijos", per.HijosPersona);
                cmd.Parameters.AddWithValue("@cantHijos", per.CantidadHijosPersona);
                cmd.Parameters.AddWithValue("@idCarrera", per.CarreraPersona);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }
    }
}
