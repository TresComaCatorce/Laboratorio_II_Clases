using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase._2017._06._06_01_Acceso_a_BD;
using Clase._2017._06._06_01_Acceso_a_BD;

namespace Clase._2017._06._06_02_test_conexion_bd
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoBD abd = new AccesoBD();

            Console.WriteLine(abd.TestConexion().ToString());

            Console.WriteLine("");

            //Si se descomenta esta linea, se agrega la persona Edith Piaf de 35 años con ID 5.
            //abd.AgregarPersona(new Persona(5, "Edith", "Piaf", 35));

            //Si se descomenta esta linea, se modifica la persona Edith Piaf de 35 años por Nina Simone de 39 años de edad. Su ID es 5.
            //abd.ModificarPersona(new Persona(5, "Nina", "Simone", 39));

            //Si se descomenta esta linea, se elimina la persona agregada anteriormente de ID 5.
            //abd.EliminarPersona(new Persona(5, "", "", 1));

            Console.WriteLine("");

            Console.WriteLine(abd.TraerInfo());

            Console.ReadLine();
        }
    }
}
