using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exepciones
{
    public class ArchivoException : Exception
    {
        public ArchivoException()
        {
        }

        /// <summary>
        /// Usa al constructor de la clase base que resibe una excepcion y un mensaje.
        /// </summary>
        /// <param name="innerException">Exception recibida.</param>
        /// 

        public ArchivoException(Exception InnerException) : base("Error en el archivo.", InnerException)
        {

        }

        public ArchivoException(string message) : base(message)
        {
        }

        public ArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        
    }
}
