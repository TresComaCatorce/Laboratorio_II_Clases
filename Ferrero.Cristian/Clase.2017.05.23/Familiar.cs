using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    class Familiar : Auto
    {
        protected int _cantAsientos;


        public override string Patente
        {
            get { return base._patente; }
        }


        public Familiar(double Precio, string Patente, int CantAsientos) : base (Precio, Patente)
        {
            this._cantAsientos = CantAsientos;
        }

        public override void mostrarPrecio()
        {
            Console.Write(this._precio);
        }
    }
}
