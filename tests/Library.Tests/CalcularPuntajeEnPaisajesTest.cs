using System.Collections.Generic;
using NUnit.Framework;
using System;
namespace Library.Tests
{
    public class CalcularPuntajeEnPaisajesTest
    {
        private Viajero viajero;
        [SetUp]
        public void SetUp()
        {
            viajero= new Viajero();
        }

        [Test]
        public void CalcularPuntajeMontañaTest()
        {
            Montaña montaña4 = new Montaña(1, null, 2);
            Montaña montaña3 = new Montaña(1, montaña4, 1);
            Montaña montaña2 = new Montaña(1, montaña3, 2);
            Montaña montaña1 = new Montaña(1, montaña2, 1);
            montaña1.AgregarViajero(viajero);
            Assert.AreEqual(montaña1.CalcularPuntaje(viajero.cantMontañas), 1);
            montaña2.AgregarViajero(viajero);
            Assert.AreEqual(montaña2.CalcularPuntaje(viajero.cantMontañas), 2);
            montaña3.AgregarViajero(viajero);
            Assert.AreEqual(montaña3.CalcularPuntaje(viajero.cantMontañas), 3);
            montaña4.AgregarViajero(viajero);
            Assert.AreEqual(montaña4.CalcularPuntaje(viajero.cantMontañas), 4);
        }
        [Test]
        public void CalcularPuntajeOceanoTest()
        {
            Oceano oceano3 = new Oceano(1, null, 1);
            Oceano oceano2 = new Oceano(1, oceano3, 2);
            Oceano oceano1 = new Oceano(1, oceano2, 1);
            oceano1.AgregarViajero(viajero);
            Assert.AreEqual(oceano2.CalcularPuntaje(viajero.cantOceanos), 1);
            oceano2.AgregarViajero(viajero);
            Assert.AreEqual(oceano2.CalcularPuntaje(viajero.cantOceanos), 3);
            oceano3.AgregarViajero(viajero);
            Assert.AreEqual(oceano3.CalcularPuntaje(viajero.cantOceanos), 5);
        }
        
    }
}