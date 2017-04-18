using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._17._04._2017_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);

            int cantidad = pila.Count;

            for ( int i = 0 ; i<cantidad ; i++ )
            {
                int aux = (int)pila.Pop();
                if (aux == 3)
                {
                    break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
