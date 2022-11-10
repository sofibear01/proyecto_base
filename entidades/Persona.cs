using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_base.entidades
{
    public class Persona
    {
        private string Documento;
        private string Apellido;
        private string Nombre;
        private DateTime fechaNacimiento;
        private int IdSexo;
        private int IdTipoDocumento;
        private string Calle;
        private string NroCasa;
        private bool Soltero;
        private bool Casado;
        private bool ConHijos;
        private int CantHijos;
        private int IdCarrera;


        public Persona(string documento, string apellido, string nombre)
        {
            Documento = documento;
            Apellido = apellido;
            Nombre = nombre;
        }
        public string DocumentoPersona
        {
            // devuelve el valor del documento o le setea un valor 
            get => Documento;
            set => Documento = value;
        }

        public DateTime FechaNacimientoPersona
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public Persona()
        {

        }

        public int SexoPersona 
        {
            get => IdSexo;
            set => IdSexo = value;
        }

        public int TipoDocumentoPersona
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }

        public string CallePersona
        {
            get => Calle;
            set => Calle = value;
        }

        public string NroCasaPersona
        {
            get => NroCasa;
            set => NroCasa = value;
        }
        public string ApellidoPersona
        {
            get => Apellido;
            set => Apellido = value;
        }
        public string NombrePersona
        {
            get => Nombre;
            set => Nombre = value;
        }

        public bool SolteroPersona
        {
            get => Soltero;
            set => Soltero = value;
        }

        public bool CasadoPersona
        {
            get => Casado;
            set => Casado = value;
        }

        public bool HijosPersona
        {
            get => ConHijos;
            set => ConHijos = value;
        }

        public int CantidadHijosPersona
        {
            get => CantHijos;
            set => CantHijos = value;
        }

        public int CarreraPersona
        {
            get => IdCarrera;
            set => IdCarrera = value;
        }
    }
}

