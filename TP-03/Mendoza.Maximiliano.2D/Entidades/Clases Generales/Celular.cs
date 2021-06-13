using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Generales
{
  public class Celular
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int codigoDeBarras;
        private materiaPrima materiaPrima;
        private EModelo modelo;
      



       /// <summary>
       /// Propiedades
       /// </summary>
       /// //DEvuelve el modelo
        public EModelo Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }

        /// <summary>
        /// Devuelve el codigo de barras
        /// </summary>
        public int CodigoDeBarras
        {
            get
            {
                return this.codigoDeBarras;
            }

        }


        public materiaPrima MateriaPrima
        {
            get
            {
                return this.materiaPrima;
            }
        }

        /// <summary>
        /// Enumerados
        /// </summary>
        public enum ETipoCelular
        {
            Alcatel, Huawei, Nokia, Motorola, Samsumg
        }

        public enum EModelo
        {
            s1, P9Lite, Plus, MotoE7, Galaxy
        }



        /// <summary>
        /// Constructores
        /// </summary>
        public Celular()
        {

        }


        public Celular(int codigoDeBarras, materiaPrima materiaPrima)
        : this()
        {
            this.codigoDeBarras = codigoDeBarras;
            this.materiaPrima = materiaPrima;

        }

        public Celular(int codigoDeBarras, materiaPrima.ECarcaza carcaza, materiaPrima.EBateria bateria, materiaPrima.ECamara camara, materiaPrima.EPlaquetaElectronica placa)
        : this(codigoDeBarras, new materiaPrima(carcaza, bateria, camara, placa))
        {

        }



       


      
        /// <summary>
        /// Sobrecarga del ToString para mostrar Codigo de barras y materia primas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de barras: {this.codigoDeBarras}");
            sb.AppendLine($"***Materia prima: ***");
            sb.AppendLine($"{materiaPrima.ToString()}");

            return sb.ToString();

        }


        /// <summary>
        /// Info se podra sobreescribir en las clases heredadas
        /// </summary>
        /// <returns></returns>
        public virtual string Info()
        {
            return ("");
        }

        /// <summary>
        /// Verifica si un celu es igual a otro por codigo de barras y materia prima
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Celular c1, Celular c2)
        {
            bool retorno = false;

            if ((c1.codigoDeBarras == c2.codigoDeBarras && /*c1.Modelo == c2.Modelo  &&*/ c1.materiaPrima == c2.materiaPrima))
            {
                retorno = true;
            }

            return retorno;

        }

        public static bool operator !=(Celular c1, Celular c2)
        {
            return !(c1 == c2);
        }


        /// <summary>
        /// determina si dos celulares son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj is Celular && (Celular)obj == this);
        }




    }
}

