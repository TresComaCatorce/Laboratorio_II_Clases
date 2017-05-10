using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._09._05._2017_Herencia
{
    public class ClaseCuatro : ClaseTres
    {
        private string _atributoClaseCuatro;

        public ClaseCuatro( string uno, string dos, string tres, string cuatro ) : base ( uno, dos, tres )
        {
            this._atributoClaseCuatro = cuatro;
        }

        public override string ToString()
        {
            return (base.ToString() + " - " + this._atributoClaseCuatro );
        }
    }
}
