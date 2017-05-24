using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    class Comercial : Avion, IARBA
    {

        #region Atributos

        protected int _cantidadPasajeros;

        #endregion


        #region Propiedades

        public int CantidadPasajeros
        {
            get { return this._cantidadPasajeros; }
        }

        #endregion


        #region Constructores

        public Comercial(double Precio, double Velocidad, int CantidadPasajeros) : base (Precio, Velocidad)
        {
            this._cantidadPasajeros = CantidadPasajeros;
        }

        #endregion


        #region Metodos

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.25;
        }

        #endregion

    }
}
