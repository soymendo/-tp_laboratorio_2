using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Generales
{
    /// <summary>
    /// Clase generica, la cual deriva de una clase Celular que tenga un constructor sin parametros
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deposito<T>
       where T : Celular, new()

    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int capacidad = 100;
        private List<T> celulares;


        /// <summary>
        /// Constructores
        /// </summary>

        /// <summary>
        /// inicializo la lista
        /// </summary>
        public Deposito()
        {
            celulares = new List<T>();
        }
        /// <summary>
        /// le doy una capacidad a la lista
        /// </summary>
        /// <param name="capacidad"></param>
        public Deposito(int capacidad)
        {
            this.capacidad = capacidad;
        }


        /// <summary>
        /// Verifico si un Celular esta en el deposito
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Deposito<T> f, Celular c)
        {
            bool retorno = false;


            if (f.celulares != null)
            {
                foreach (T item in f.celulares)
                {
                    if (item == c)
                    {
                        retorno = true;
                      
                    }

                }
            }

            return retorno;
        }



        public static bool operator !=(Deposito<T> f, Celular c)
        {
            return !(f == c);
        }




        /// <summary>
        /// Agrego un Celular al deposito 
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Deposito<T> f, Celular c)
        {
            bool retorno = false;
            if (f != c && f.capacidad > f.celulares.Count)
            {
                f.celulares.Add((T)c);
                retorno = true;
            }

            return retorno;
        }




        /// <summary>
        /// Elimino un celular del deposito
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator -(Deposito<T> f, Celular c)
        {
            bool retorno = false;
            if (f == c && f.capacidad > f.celulares.Count)
            {
                f.celulares.Remove((T)c);
                retorno = true;
            }
            else
            {
                Console.WriteLine("No esta agregado");
            }
            return retorno;
        }


        /// <summary>
        /// Muestro la lista de celulares en el deposito
        /// </summary>
        /// <returns></returns>
        public string mostrarDeposito()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine();

            foreach (Celular item in this.celulares)
            {
              
                sb.AppendLine(item.Info());

            }
            return sb.ToString();
        }



/// <summary>
/// Notifico el tamaño del deposito
/// </summary>
/// <returns></returns>
        public int tamanioDeposito()
        {
            return this.celulares.Count;
        }


        public List<T> ListaCelulares()
        {
            return this.celulares;
        }

    }
}
