using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    class Deportivo : Auto, IAFIP, IARBA
    {

        #region Atributos

        protected int _caballosFuerza;

        #endregion


        #region Propiedades

        public override string Patente
        {
            get { return base._patente; }
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

        public Deportivo(double Precio, string Patente, int CaballosFuerza) : base (Precio, Patente)
        {
            this._caballosFuerza = CaballosFuerza;
        }

        #endregion


        #region Metodos

        public override void mostrarPrecio()
        {
            Console.Write(this._precio);
        }


        double IAFIP.CalcularImpuesto()
        {
            return base._precio * 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return base._precio * 0.23;
        }

        #endregion

    }
}
