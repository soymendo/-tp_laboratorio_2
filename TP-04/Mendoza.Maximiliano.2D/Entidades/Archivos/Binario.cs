using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

using Entidades.Interfaces;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Exepciones;
using System.IO;

namespace Entidades.Archivos
{
    public class Binario<T> : IArchivo<T>
    {
      public  bool Guardar(string ruta, T objeto)
        {
            FileStream fileStream = null;
            bool retorno = false;
            try
            {
                fileStream = new FileStream(ruta, FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fileStream, objeto);
                retorno = true;
            }
            catch (Exception exe)
            {
                throw new Exception(exe.Message, exe);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return retorno;
        }



        //string text = rtbListaEnsamblados.Text;
        //Binario<string> binary = new Binario<string>();
        //binary.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.bin",text);//guarda en escritorio
        //MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public bool Leer(string ruta, out T datos)
        {
            FileStream fileStream = null;
          
            datos = default(T);
            bool retorno = false;

            try
            {
                BinaryFormatter reader = new BinaryFormatter();
                fileStream = new FileStream(ruta, FileMode.Open);
                datos = (T)reader.Deserialize(fileStream);
                
                retorno = true;
            }
            catch (Exception exe)
            {
                throw new Exception(exe.Message, exe);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

           
            return retorno;
        }



        //Binario<string> binary = new Binario<string>();
        ////string nombres = "";
        //if (binary.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.bin", out string nombres))
        //{
        //    rtbArchivos.Text = nombres;
        //}



    }
}
