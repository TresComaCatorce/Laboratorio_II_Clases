using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase._2017._06._27;

namespace Clase._2017._06._27_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado miEmpleado = new Empleado("Another Brick", "In The Wall");

            try
            {
                miEmpleado.sueldo = -5;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
