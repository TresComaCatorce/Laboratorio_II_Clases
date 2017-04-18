using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._17._04._2017_03_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            ArrayList lista = new ArrayList();

            lista.Add(5);
            lista.Add(3);
            lista.Add(7);
            lista.Add(1);
            lista.Add(2);
            lista.Add(9);
            lista.Add(4);
            lista.Add(6);
            lista.Add(8);

            //lista.Sort();
            lista.Reverse();

            counter = 1;
            foreach (int entero in lista)
            {
                Console.WriteLine( "[" + counter + "] " + entero );
                counter++;
            }

            Console.ReadLine();
        }
    }
}
