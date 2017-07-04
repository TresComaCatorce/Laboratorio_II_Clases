using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout
{
    public partial class Form1 : Form
    {
        public delegate void delegadoMensaje(string mensaje);
        public delegadoMensaje miDelegado;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmAlta = new frmDatos();

            frmAlta.Show(this);
        }

        private void mostrarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrar = new frmMostrar();

            miDelegado += frmMostrar.MostrarMensaje;

            frmMostrar.Show(this);
        }
    }
}
