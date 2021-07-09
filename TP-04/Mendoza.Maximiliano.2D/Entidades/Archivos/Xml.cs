using Entidades.Interfaces;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Exepciones;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region Metodos

        /// <summary>
        /// Genera, guarda un archivo del tipo XML. Serealizando el objeto recibido 
        /// </summary>
        /// <param name="archivo">Archivo donde guarda</param>
        /// <param name="datos">Que guarda.</param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            try
            {
                XmlTextWriter writer;
                XmlSerializer ser;

                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
                writer.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivoException(e);
            }
            return retorno;
        }



        //  try
        //    {
        //        string text = rtbListaEnsamblados.Text;
        //Xml<string> texto = new Xml<string>();
        //texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.xml", text);//guarda en escritorio
        //        MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



        //    }
        //    catch (ArchivoException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }








/// <summary>
/// Leer archivos con contenido de datos XML.
/// </summary>
/// <param name="archivo">De donde lee.</param>
/// <param name="datos">Datos que lee.</param>
/// <returns></returns>
public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;

            try
            {
                XmlTextReader reader;
                XmlSerializer ser;

                reader = new XmlTextReader(archivo);
                ser = new XmlSerializer(typeof(T));
                datos = (T)ser.Deserialize(reader);
                reader.Close();

                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivoException(e);
            }
            return retorno;

        }


//         try
//            {
//               
//    //Binario<string> binary = new Binario<string>();
//    ////string nombres = "";
//    //if (binary.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.bin", out string nombres))
//    //{
//    //    rtbArchivos.Text = nombres;
//    //}


//}

//            catch (ArchivoException ex)
//{

//    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}



//                }
    #endregion
}
}
