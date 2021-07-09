using Entidades.Clases_Generales;
using Entidades.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Especializadas
{
    public class Alcatel : Celular, IAcuatico, IIrrompible
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
                return EAndroid.Go;
            }
        }
        public EProcesador Procesador
        {
            get
            {
                return EProcesador.Core;
            }
        }
       


        /// <summary>
        /// Constructores
        /// </summary>
        public Alcatel()
        {
            //Modelo = EModelo.s1;
        }

       
       

        public Alcatel(int codigoDeBarras, materiaPrima.ECarcaza carcaza, materiaPrima.EBateria bateria, materiaPrima.ECamara camara, materiaPrima.EPlaquetaElectronica placa)
        : base(codigoDeBarras, new materiaPrima(carcaza, bateria, camara, placa))
        {
            this.android = Android;
            this.procesador = Procesador;
        }

      


      
        /// <summary>
        /// Metodo que devuelve la informacion del objeto Alcatel
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {Celular.ETipoCelular.Alcatel}");
            sb.AppendLine($"Modelo :{this.Modelo}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Android: {this.Android}");
            sb.AppendLine($"Procesador: {this.Procesador}");
            // sb.AppendLine($"Acuatico: {this.Acua()}");
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
            sb.AppendLine($"{Celular.ETipoCelular.Alcatel}");
            sb.AppendLine($" {EModelo.s1}");
            sb.AppendLine($"  Codigo :{this.CodigoDeBarras}");

            return sb.ToString();

        }

        /// <summary>
        /// interfaces devuelve un string
        /// </summary>
        /// <returns></returns>
        string IAcuatico.InfoAcuatico()
        {
            return ("Es acuatico");
        }


        string IIrrompible.Descripcion()
        {
            return ("Es Bastante fuerte");
        }
        


        /// <summary>
        /// compara dos objetos usando el equas de Celular
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        #region Sobrecargas
        public static bool operator ==(Alcatel a1, Alcatel a2)
        {
            return Celular.Equals(a1, a2);
        }

        public static bool operator !=(Alcatel a1, Alcatel a2)
        {
            return !(a1 == a2);
        }

      
        #endregion

    }
}
