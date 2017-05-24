using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    abstract class Vehiculo
    {

        #region Atributos

        protected double _precio;

        #endregion


        #region Propiedades

        public abstract double Precio
        {
            get;
        }

        #endregion


        #region Constructores

        public Vehiculo(double Precio)
        {
            this._precio = Precio;
        }

        #endregion


        #region Metodos

        public abstract void mostrarPrecio();

        #endregion

    }
}
