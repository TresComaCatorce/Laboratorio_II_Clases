using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._09._05._2017_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno c1 = new ClaseUno("Clase uno");
            ClaseDos c2 = new ClaseDos("Clase uno", "Clase dos");
            ClaseTres c3 = new ClaseTres("Clase uno", "Clase dos", "Clase tres");
            ClaseCuatro c4 = new ClaseCuatro("Clase uno", "Clase dos", "Clase tres", "Clase cuatro");

            List<ClaseUno> lst = new List<ClaseUno>();

            lst.Add(c1);
            lst.Add(c2);
            lst.Add(c3);
            lst.Add(c4);

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (ClaseUno i in lst)
            {
                Console.WriteLine( i.ToString() + " - " + i.Propiedad );
            }

            c4.MetodoUno();

            Console.ReadLine();
        }
    }
}
