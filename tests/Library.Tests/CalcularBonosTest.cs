using System.Collections.Generic;
using NUnit.Framework;
using System;
namespace Library.Tests
{
    public class CalcularBonosTest
    {
        private Viajero viajero;
        [SetUp]
        public void SetUp()
        {
            viajero= new Viajero();
        }

        [Test]
        public void CalcularBonoAguasTermalesTest()
        {
            AguasTermales aguasTermales4 = new AguasTermales(1, null, 2);
            AguasTermales aguasTermales3 = new AguasTermales(1, aguasTermales4, 1);
            AguasTermales aguasTermales2 = new AguasTermales(1, aguasTermales3, 2);
            AguasTermales aguasTermales1 = new AguasTermales(1, aguasTermales2, 1);
            aguasTermales1.AgregarViajero(viajero);
            Assert.AreEqual(aguasTermales1.CalcularBonos(viajero), 0);
            aguasTermales2.AgregarViajero(viajero);
            Assert.AreEqual(aguasTermales2.CalcularBonos(viajero), 1);
            aguasTermales3.AgregarViajero(viajero);
            Assert.AreEqual(aguasTermales3.CalcularBonos(viajero), 1);
            aguasTermales4.AgregarViajero(viajero);
            Assert.AreEqual(aguasTermales4.CalcularBonos(viajero), 2);
        }
    }
}