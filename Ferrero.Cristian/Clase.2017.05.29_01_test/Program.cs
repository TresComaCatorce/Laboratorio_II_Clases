using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Clase._2017._05._29_01;
using System.Runtime.Serialization.Formatters.Binary;

namespace Clase._2017._05._29_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Archivos de texto plano

            Persona p1 = new Persona("Iggy Pop", 68, true);
            Persona p2 = new Persona("Ian Curtis", 27, true);


            /*****************************************************************/
            /**************ESCRITURA DE UN ARCHIVO DE TEXTO PLANO*************/
            /*****************************************************************/
            try
            {
                //CREO EL ARCHIVO O SIGO ESCRIBIENDO AL FINAL SI EXISTE
                using (StreamWriter SW = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory+"MiArchivo.txt", true))
                {
                    SW.WriteLine(p1.ToString());
                    SW.WriteLine(p2.ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }



            /*****************************************************************/
            /**************LECTURA DE UN ARCHIVO DE TEXTO PLANO*************/
            /*****************************************************************/
            try
            {
                //LEO EL CONTENIDO DEL ARCHIVO
                using (StreamReader SR = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "MiArchivo.txt"))
                {
                    Console.WriteLine(SR.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            #endregion


            #region Archivos binarios

            /*****************************************************************/
            /****SERIALIZACION DE UN OBJETO Y ESCRITURA EN UN ARCHIVO .DAT****/
            /*****************************************************************/
            try
            {
                //CREO EL ARCHIVO BINARIO SOBRE EL QUE VOY A ESCRIBIR (FILESTREAM)
                using (FileStream FS = new FileStream(AppDomain.CurrentDomain.BaseDirectory+"MiArchivo.dat", FileMode.Create))
                {
                    //SERIALIZO MI OBJETO CON EL BINARY FORMATTER
                    //Y LO ESCRIBO EN EL ARCHIVO BINARIO A TRAVEZ DEL FILESTREAM
                    //(Si quisiera guardar varias 'Personas' debería guardar una coleccion o array)
                    BinaryFormatter BF = new BinaryFormatter();
                    BF.Serialize(FS, p1);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }



            /******************************************************************/
            /****LECTURA DE UN ARCHIVO .DAT Y DE-SERIALIZACION DE UN OBJETO****/
            /******************************************************************/
            try
            {
                //LEO EL ARCHIVO BINARIO QUE VOY A LEER
                using (FileStream FS = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "MiArchivo.dat", FileMode.Open))
                {
                    //DE-SERIALIZO EL ARCHIVO Y LEVANTO MI OBJETO
                    BinaryFormatter BF = new BinaryFormatter();
                    Persona pLeida = (Persona)BF.Deserialize(FS);

                    Console.WriteLine("Persona leida:\n"+pLeida.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            #endregion


            #region Archivos XML

            try
            {

                using( XmlTextWriter xmlTW = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory+"MiArchivo.xml", Encoding.UTF8) )
                {
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            #endregion

            Console.ReadLine();
        }
    }
}
