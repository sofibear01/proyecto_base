﻿using proyecto_base.entidades;
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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario usu)
        {
            InitializeComponent();
            lblBienvenida.Text = "Hola " + usu.NombreDeUsuario + "!!";
            lblBienvenida.Visible = true;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void altaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPersona ventana = new AltaPersona();
            ventana.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios ventana = new Usuarios();
            ventana.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCurso ventana = new AltaCurso();
            ventana.ShowDialog();
        }

        private void listadoDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteListadoCursos ventana = new ReporteListadoCursos();
            ventana.ShowDialog();
        }

        private void estadisticaDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadistica ventana = new ReporteEstadistica();
            ventana.ShowDialog();
        }
    }
}
