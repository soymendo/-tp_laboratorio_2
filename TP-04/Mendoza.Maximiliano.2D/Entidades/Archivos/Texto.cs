using Entidades.Interfaces;
using System.IO;
using Entidades.Exepciones;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda un archivo de texto en el escritorio
        /// </summary>
        /// <param name="archivo">path recibido</param>
        /// <param name="datos">datos recibido</param>
        /// <returns>Retorna true si logro guardar los datos, lanza una exception si no.</returns>

        public bool Guardar(string archivo, string datos)
        {
            StreamWriter writer = null;

            bool retorno = false;
            try
            {
                using (writer = new StreamWriter(archivo, false))
                {
                    writer.Write(datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException(e);
            }
            return retorno;
        }


        //try
        //    {
        //        string text = rtbListaEnsamblados.Text;
        //Texto texto = new Texto();


        //texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.txt", text);//guarda en escritorio
        //        MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



        //    }
        //    catch (ArchivoException ex)
        //    {

        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }



/// <summary>
/// Lee un archivo de texto
/// </summary>
/// <param name="archivo">path del archivo a leer.</param>
/// <param name="datos">datos a leer</param>
/// <returns></returns>
public bool Leer(string archivo, out string datos)
        {

            bool retorno = false;
            try
            {
                using (StreamReader read = new StreamReader(archivo, File.Exists(archivo)))
                {
                    datos = read.ReadToEnd();
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException(e);
            }
            return retorno;

        }
    }
}
