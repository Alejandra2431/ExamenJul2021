using System.Collections.Generic;
using NUnit.Framework;
using System;
namespace Library.Tests
{
    public class CalcularMonedasTest
    {
        private Viajero viajero7;
        [SetUp]
        public void SetUp()
        {
            viajero7= new Viajero();
        }

        [Test]
        public void CalcularMonedaGranjaTest()
        {
            Granja Granja4 = new Granja(1, null, 2);
            Granja Granja3 = new Granja(1, Granja4, 1);
            Granja Granja2 = new Granja(1, Granja3, 2);
            Granja Granja1 = new Granja(1, Granja2, 1);
            Granja1.AgregarViajero(viajero7);
            Assert.AreEqual(Granja1.CalcularMonedas(viajero7), 2);
            Granja2.AgregarViajero(viajero7);
            Assert.AreEqual(Granja2.CalcularMonedas(viajero7), 4);
            Granja3.AgregarViajero(viajero7);
            Assert.AreEqual(Granja3.CalcularMonedas(viajero7), 6);
            Granja4.AgregarViajero(viajero7);
            Assert.AreEqual(Granja4.CalcularMonedas(viajero7), 8);
        }
    }
}