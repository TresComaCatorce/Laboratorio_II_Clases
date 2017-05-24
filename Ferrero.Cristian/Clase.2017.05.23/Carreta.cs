using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    class Carreta : Vehiculo, IARBA
    {

        #region Propiedades

        public override double Precio
        {
            get { return base._precio; }
        }

        double IARBA.ImpuestoProvincial
        {
            get { return Gestion.MostrarImpuestoProvincial(this); }
        }

        #endregion


        #region Constructores

        public Carreta(double Precio) : base(Precio)
        {
            
        }

        #endregion


        #region Metodos

        public override void mostrarPrecio()
        {
            Console.Write(this._precio);
        }

        double IARBA.CalcularImpuesto()
        {
            return base._precio * 0.18;
        }

        #endregion

    }
}
