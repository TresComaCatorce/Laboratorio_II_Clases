using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._09._05._2017_Herencia
{
    public class ClaseTres : ClaseDos
    {
        protected string _atributoClaseTres;

        public override string Propiedad
        {
            get { return ("ClaseTres hereda de ") + base.Propiedad; }
        }

        public ClaseTres( string atributoClaseUno, string atributoClaseDos, string atributoClaseTres ) : base ( atributoClaseUno, atributoClaseDos )
        {
            this._atributoClaseTres = atributoClaseTres;
        }

        public override string Mostrar()
        {
            return (base.Mostrar() + " // " + this._atributoClaseTres);
        }

        public override string ToString()
        {
            return ( base.ToString() + " - " + this._atributoClaseTres );
        }
    }
}
