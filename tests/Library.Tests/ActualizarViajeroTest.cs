using System.Collections.Generic;
using NUnit.Framework;
using System;
namespace Library.Tests
{
    public class ActualizarViajeroTest
    {
        private Viajero viajero;
        [SetUp]
        public void SetUp()
        {
            viajero= new Viajero();
        }

        [Test]
        public void ActualizarViajeroGranjaTest()
        {
            Granja granja2 = new Granja(1, null, 2);
            Granja granja1 = new Granja(1, granja2, 1);
            granja1.ActualizarViajero(viajero);
            granja2.ActualizarViajero(viajero);
            Assert.AreEqual(viajero.cantGranjas, 2);
            Assert.AreEqual(viajero.monedasDelViajero, 6);
        }
        [Test]
        public void ActualizarViajeroAguasTermalesTest()
        {
            AguasTermales aguas3 = new AguasTermales(1, null, 3);
            AguasTermales aguas2 = new AguasTermales(1, aguas3, 2);
            AguasTermales aguas1 = new AguasTermales(1, aguas2, 1);
            aguas1.ActualizarViajero(viajero);
            aguas2.ActualizarViajero(viajero);
            aguas3.ActualizarViajero(viajero);
            Assert.AreEqual(viajero.cantAguasTermales, 3);
            Assert.AreEqual(viajero.bonosDelViajero, 2);
        }
        [Test]
        public void ActualizarViajeroOceanoTest()
        {
            Oceano oceano4 = new Oceano(2, null, 3);
            Oceano oceano3 = new Oceano(2, oceano4, 2);
            Oceano oceano2 = new Oceano(2, oceano3, 3);
            Oceano oceano1 = new Oceano(2, oceano2, 2);
            oceano1.ActualizarViajero(viajero);
            oceano2.ActualizarViajero(viajero);
            oceano3.ActualizarViajero(viajero);
            oceano4.ActualizarViajero(viajero);
            Assert.AreEqual(viajero.monedasDelViajero, 4);
            Assert.AreEqual(viajero.cantOceanos, 4);
            Assert.AreEqual(viajero.puntosDelViajero, 16);
        }
        public void ActualizarViajeroMontañaTest()
        {
            Montaña montaña3 = new Montaña(1, null, 2);
            Montaña montaña2 = new Montaña(2, montaña3, 3);
            Montaña montaña1 = new Montaña(2, montaña2, 2);
            montaña1.ActualizarViajero(viajero);
            montaña2.ActualizarViajero(viajero);
            montaña3.ActualizarViajero(viajero);
            Assert.AreEqual(viajero.monedasDelViajero, 3);
            Assert.AreEqual(viajero.cantOceanos, 3);
            Assert.AreEqual(viajero.puntosDelViajero, 5);
        }
        public void ActualizarViajeroComienzoTest()
        {
            Montaña montaña = new Montaña(2, null, 3);
            Comienzo comienzo = new Comienzo(4, montaña, 1);
            comienzo.ActualizarViajero(viajero);
            Assert.AreEqual(viajero.posicionEnCamino, 1);
        }
        public void ActualizarViajeroFinTest()
        {
            Fin fin = new Fin(4, null, 1);
            fin.ActualizarViajero(viajero);
            Assert.AreEqual(viajero.viajeroEnFin, true);
        }
    }
}