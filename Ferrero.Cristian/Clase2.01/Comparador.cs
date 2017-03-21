using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2._01
{
    class Comparador
    {
        public static int RetornarMayor( int num1, int num2 )
        {
            int retorno;
            if (num1 > num2)
            {
                retorno = num1;
            }
            else
            {
                retorno = num2;
            }
            return retorno;
        }

        public static void MostrarElDelMedio( int num1, int num2, int num3 )
        {
            String mensaje = "El del medio es ";
            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2 && num1 < num3 || num1 < num2 && num1 > num3)
                {
                    mensaje = mensaje + num1;
                }
                if (num2 > num1 && num2 < num3 || num2 < num1 && num2 > num3)
                {
                    mensaje = mensaje + num2;
                }
                if (num3 > num1 && num3 < num2 || num3 < num1 && num3 > num2)
                {
                    mensaje = mensaje + num3;
                }
            }
            else
                mensaje = "No hay numero en el medio";
            Console.WriteLine(mensaje);
        }
    }
}
