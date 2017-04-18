using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._17._04._2017_04_Hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
            string msj = "you know what i'm saying?... YO";
            Hashtable tabla = new Hashtable();

            tabla.Add(4, "Ricky");
            tabla.Add(1, "Julian");
            tabla.Add(3, "Bubbles");
            tabla.Add(5, "Randy");
            tabla.Add(2, "Mr. Lahey");

            foreach( var i in tabla.Keys)
            {
                Console.WriteLine(tabla[i]);
            }

            Console.WriteLine(msj);

            Console.ReadLine();

        }
    }
}
