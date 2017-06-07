using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._2017._06._06_01_Acceso_a_BD
{
    public class Persona
    {

        #region Atributos

        private int _id;
        private string _nombre;
        private string _apellido;
        private int _edad;

        #endregion


        #region Constructores

        public Persona( int id, string nombre, string apellido, int edad )
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
        }

        #endregion


        #region Propiedades

        public int id
        {
            get { return this._id; }
        }

        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        #endregion
    


    }
}
