using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._17._04._2017_02_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();

            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Enqueue(5);

            int cantidad = cola.Count;

            for (int i = 0; i < cantidad; i++)
            {
                int aux = (int)cola.Dequeue();
                if (aux == 4)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
