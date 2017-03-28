using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda rueda1 = new Rueda();
            Rueda rueda2 = new Rueda();

            rueda1.marca = "Firestone";
            rueda1.tamanio = 165;

            rueda2.marca = "Fate";
            rueda2.tamanio = 175;
        }
    }
}
