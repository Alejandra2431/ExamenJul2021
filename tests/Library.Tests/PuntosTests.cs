namespace Library.Tests
{
    public class PuntosTests
    {
        private Viajero viajero;
        [SetUp]
        public void SetUp()
        {
            viajero= new Viajero();
            viajero.monedasDelViajero= 9;
            viajero.bonosDelViajero= 4;
        }

        [Test]
        public void monedasAPuntos(Viajero viajero)
        {
            Assert.AreEqual(viajero.puntosDelViajero, 4);
        }
        [Test]
        public void bonosAPuntos(Viajero viajero)
        {
            Assert.AreEqual(viajero.puntosDelViajero,10);
        }
    }
}