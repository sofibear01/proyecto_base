using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_base.AccesoADatos
{
    public class AD_Usuarios
    {
        public static bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuarios WHERE NombreDeUsuario like @nombreUsu AND Password like @pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreusu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static DataTable ObtenerListadoUsuarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuarios";

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

            public static bool InsertarUsuario(string nombreDeUsuario, string password)
            {
                bool resultado = false;
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "InsertarNuevoUsuario";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.CommandType = CommandType.StoredProcedure;
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

