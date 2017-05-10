using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._09._05._2017_Herencia
{
    public class ClaseDos : ClaseUno
    {
        protected string _atributoClaseDos;

        public override string Propiedad
        {
            get { return "ClaseDos hereda de " + base.Propiedad; }
        }

        public ClaseDos( string atributoClaseUno, string atributoClaseDos ) : base(atributoClaseUno)
        {
            this._atributoClaseDos = atributoClaseDos;
        }

        public override string Mostrar()
        {
            return (base.Mostrar() + " // " + this._atributoClaseDos);
        }

        public override string ToString()
        {
            return ( base.ToString() + " - " + this._atributoClaseDos );
        }
    }
}
