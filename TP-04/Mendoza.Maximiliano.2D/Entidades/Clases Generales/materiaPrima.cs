using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Generales
{
  public  class materiaPrima
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private ECarcaza carcaza;
        private EBateria bateria;
        private ECamara camara;
        private EPlaquetaElectronica placa;
        
       
        /// <summary>
        /// Propiedades
        /// </summary>
        public ECarcaza Carcaza
        {
            get
            {
                return this.carcaza;
            }
            set
            {
                this.carcaza = value;
            }
        }

        public EBateria Bateria
        {
            get
            {
                return this.bateria;
            }
            set
            {
                this.bateria = value;
            }
        }
        public ECamara Camara
        {
            get
            {
                return this.camara;
            }
            set
            {
                this.camara = value;
            }
        }
        public EPlaquetaElectronica Placa
        {
            get
            {
                return this.placa;
            }
            set
            {
                this.placa = value;
            }
        }


        /// <summary>
        /// Enumerados
        /// </summary>
        public enum ECarcaza
        {
            Plastico, Metal
        }

        public enum EBateria
        {
            Mediana, Grande, Litio
        }

        public enum ECamara
        {
            Standar, fullHD, ultraHD
        }

        public enum EPlaquetaElectronica
        {
            SerieA, SerieH, SerieN, SerieM, SerieS
        }



        /// <summary>
        /// Constructores
        /// </summary>
        /// <param name="carcaza"></param>
        /// <param name="bateria"></param>
        /// <param name="camara"></param>
        /// <param name="placa"></param>

        public materiaPrima(ECarcaza carcaza, EBateria bateria, ECamara camara, EPlaquetaElectronica placa)
        {
            this.carcaza = carcaza;
            this.bateria = bateria;
            this.camara = camara;
            this.placa = placa;
        }




        /// <summary>
        /// Devuelve la informacion de la materia prima
        /// a traves de sus propiedades
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Carcaza: {Carcaza}");
            sb.AppendLine($" Bateria: {Bateria}");
            sb.AppendLine($" Camara: {Camara}");
            sb.AppendLine($" Placa: {Placa}");

            return sb.ToString();
        }



        /// <summary>
        /// Compara si deos materias primas son iguales
        /// por medio de todas sus propiedades
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(materiaPrima m1, materiaPrima m2)
        {
            return (m1.carcaza == m2.carcaza && m1.bateria == m2.bateria && m1.camara == m2.camara && m1.placa == m2.placa);
        }

        public static bool operator !=(materiaPrima m1, materiaPrima m2)
        {
            return !(m1 == m2);
        }


    }
}

