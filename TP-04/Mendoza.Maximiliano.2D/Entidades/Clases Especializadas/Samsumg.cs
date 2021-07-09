using Entidades.Clases_Generales;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Especializadas
{
    public class Samsumg : Celular
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
                return EAndroid.Smart;
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
        public Samsumg()
        {

        }

       

        public Samsumg(int codigoDeBarras, materiaPrima.ECarcaza carcaza, materiaPrima.EBateria bateria, materiaPrima.ECamara camara, materiaPrima.EPlaquetaElectronica placa)
        : base(codigoDeBarras, new materiaPrima(carcaza, bateria, camara, placa))
        {
            this.android = Android;
            this.procesador = Procesador;
        }








        /// <summary>
        /// Metodo que devuelve la informacion del objeto Samsumg
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {Celular.ETipoCelular.Samsumg}");
            sb.AppendLine($"Modelo :{EModelo.Galaxy}");
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
            sb.AppendLine($"{Celular.ETipoCelular.Samsumg}");
            sb.AppendLine($" {EModelo.Galaxy}");
            sb.AppendLine($"  Codigo :{this.CodigoDeBarras}");

            return sb.ToString();
        }





        /// <summary>
        /// compara dos objetos usando el equas de Celular
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator ==(Samsumg s1, Samsumg s2)
        {
            return Celular.Equals(s1, s2);
        }

        public static bool operator !=(Samsumg s1, Samsumg s2)
        {
            return !(s1 == s2);
        }
     
    }
}
