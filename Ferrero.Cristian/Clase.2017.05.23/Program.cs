using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- IMPLEMENTAR IAFIP.CALCULARIMPUESTO(AVION(33% PRECIO) - DEPORTIVO(28% PRECIO))
            //2- VERIFICAR SI LA IMPLEMENTACION SE HEREDA (ENTRE AVION <-- PRIVADO - COMERCIAL)
            //3- CREAR PROPIEDADES:
            // A)ABSTRACTAS - DONDE CORRESPONDA
            // B)VIRTUALES - DONDE CORRESPONDA
            // C)EN LA INTERFACE IAFIP
            //4- IMPLEMENTAR EL METODO GESTION.MOSTRARIMPUESTONACIONAL

            Comercial AC = new Comercial(10000000, 950, 250);
            Privado AP = new Privado(5000000, 650, 10);
            Deportivo DEP = new Deportivo(500000, "THC 704", 620);

            Console.WriteLine("Avion comercial");
            Console.WriteLine("Precio: "+ AC.Precio);
            Console.WriteLine("Velocidad: "+ AC.VelocidadMaxima);
            Console.WriteLine("Cant Pasajeros: " + AC.CantidadPasajeros);
            Console.WriteLine("Impuesto AFIP: "+ ((IAFIP)AC).CalcularImpuesto());
            Console.WriteLine("Impuesto ARBA: " + ((IARBA)AC).CalcularImpuesto());
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Avion privado");
            Console.WriteLine("Precio: " + AP.Precio);
            Console.WriteLine("Velocidad: " + AP.VelocidadMaxima);
            Console.WriteLine("Valoracion: " + AP.Valoracion);
            Console.WriteLine("Impuesto AFIP: " + ((IAFIP)AP).ImpuestoNacional);
            Console.WriteLine("Impuesto ARBA: " + ((IARBA)AP).ImpuestoProvincial);

            Console.ReadLine();
        }
    }
}
