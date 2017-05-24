using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    class Privado : Avion
    {

        #region Atributos

        protected int _valoracionServicioDeAbordo;

        #endregion


        #region Propiedades

        public int Valoracion
        {
            get { return this._valoracionServicioDeAbordo; }
        }

        #endregion


        #region Constructores

        public Privado(double Precio, double Velocidad, int Valoracion) : base (Precio, Velocidad)
        {
            this._valoracionServicioDeAbordo = Valoracion;
        }

        #endregion

    }
}
