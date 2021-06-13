using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Entidades;
using Entidades.Clases_Generales;
using Entidades.Clases_Especializadas;

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
    }
}
