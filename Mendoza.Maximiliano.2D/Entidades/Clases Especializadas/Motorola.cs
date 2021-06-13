using Entidades.Clases_Generales;
using Entidades.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Especializadas
{
    public class Motorola : Celular, IAcuatico
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
        public Motorola()
        {

        }

       

        public Motorola(int codigoDeBarras, materiaPrima.ECarcaza carcaza, materiaPrima.EBateria bateria, materiaPrima.ECamara camara, materiaPrima.EPlaquetaElectronica placa)
        : base(codigoDeBarras, new materiaPrima(carcaza, bateria, camara, placa))
        {
            this.android = Android;
            this.procesador = Procesador;
        }





        /// <summary>
        /// Metodo que devuelve la informacion del objeto Motorola
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {Celular.ETipoCelular.Motorola}");
            sb.AppendLine($"Modelo :{EModelo.MotoE7}");
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
            sb.AppendLine($"{Celular.ETipoCelular.Motorola}");
            sb.AppendLine($" {EModelo.MotoE7}");
            sb.AppendLine($"  Codigo :{this.CodigoDeBarras}");
            return sb.ToString();
        }

        /// <summary>
        /// implementacion de interface, devuelve un string
        /// </summary>
        /// <returns></returns>
        

        string IAcuatico.InfoAcuatico()
        {
            return ("Es acuatico");
        }



        /// <summary>
        /// compara dos objetos usando el equas de Celular
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        #region Sobrecargas
        public static bool operator ==(Motorola m1, Motorola m2)
        {
            return Celular.Equals(m1, m2);
        }

        public static bool operator !=(Motorola m1, Motorola m2)
        {
            return !(m1 == m2);
        }
        #endregion 
    }
}
