using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase._2017._06._27;

namespace Clase._2017._06._27_WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado("asd", "asdasd");
            emp.legajo = 104;
            emp.sueldo = 30000;
        }

        public void empleado_sueldomejorado(object sender, EventArgs e)
        {
            MessageBox.Show("Se supero los 20000 en legajo: "+((Empleado)sender).legajo);
        }
    }
}
