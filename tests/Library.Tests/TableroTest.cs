using System.Collections.Generic;
using NUnit.Framework;
using System;
namespace Library.Tests
{
    public class TableroTest
    {
        private Comienzo comienzo;
        private Tablero tablero;
        private Viajero viajero1;
        private Viajero viajero2;
        private Viajero viajero3;
        [SetUp]
        public void SetUp()
        {
            viajero1= new Viajero();
            viajero2= new Viajero();
            viajero3= new Viajero();
        }
        [Test]
        public void JuegoFinalizadoTest()
        {
            AgregarViajeroExcepcion errorFin= Assert.Throws<AgregarViajeroExcepcion>(new TestDelegate(JuegoFinalizado1Test));                  
            Assert.That(errorFin.Message, Is.EqualTo("Se agregó la máxima cantidad de viajeros posible"));
        }
        public void JuegoFinalizado1Test()
        {
            Fin fin = new Fin(2, null, 3);
            fin.AgregarViajero(viajero1);
            fin.AgregarViajero(viajero2);
            fin.AgregarViajero(viajero3);

        }
        [Test]
        public void AgregarViajerosAlComienzoTest()
        {
            NoIniciaElJuegoExcepcion errorAgregar= Assert.Throws<NoIniciaElJuegoExcepcion>(new TestDelegate(AgregarViajerosAlComienzoTest1));                  
            Assert.That(errorAgregar.Message, Is.EqualTo("No se encontró la Experiencia Comienzo"));

        }
        public void AgregarViajerosAlComienzoTest1()
        { 
            List<Viajero> viajeros= new List<Viajero>();
            viajeros.Add(viajero1);
            viajeros.Add(viajero2);
            tablero= new Tablero(viajeros, comienzo);
            tablero.AgregarViajerosAlComienzo(viajeros, comienzo);
            

        }
    }
}