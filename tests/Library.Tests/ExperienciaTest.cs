using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace Library.Tests
{   /*
        Test para todas las experiencias excepto para Comienzo y Fin
    */
    public class ExperienciaTest
    {
   
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void AgregarViajero()
        {
            AgregarViajeroExcepcion error1= Assert.Throws<AgregarViajeroExcepcion>(new TestDelegate(AgregarViajeroTest1));                  
            Assert.That( error1.Message, Is.EqualTo("No hay próxima experiencia, el viajero llegó al final") );
        }
        public void AgregarViajeroTest1()
        {
            Viajero viajero1 = new Viajero();
            Viajero viajero2 = new Viajero();
            Montaña montaña = new Montaña(1, null, 1);
            montaña.AgregarViajero(viajero1);
            montaña.AgregarViajero(viajero2);
        }
    }
}