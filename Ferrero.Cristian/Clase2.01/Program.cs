using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programación II - Clase 2 21-03-2017";

            //Setteo el mensaje y el color
            Sello.mensaje = "mensaje_test";
            Sello.color = ConsoleColor.Magenta;
            Sello.colorFondo = ConsoleColor.DarkMagenta;

            //Imprimo el mensaje sin color
            Console.WriteLine(Sello.Imprimir());

            //Imprimo el mensaje con color
            Sello.ImprimirEnColor();

            //Imprimo el mensaje sin color
            Console.WriteLine(Sello.Imprimir());

            //Borro el mensaje
            Sello.Borrar();

            //Imprimo el mensaje
            //Console.WriteLine(Sello.Imprimir());

            Console.ReadKey();
        }
    }
}
