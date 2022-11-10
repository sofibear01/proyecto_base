using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_base.entidades
{
    public class Usuario
    {
        private string NombreUsu;
        private string Contra;

        public Usuario(string nombreUsuario, string contraseña)
        {
            NombreUsu = nombreUsuario;
            Contra = contraseña;
        }
        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Contraseña
        {
            get => Contra;
            set => Contra = value; 
        }
    }
}
