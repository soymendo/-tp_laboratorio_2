using Entidades.Clases_Generales;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Especializadas
{
    public class Huawei : Celular
    {
       

        /// <summary>
        /// Atributos
        /// </summary>
        private EAndroid android;
        private EProcesador procesador;


       


        /// <summary>
        /// Propiedades usando los enum EAndroid y Eprocesador
        /// </summary>
      
        public EAndroid Android
        {
            get
            {
                return EAndroid.Pro;
            }
        }
        public EProcesador Procesador
        {
            get
            {
                return EProcesador.Dual;
            }
        }
      

        /// <summary>
        /// Constructores
        /// </summary>
        public Huawei()
        {

        }

       

        public Huawei(int codigoDeBarras, materiaPrima.ECarcaza carcaza, materiaPrima.EBateria bateria, materiaPrima.ECamara camara, materiaPrima.EPlaquetaElectronica placa)
        : base(codigoDeBarras, new materiaPrima(carcaza, bateria, camara, placa))
        {
            this.android = Android;
            this.procesador = Procesador;
        }



        #region "Metodos"


        /// <summary>
        /// Metodo que devuelve la informacion del objeto Huawei
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {Celular.ETipoCelular.Huawei}");
            sb.AppendLine($"Modelo :{EModelo.P9Lite}");
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
            sb.AppendLine($"{Celular.ETipoCelular.Huawei}");
            sb.AppendLine($" {EModelo.P9Lite}");
            sb.AppendLine($"  Codigo :{this.CodigoDeBarras}");

            return sb.ToString();

        }



        #endregion


        /// <summary>
        /// compara dos objetos usando el equas de Celular
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <returns></returns>
        #region Sobrecargas
        public static bool operator ==(Huawei h1, Huawei h2)
        {
            return Celular.Equals(h1, h2);
        }

        public static bool operator !=(Huawei h1, Huawei h2)
        {
            return !(h1 == h2);
        }
        #endregion

    }
}
