using System.Collections.Generic;
using NUnit.Framework;
using System;
namespace Library.Tests
{   
    //Test para las experiencias Comienzo y Fin
    public class AgregarViajeroEnComienzoYFinTest
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void AgregarViajeroTest()
        {
            AgregarViajeroExcepcion errorFin= Assert.Throws<AgregarViajeroExcepcion>(new TestDelegate(AgregarViajeroFinTest));                  
            Assert.That(errorFin.Message, Is.EqualTo("Se agregó la máxima cantidad de viajeros posible"));

            AgregarViajeroExcepcion errorComienzo= Assert.Throws<AgregarViajeroExcepcion>(new TestDelegate(AgregarViajeroComienzoTest));                  
            Assert.That(errorComienzo.Message, Is.EqualTo("Se agregó la máxima cantidad de viajeros posible"));
        }
        private void AgregarViajeroFinTest()
        {
            Viajero viajero1 = new Viajero();
            Viajero viajero2 = new Viajero();
            Fin fin = new Fin(1, null, 1);
            fin.AgregarViajero(viajero1);
            fin.AgregarViajero(viajero2);
        }
        private void AgregarViajeroComienzoTest()
        {
            Viajero viajero1 = new Viajero();
            Viajero viajero2 = new Viajero();
            Comienzo comienzo = new Comienzo(1, null, 1);
            comienzo.AgregarViajero(viajero1);
            comienzo.AgregarViajero(viajero2);
        }
    }
}