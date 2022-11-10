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
    public class AD_Cursos
    {
        public static int ObtenerUltimoIdCurso()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                
                string consulta = "SELECT MAX(Id) FROM cursos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado; 
            }
            catch (Exception ex)
            {
                return 0;
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

        public static bool AltaNuevoCurso(int idCurso, string nombreCurso, string descripcionCurso, int idCarrera, List<int> listaIdsAlumnos)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null; 
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO cursos VALUES(@nombre,@descripcion,@idCarrera)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombreCurso);
                cmd.Parameters.AddWithValue("@descripcion", descripcionCurso);
                cmd.Parameters.AddWithValue("@idCarrera", idCarrera);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
               
                objTransaccion = cn.BeginTransaction("AltaDeCurso");
                
                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                foreach(var idAlumno in listaIdsAlumnos)
                {
                    string consultaCursoxAlumno = "INSERT INTO personas_por_cursos values(@idPersona,@idCurso,@fecha)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idPersona", idAlumno);
                    cmd.Parameters.AddWithValue("@idCurso", idCurso);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                    cmd.CommandText = consultaCursoxAlumno;
                    cmd.ExecuteNonQuery();

                }
                objTransaccion.Commit();
                return true; 
            }
            catch (Exception ex)
            {
                objTransaccion.Rollback();
                return false; 
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerListadoDeCursos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM cursos";

                cmd.Parameters.Clear();
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

        public static DataTable ObtenerEstadisticaCursos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select c.nombre, count(pc.IdPersona) as Cantidad\r\nfrom personas_por_cursos pc Inner join cursos c on pc.IdCurso = c.Id Group by c.Nombre;";
                cmd.Parameters.Clear();
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
    }
}
