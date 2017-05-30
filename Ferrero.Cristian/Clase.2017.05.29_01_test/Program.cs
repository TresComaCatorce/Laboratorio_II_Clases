using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase._2017._05._29_01;

namespace Clase._2017._05._29_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Iggy Pop", 68, true);

            using (StreamWriter SW = new StreamWriter(@"D:\MiArchivo.txt"))
            {
                SW.WriteLine(p.ToString());
            }
            
        }
    }
}
