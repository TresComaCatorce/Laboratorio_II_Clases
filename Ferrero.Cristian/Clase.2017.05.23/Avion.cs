using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    class Avion : Vehiculo, IAFIP, IARBA
    {

        #region Atributos

        protected double _velocidadMaxima;

        #endregion


        #region Propiedades

        public override double Precio
        {
            get { return base._precio; }
        }

        public double VelocidadMaxima
        {
            get { return this._velocidadMaxima; }
        }

        double IAFIP.ImpuestoNacional
        {
            get { return Gestion.MostrarImpuestoNacional(this); }
        }

        double IARBA.ImpuestoProvincial
        {
            get { return Gestion.MostrarImpuestoProvincial(this); }
        }

        #endregion


        #region Constructores

        public Avion(double Precio, double VelocidadMaxima) : base (Precio)
        {
            this._velocidadMaxima = VelocidadMaxima;
        }

        #endregion


        #region Metodos

        public override void mostrarPrecio()
        {
            Console.Write(base._precio);
        }

        
        double IAFIP.CalcularImpuesto()
        {
            double retorno = 0;

            retorno = base._precio * 0.33;

            return retorno;
        }

        double IARBA.CalcularImpuesto()
        {
            return base._precio * 0.27;
        }

        #endregion

    }
}
