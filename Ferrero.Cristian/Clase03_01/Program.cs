using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS = System.Console;

namespace Clase03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CS.Title = "Programación II - Clase 2 21-03-2017";

            string num1_S, num2_S, num3_S;
            int num1_I, num2_I, num3_I;

            num1_S = CS.ReadLine();
            num2_S = CS.ReadLine();
            num3_S = CS.ReadLine();

            if( int.TryParse(num1_S, out num1_I) && int.TryParse(num2_S, out num2_I) && int.TryParse(num3_S, out num3_I) )
            {
                
            }
        }
    }
}
