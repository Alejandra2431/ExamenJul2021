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
        public void AgregarViajero()
        {
            AgregarViajeroExcepcion error= Assert.Throws<AgregarViajeroExcepcion>(new TestDelegate(AgregarViajeroTest2));                  
            Assert.That(error.Message, Is.EqualTo("Se agregó la máxima cantidad de viajeros posible"));

            AgregarViajeroExcepcion error2= Assert.Throws<AgregarViajeroExcepcion>(new TestDelegate(AgregarViajeroTest3));                  
            Assert.That(error2.Message, Is.EqualTo("No hay próxima experiencia, el viajero llegó al final"));
        }
        private void AgregarViajeroTest2()
        {
            Viajero viajero1 = new Viajero();
            Viajero viajero2 = new Viajero();

            Fin fin = new Fin(2, null, 1);
            fin.AgregarViajero(viajero1);
            fin.AgregarViajero(viajero2);
        }
        private void AgregarViajeroTest3()
        {
            Fin fin = new Fin(2, null, 1);
        }
    }
}