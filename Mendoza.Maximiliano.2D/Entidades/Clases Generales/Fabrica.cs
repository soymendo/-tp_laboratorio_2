using Entidades.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Generales
{
    public class Fabrica
    {  

        /// <summary>
        /// Atributos 
        /// </summary>
        private int capacidadAlmacenGeneral;

        private Deposito<Celular> Ensamblados;
        private Deposito<Celular> DepositoOk;
        private Deposito<Celular> DepositoAReparar;
        private Deposito<Celular> Acuaticos;




      






       
        /// <summary>
        /// Constructores
        /// inicializo la lista
        /// </summary>
        public Fabrica()
        {
            this.Ensamblados = new Deposito<Celular>();
            this.DepositoOk = new Deposito<Celular>();
            this.DepositoAReparar = new Deposito<Celular>();
            this.Acuaticos = new Deposito<Celular>();

        }
        /// <summary>
        /// Le paso un tamaño a la lista
        /// </summary>
        /// <param name="tamanio"></param>
        public Fabrica(int tamanio)
        : this()
        {
            this.capacidadAlmacenGeneral = tamanio;
        }





        /// <summary>
        /// Propiedad devuelve el Tamaño de " DepositoAReparar"
        /// </summary>
        public int TamanioReparacion
        {
            get
            {
                return this.DepositoAReparar.tamanioDeposito();
            }
        }


        /// <summary>
        /// Propiedad devuelve el Tamaño de " Ensamblados"
        /// </summary>
        public int TamanioGeneral
        {
            get
            {
                return this.Ensamblados.tamanioDeposito();
            }
        }


        /// <summary>
        /// Propiedad devuelve el Tamaño de " DepositoOk"
        /// </summary>
        public int TamanioOk
        {
            get
            {
                return this.DepositoOk.tamanioDeposito();
            }
        }
        



      

        /// <summary>
        /// Verifica si el celular esta o no en ensamblados
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnEnsamblados(Fabrica f, Celular c)
        { 
            bool retorno = false;


            if (f.Ensamblados == c)
            {
                retorno = true;
            }



            return retorno;
        }


        /// <summary>
        /// Verifica si el celular  esta o no en deposito ok
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnDepositoOk(Fabrica f, Celular c)
        {
            bool retorno = false;


            if (f.DepositoOk == c)
            {
                retorno = true;
            }


            return retorno;
        }


        /// <summary>
        /// Verifica si el celular esta o no en deposito a reparar
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnDepositoAReparar(Fabrica f, Celular c)
        {
            bool retorno = false;

            if (f.DepositoAReparar == c)
            {
                retorno = true;
            }
            return retorno;

        }



        /// <summary>
        /// Guarda el Celualr en la lista Ensamblados
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>

        public static bool GuardarEnDepositoEnsamblados(Fabrica f, Celular c)
        {
            bool retorno = false;

            //si no esta almacenado en ensamblados
            if (!(Fabrica.AlmacenadoEnEnsamblados(f, c)) && f.capacidadAlmacenGeneral > f.Ensamblados.tamanioDeposito())
            {

                if (f.Ensamblados + c)//lo guardo
                {
                    retorno = true;
                }


            }



            return retorno;
        }


        /// <summary>
        /// Guarda el Celualr en la lista DepositoOk
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarEnDepositoOk(Fabrica f, Celular c)
        {
            bool retorno = false;
            //si no esta almacenado en deposito ok
            if (!(Fabrica.AlmacenadoEnDepositoOk(f, c)) && f.capacidadAlmacenGeneral > f.Ensamblados.tamanioDeposito())
            {

                if (f.DepositoOk + c)//lo guardo
                {
                   
                    if (c is IAcuatico)
                    {
                        if (f.Acuaticos + c) { }//lo guardo en acuaticos
                    }
                    retorno = true;
                }
            }



            return retorno;
        }


        /// <summary>
        /// Guarda el Celualr en la lista DepositoAReparar
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarEnDepositoAReparar(Fabrica f, Celular c)
        {
            bool retorno = false;

            //si no esta almacenado en deposito OK
            if (!(Fabrica.AlmacenadoEnDepositoOk(f, c)))
            {
                if (f.DepositoAReparar + c)//lo guardo 
                {
                    retorno = true;

                }

            }

            return retorno;
        }




        /// <summary>
        /// si esta almacenado en reparar, lo muevo a AlmacenadoOk
        /// luego elimina el objeto de la lista 
        /// </summary>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>


        //si esta almacenado en reparar, lo muevo a AlmacenadoOk
        //eliminar instancia o indice despues
        public static bool Reparacion(Fabrica f, Celular c)
        {
            bool retorno = false;
            

            if (Fabrica.AlmacenadoEnDepositoAReparar(f, c))
            {

                if (Fabrica.GuardarEnDepositoOk(f, c))
                {
                    retorno = true;
                    if (f.DepositoAReparar - c)//elimino de la lista  areparar el celular 
                    {
                        
                    }
                }


            }
           

            return retorno;

        }



        /// <summary>
        /// Metodo que simula una prueba de calidad
        /// recibe un numero aleatoria de afuera y si coincide con el ya establecido
        /// el celular se guarda en depositoAreparar , sino se guarda en depositoOk
        /// </summary>
        /// <param name="fab"></param>
        /// <param name="c"></param>
        /// <param name="numerito"></param>
        /// <returns></returns>

        //con un numero aleatorio externo indicamos si va a pasar o no la prueba
        public static bool IniciarPruebaDeCalidad(Fabrica fab, Celular c, int numerito)
        {
            bool retorno = false;

            if (!(numerito == 2))
            {
                if (Fabrica.GuardarEnDepositoOk(fab, c))
                {
                    Console.WriteLine("se almaceno ok");

                    retorno = true;
                }

            }
            else
            {
                if (Fabrica.GuardarEnDepositoAReparar(fab, c))
                {
                    Console.WriteLine("se almaceno REPARAR");
                    retorno = true;
                }
            }



            return retorno;
        }

        /// <summary>
        /// Muestra los Celulares de la lista DepositoOk
        /// </summary>
        /// <returns></returns>
        public string MostrarDepositoOk()
        {
           
            StringBuilder sb = new StringBuilder();  
            sb.AppendLine($"{DepositoOk.mostrarDeposito()}");
            return sb.ToString();
        }

        /// <summary>
        /// Muestra los Celulares de la lista DepositoAReparar
        /// </summary>
        /// <returns></returns>
        public string MostrarDepositoAReparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{DepositoAReparar.mostrarDeposito()}");
            return sb.ToString();
        }


        /// <summary>
        /// Muestra los Celulares de la lista Ensamblados
        /// </summary>
        /// <returns></returns>
        public string MostrarAlmacenGeneral()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Productos ensamblados: ");
            sb.AppendLine($"{Ensamblados.mostrarDeposito()}");

            return sb.ToString();
        }


        /// <summary>
        /// Muestra la lista de los celulares que implementan la interfaz IAcuatico
        /// </summary>
        /// <returns></returns>

        public string MostrarAcuaticos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Productos Acuaticos: ");

            sb.AppendLine($"{Acuaticos.mostrarDeposito()}");

            return sb.ToString();


        }




       

    }
}
