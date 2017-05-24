using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._23
{
    static class Gestion
    {
        public static double MostrarImpuestoNacional(this IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

        public static double MostrarImpuestoProvincial(this IARBA bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
