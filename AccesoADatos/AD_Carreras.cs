using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_base.entidades;

namespace proyecto_base.AccesoADatos
{
    public class AD_Carreras
    {
        public static DataTable ObtenerCarrerasPorId(int idCarrera)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                
                string consulta = "SELECT * FROM carreras WHERE Id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idCarrera);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);    
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool AgregarPersonaBD(Persona per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO personas (Nombre, Apellido, FechaNacimiento, IdSexo, IdTipoDocumento, NumeroDocumento, Calle, NumeroCasa, Soltero, Casado, Hijos, CantidadHijos, IdCarrera) VALUES(@nombre, @apellido, @fechaNacimiento, @idSexo, @idTipoDocumento, @nroDocumento, @calle, @nroCasa, @soltero, @casado, @hijos, @cantHijos, @idCarrera)";
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
