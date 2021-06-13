using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exepciones
{
    public class ArchivoException : Exception
    {
        /// <summary>
        /// Usa al constructor de la clase base que resibe una excepcion y un mensaje.
        /// </summary>
        /// <param name="innerException">Exception recibida.</param>
        /// 

        public ArchivoException(Exception InnerException) : base("Error en el archivo.", InnerException)
        {

        }
    }
}
