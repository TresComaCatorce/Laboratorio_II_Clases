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
            Console.WriteLine( Sello.Imprimir() );
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }


        //Borra el contenido de la variable 'mensaje'
        public static void Borrar()
        {
            Sello.mensaje = null;
        }

        private static string ArmarMensaje()
        {
            string retorno = "";
            
            if( Sello.mensaje.Length >= 0 && Sello.mensaje != null )
            {
                string linea = "";
                int i;

                for ( i = 0 ; i < (Sello.mensaje.Length+2) ; i++ )
                {
                    linea = linea + "*";
                }

                retorno = "\n" + linea +"\n*" + Sello.mensaje + "*\n" + linea + "\n";
            }   
            return retorno;
        }
    }
}
