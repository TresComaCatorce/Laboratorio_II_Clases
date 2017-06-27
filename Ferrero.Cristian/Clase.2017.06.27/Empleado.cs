using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._06._27
{
    public class Empleado
    {
        public string nombre;
        public string apellido;
        public int legajo;
        private double _sueldo;

        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public double sueldo
        {
            get { return this._sueldo; }
            set
            {
                if (value >= 0 && value <= 9500)
                {
                    this._sueldo = value;
                }
                else if(value< 0)
                {
                    throw new Exception("El sueldo debe ser mayor a cero.");
                }
                else if (value > 9500)
                {
                    this.SueldoMejoradoEvent( this, new EventArgs() );
                }
            }
        }

        public delegate void DelegadoSueldoMejorado(Object o, EventArgs e);
        public event DelegadoSueldoMejorado SueldoMejoradoEvent;
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo.ToString() );
            sb.AppendLine("Sueldo: " + this._sueldo.ToString() );


            return sb.ToString();
        }
    }
}
