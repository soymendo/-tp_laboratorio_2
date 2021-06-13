using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Clases_Especializadas;
using Entidades.Clases_Generales;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numerito = aleatorio.Next(1, 3);

            Fabrica fab = new Fabrica(10);



            Alcatel al = new Alcatel(123456, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Grande, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieA);
            Alcatel al2 = new Alcatel(123456, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Grande, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieA);

            Huawei huw = new Huawei(256893, materiaPrima.ECarcaza.Plastico, materiaPrima.EBateria.Litio, materiaPrima.ECamara.standar, materiaPrima.EPlaquetaElectronica.SerieH);
            Motorola mot = new Motorola(254569, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Mediana, materiaPrima.ECamara.fullHD, materiaPrima.EPlaquetaElectronica.SerieM);


            /****************************Guadar celulares***********************************/


            if (Fabrica.GuardarEnDepositoEnsamblados(fab, al))
            {
                Console.WriteLine("Guadado bien");
            }
            else
            {
                Console.WriteLine("Repetido");
            }



            if (Fabrica.GuardarEnDepositoEnsamblados(fab, al2))
            {
                Console.WriteLine("Guadado bien");
            }
            else
            {
                Console.WriteLine("Repetido ");
            }



            if (Fabrica.GuardarEnDepositoEnsamblados(fab, huw))
            {
                Console.WriteLine("Guadado bien");
            }
            else
            {
                Console.WriteLine("Repetido ");
            }



            Console.WriteLine();



            /****************************Iniciar prueba de calidad***********************************/

            if (Fabrica.IniciarPruebaDeCalidad(fab, al, numerito))
            {
                Console.WriteLine("Prueba realizada correctamente");
                numerito = aleatorio.Next(1, 3);
            }
            else
            {
                Console.WriteLine("algo fallo");
            }


            if (Fabrica.IniciarPruebaDeCalidad(fab, huw, numerito))
            {
                Console.WriteLine("Prueba realizada correctamente");
                numerito = aleatorio.Next(1, 3);
            }
            else
            {
                Console.WriteLine("algo fallo");
            }





            /**********************************************REPARACION************************************************************************/
            //muestrola lista de Areparar antes de repararlos
            Console.WriteLine("*******************************************");
            Console.WriteLine(fab.MostrarDepositoAReparar());
            Console.WriteLine("*******************************************");

            if (Fabrica.Reparacion(fab, al))
            {
                Console.WriteLine("se REPARO y almaceno ");
            }
            else
            {
                Console.WriteLine("No hace falta reparar el producto esta OK ");
            }

            if (Fabrica.Reparacion(fab, huw))
            {
                Console.WriteLine("se REPARO y almaceno ");
            }
            else
            {
                Console.WriteLine("No hace falta reparar el producto esta OK ");
            }




            Console.WriteLine("*******************************************");
            Console.WriteLine(fab.MostrarAlmacenGeneral());
            Console.WriteLine("*******************************************");


            Console.WriteLine(fab.MostrarDepositoOk());
            Console.WriteLine("*******************************************");

            Console.WriteLine(fab.MostrarDepositoAReparar());
            Console.WriteLine("*******************************************");

            /*********************************ACUATICOS***********************************/
            Console.WriteLine("/*****************************************/");
            try
            {
                Console.WriteLine(fab.MostrarAcuaticos());
              

            }
            catch (NullReferenceException e)// cuando no inicializo una lista
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("/*****************************************/");


            Console.ReadKey();
        }
    }
    }

