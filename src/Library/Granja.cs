namespace Library
{
    public class Granja: Experiencia
    {
        public bool trabaja;
        private int monedasXGranja;
        public int GetMonedas()
        {
            return this.monedasXGranja;
        }
        public Granja(bool trabajar, int maxViajeros, Experiencia sigExperiencia): base(maxViajeros, sigExperiencia)
        {
            this.trabaja= trabajar;
            this.monedasXGranja= 3;
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantMontañas += 1;
            viajero.monedasDelViajero += CalcularMonedas(viajero);
        }
        public int CalcularMonedas(Viajero viajero)
        {
            viajero.monedasDelViajero += GetMonedas();
            return viajero.monedasDelViajero;
        }
    }
}
