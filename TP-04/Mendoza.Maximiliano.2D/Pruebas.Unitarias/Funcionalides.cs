using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Entidades;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Clases_Generales;
using Entidades.Clases_Especializadas;
using Entidades.Archivos;
using Entidades.Exepciones;
using System.Collections.Generic;

namespace Pruebas.Unitarias
{
    [TestClass]
    public class Funcionalidades
    {
        [TestMethod]

        public void PruebaDeCalidad()
        {
            bool metodo;
            Fabrica f = new Fabrica(10);
            Alcatel a1 = new Alcatel(123, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Litio, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieA);
            Random aleatorio = new Random();
            int numerito = aleatorio.Next(1, 3);


            metodo = Fabrica.IniciarPruebaDeCalidad(f, a1, numerito);

            Assert.IsTrue(metodo);

        }


        [TestMethod]
        public void Reparacion()
        {
            bool metodo;
            Fabrica f = new Fabrica(10);
            Alcatel a1 = new Alcatel(123, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Litio, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieA);

            if (Fabrica.GuardarEnDepositoAReparar(f, a1))
            { }

            metodo = Fabrica.Reparacion(f, a1);

            Assert.IsTrue(metodo);

        }

        /// <summary>
        /// Permite ver si se guarda un archivo en xml
        /// </summary>

        [TestMethod]
        public void GuardarXML()
        {
            string text="guardo xml";
            Xml<string> xml = new Xml<string>();
            bool seGuardo = false;

            if(xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Algo.xml", text))
            {
                seGuardo = true;
            }

            Assert.IsTrue(seGuardo);

        }


        /// <summary>
        /// comprueba la exepcion ArchivoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivoException))] 


        public void LeerTxt()
        {
            Texto texto = new Texto();

            if (texto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.txt", out string nombres))
            {

            }

        }


        /// <summary>
        /// comprueba la exepcion BaseDeDatosException
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(BaseDeDatosException))]

        public void LeerTablaNoCargada()
        {
            CelularesDAO celuDao = new CelularesDAO();
            List<Celular> celulares = celuDao.LeerTestUnitario();
         

        }
        

    }



    
}







