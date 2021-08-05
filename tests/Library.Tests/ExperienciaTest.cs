namespace Library.Tests
{
    public class ExperienciaTest
    {
        private Viajero viajero1;
        private Viajero viajero2;
        private Viajero viajero3;
        private List<Viajero> viajeros;
        [SetUp]
        public void SetUp()
        {
            viajero1 = new Viajero();
            viajero2 = new Viajero();
            viajero3 = new Viajero();
            viajeros = new List<Viajeros>();
            viajeros.Add(viajero1);
        }
        [Test]
        public void AgregarViajero()
        {
        }
    }
}