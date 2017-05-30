using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._05._29_01
{
    public class Persona
    {

        #region Atributos

        private string _nombre;
        private int _edad;
        private bool _esMayor;

        #endregion


        #region Constructores

        public Persona( string nombre, int edad, bool esMayor )
        {
            this._nombre = nombre;
            this._edad = edad;
            this._esMayor = esMayor;
        }

        #endregion


        #region Sobrecargas

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("Nombre: "+this._nombre);
            sb.AppendLine("Edad: "+this._edad.ToString());
            sb.AppendLine("Es Mayor: "+this._esMayor.ToString());

            return sb.ToString();
        }

        #endregion


        #region Metodos



        #endregion
    }
}
