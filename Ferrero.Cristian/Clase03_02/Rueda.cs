﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03_02
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
