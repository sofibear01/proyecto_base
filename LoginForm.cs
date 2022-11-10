using proyecto_base.AccesoADatos;
using proyecto_base.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_base
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("ingrese nombre de usuario y contraseña");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;

                try
                {
                    resultado = AD_Usuarios.ValidarUsuario(nombreDeUsuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreDeUsuario, password);
                        PrincipalForm ventana = new PrincipalForm(usu);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente...");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al consultar usuario");
                } 
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
