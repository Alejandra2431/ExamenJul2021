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
            this.monedasXGranja= 2;
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantGranjas += 1;
            viajero.monedasDelViajero += CalcularMonedas(viajero);
        }
        //Cada vez que se visita una granja se le suma una cantidad de monedas 
        //que corresponde a multiplicar la cantidad de visitas a una granja por 2.
        public int CalcularMonedas(Viajero viajero)
        {
            viajero.monedasDelViajero += GetMonedas() * viajero.cantGranjas;
            return viajero.monedasDelViajero;
        }
    }
}
