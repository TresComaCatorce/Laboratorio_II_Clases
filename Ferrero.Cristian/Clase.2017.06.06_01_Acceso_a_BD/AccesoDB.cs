using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Clase._2017._06._06_01_Acceso_a_BD
{
    public class AccesoBD
    {

        #region Atributos

        private SqlConnection _conexionBD;
        private SqlCommand _comandoSQL;

        #endregion


        #region Constructores

        public AccesoBD()
        {
            _conexionBD = new SqlConnection(Properties.Settings.Default.Setting);
            _comandoSQL = new SqlCommand();
        }

        #endregion


        #region Métodos

        //Abre la conexion a la base de datos.
        //Si se pudo conectar retorna un TRUE, caso contrario retorna FALSE.
        public bool TestConexion()
        {
            try
            {
                this._conexionBD.Open();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                this._conexionBD.Close();
            }
        }


        public string TraerInfo()
        {
            StringBuilder retorno = new StringBuilder();
            try
            {
                //Para ejecutar un comando, tengo que settearle una conexion
                //válida a nuestro objeto conexión:
                this._comandoSQL.Connection = this._conexionBD;

                //Es un enum, el cual le dice al comando lo que tiene que hacer:
                this._comandoSQL.CommandType = CommandType.Text;

                //Se settea la QUERY sql que se necesita correr sobre la base de datos:
                this._comandoSQL.CommandText = "SELECT * FROM Personas";

                //Se abre la conexion:
                this._conexionBD.Open();

                //Se obtiene el resultado de la query en un 'SqlDataReader':
                SqlDataReader sqlDR = this._comandoSQL.ExecuteReader();

                //Se leen los datos del resultado uno a uno:
                while(sqlDR.Read())
                {
                    retorno.Append( "|ID: " + sqlDR[0].ToString() );
                    retorno.Append( " |Apellido: " + sqlDR[2].ToString() );
                    retorno.Append( " |Nombre: " + sqlDR[1].ToString() );
                    retorno.Append( " |Edad: " + sqlDR[3].ToString() );
                    retorno.AppendLine("");

                }

                //Se cierra el DataReader:
                sqlDR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                //Se cierra la conexion:
                this._conexionBD.Close();
            }

            return retorno.ToString();
        }



        public List<Persona> TraerPersonas()
        {
            List<Persona> retorno = new List<Persona>();

            try
            {
                this._comandoSQL.Connection = this._conexionBD;
                this._comandoSQL.CommandType = CommandType.Text;
                this._comandoSQL.CommandText = "SELECT * FROM Personas";
                this._conexionBD.Open();
                SqlDataReader sqlDR = this._comandoSQL.ExecuteReader();
                
                while (sqlDR.Read())
                {
                    retorno.Add(new Persona(    /*ID*/int.Parse(sqlDR[0].ToString()),
                                                /*Nombre*/sqlDR[1].ToString(),
                                                /*Apellido*/sqlDR[2].ToString(),
                                                /*Edad*/int.Parse(sqlDR[3].ToString())
                                            ));
                }

                sqlDR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                this._conexionBD.Close();
            }

            return retorno;
        }



        public bool AgregarPersona(Persona persona)
        {
            try
            {
                this._comandoSQL.Connection = this._conexionBD;
                this._comandoSQL.CommandType = CommandType.Text;
                this._comandoSQL.CommandText = "INSERT INTO Personas(nombre, apellido, edad) VALUES ('" + persona.nombre + "', '" + persona.apellido+"', '" + persona.edad.ToString() + "') ";
                this._conexionBD.Open();

                //Me fijo la cantidad de filas afectadas con la query anterior
                int filasAfectadas = this._comandoSQL.ExecuteNonQuery();
                Console.WriteLine("Se agrego correctamente la persona - " + filasAfectadas.ToString() );

            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                this._conexionBD.Close();
            }

            return true;
        }



        public bool ModificarPersona(Persona persona)
        {
            try
            {
                this._comandoSQL.Connection = this._conexionBD;
                this._comandoSQL.CommandType = CommandType.Text;
                this._comandoSQL.CommandText = "UPDATE Personas SET nombre='" + persona.nombre + "', apellido='" + persona.apellido + "', edad='" + persona.edad.ToString() + "' WHERE id='" + persona.id.ToString() +"'" ;
                this._conexionBD.Open();

                //Me fijo la cantidad de filas afectadas con la query anterior
                int filasAfectadas = this._comandoSQL.ExecuteNonQuery();
                Console.WriteLine("Se modificó correctamente la persona de ID: " + persona.id.ToString() + " - " + filasAfectadas.ToString());
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                this._conexionBD.Close();
            }
            return true;
        }



        public bool EliminarPersona(Persona persona)
        {
            try
            {
                this._comandoSQL.Connection = this._conexionBD;
                this._comandoSQL.CommandType = CommandType.Text;
                this._comandoSQL.CommandText = "DELETE FROM Personas WHERE id='" + persona.id.ToString() + "'";
                this._conexionBD.Open();

                //Me fijo la cantidad de filas afectadas con la query anterior
                int filasAfectadas = this._comandoSQL.ExecuteNonQuery();
                Console.WriteLine("Se eliminó correctamente la persona de ID: " + persona.id.ToString() + " - " + filasAfectadas.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                this._conexionBD.Close();
            }

            return true;
        }

        #endregion

    }
}
