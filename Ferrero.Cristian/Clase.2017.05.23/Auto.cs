using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    abstract class Auto : Vehiculo
    {
        protected string _patente;

        public Auto(double Precio, string Patente) : base(Precio)
        {
            this._patente = Patente;
        }


        public override double Precio
        {
            get { return base._precio; }
        }


        public abstract string Patente
        {
            get;
        }


        public void MostrarPatente()
        {
            Console.Write(this._patente);
        }
    }
}
