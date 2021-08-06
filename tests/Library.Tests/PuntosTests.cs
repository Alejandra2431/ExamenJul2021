using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace Library.Tests
{
    public class PuntosTests
    {
        private Viajero viajero;
        private Puntos puntos;
        [SetUp]
        public void SetUp()
        {
            viajero= new Viajero();
            puntos= new Puntos();
        }

        [Test]
        public void MonedasAPuntos1()
        {
            viajero.monedasDelViajero=5;
            puntos.MonedasAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 2);
        }
        [Test]
        public void MonedasAPuntos2()
        {
            viajero.monedasDelViajero=9;
            puntos.MonedasAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 4);
        }
        [Test]
        public void MonedasAPuntos3()
        {
            viajero.monedasDelViajero=7;
            puntos.MonedasAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 6);
        }
        [Test]
        public void BonosAPuntos1()
        {
            viajero.bonosDelViajero=1;
            puntos.BonosAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 5);
        }
        [Test]
        public void BonosAPuntos2()
        {
            viajero.bonosDelViajero=3;
            puntos.BonosAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 8);
        }
        [Test]
        public void BonosAPuntos3()
        {
            viajero.bonosDelViajero=6;
            puntos.BonosAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 10);
        }
    }
}