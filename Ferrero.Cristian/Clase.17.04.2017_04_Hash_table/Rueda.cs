using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._17._04._2017_04_Hash_table
{
    class Rueda
    {
        public string marca;
        public int tamanio;

        public string Mostrar()
        {
            string retorno;

            retorno = this.marca + ", " + this.tamanio;

            return retorno;
        }
    }
}
