using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._09._05._2017_Herencia
{
    public class ClaseUno
    {
        protected string _atributoClaseUno;

        public virtual string Propiedad
        {
            get { return "ClaseUno"; }
        }

        public ClaseUno(string atributo)
        {
            this._atributoClaseUno = atributo;
        }

        public virtual string Mostrar()
        {
            return this._atributoClaseUno;
        }

        public void MetodoUno()
        {
            Console.WriteLine("");
            Console.WriteLine("Soy metodo propio de la ClaseUno");
            Console.WriteLine("");
        }

        public override string ToString()
        {
            return this._atributoClaseUno;
        }
    }
}
