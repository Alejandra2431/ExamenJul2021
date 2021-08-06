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
        public void monedasAPuntos1()
        {
            viajero.monedasDelViajero=5;
            puntos.monedasAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 2);
        }
        [Test]
        public void monedasAPuntos2()
        {
            viajero.monedasDelViajero=9;
            puntos.monedasAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 4);
        }
        [Test]
        public void monedasAPuntos3()
        {
            viajero.monedasDelViajero=7;
            puntos.monedasAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 6);
        }
        [Test]
        public void bonosAPuntos1()
        {
            viajero.bonosDelViajero=1;
            puntos.bonosAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 5);
        }
        [Test]
        public void bonosAPuntos2()
        {
            viajero.bonosDelViajero=3;
            puntos.bonosAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 8);
        }
        [Test]
        public void bonosAPuntos3()
        {
            viajero.bonosDelViajero=6;
            puntos.bonosAPuntos(viajero);
            Assert.AreEqual(viajero.puntosDelViajero, 10);
        }
    }
}