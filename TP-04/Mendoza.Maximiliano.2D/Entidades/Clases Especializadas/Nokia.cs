using Entidades.Clases_Generales;
using Entidades.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Especializadas
{
    public class Nokia : Celular, IIrrompible
    {

        /// <summary>
        /// Atributos
        /// </summary>


        private EAndroid android;
        private EProcesador procesador;






        /// <summary>
        /// Propiedaddes
        /// devuelve el android 
        /// </summary>
        public EAndroid Android
        {
            get
            {
                return EAndroid.Pro;
            }
        }
        /// <summary>
        /// devuelve el procesador
        /// </summary>
        public EProcesador Procesador
        {
            get
            {
                return EProcesador.Quad;
            }
        }


        /// <summary>
        /// Constructores
        /// </summary>
        public Nokia()
        {

        }

      

        public Nokia(int codigoDeBarras, materiaPrima.ECarcaza carcaza, materiaPrima.EBateria bateria, materiaPrima.ECamara camara, materiaPrima.EPlaquetaElectronica placa)
        : base(codigoDeBarras, new materiaPrima(carcaza, bateria, camara, placa))
        {
            this.android = Android;
            this.procesador = Procesador;
        }





        /// <summary>
        /// Metodo que devuelve la informacion del objeto Nokia
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {Celular.ETipoCelular.Nokia}");
            sb.AppendLine($"Modelo :{EModelo.Plus}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Android: {this.Android}");
            sb.AppendLine($"Procesador: {this.Procesador}");
            sb.AppendLine($"*********************");
            return sb.ToString();
        }


        /// <summary>
        /// Devuelve tipo y modelo , usado mas adelante en el list del form
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Celular.ETipoCelular.Nokia}");
            sb.AppendLine($" {EModelo.Plus}");
            sb.AppendLine($"  Codigo :{this.CodigoDeBarras}");
            return sb.ToString();
        }






        /// <summary>
        /// compara dos objetos usando el equas de Celular
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static bool operator ==(Nokia n1, Nokia n2)
        {
            return Celular.Equals(n1, n2);
        }

        public static bool operator !=(Nokia n1, Nokia n2)
        {
            return !(n1 == n2);
        }
       

        /// <summary>
        /// implementacion de interface IIrompibl ,devuelve un string
        /// </summary>
        /// <returns></returns>
        public string Descripcion()
        {
            return ("Irrompible!!");
        }
    }
}
