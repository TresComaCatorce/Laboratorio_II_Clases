using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2._01
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static ConsoleColor colorFondo;

        public static string Imprimir()
        {
            return Sello.ArmarMensaje();
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.BackgroundColor = Sello.colorFondo;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }


        //Borra el contenido de la variable 'mensaje'
        public static void Borrar()
        {
            Sello.mensaje = null;
        }

        //Retorna true si el mensaje no esta vacio y asigna el mensaje al parámetro de salida.
        //Retorna false si el mensaje está vacio y asigna un string vacio al parámetro de salida.
        public static bool TryParse(String mensaje, out string salida)
        {
            bool retorno;

            if (mensaje != null)
            {
                retorno = true;
                salida = mensaje;
            }
            else
            {
                salida = "";
                retorno = false;
            }

            return retorno;
        }

        //Arma el mensaje con un recuadro de asteriscos ('*').
        private static string ArmarMensaje()
        {
            string retorno = "";

            if (TryParse(Sello.mensaje, out retorno))
            {
                string linea = "";
                int i;

                Sello.mensaje = retorno;

                for (i = 0; i < (Sello.mensaje.Length + 2); i++)
                {
                    linea = linea + "*";
                }

                retorno = "\n" + linea + "\n*" + Sello.mensaje + "*\n" + linea + "\n";
            }
            return retorno;
        }
    }
}
