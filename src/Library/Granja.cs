namespace Library
{
    public class Granja: Experiencia
    {
        public bool trabaja;
        private int aumentarMonedas;
        public Granja(bool trabajar, int maxViajeros, Experiencia sigExperiencia): base(maxViajeros, sigExperiencia)
        {
            this.trabaja= trabajar;
            this.aumentarMonedas= 2;
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantGranjas += 1;
            viajero.monedasDelViajero += CalcularMonedas(viajero);
        }
        //Por cada visita a una granja se le da en monedas, el doble de la cantidad de visitas
        public int CalcularMonedas(Viajero viajero)
        {
            viajero.monedasDelViajero += aumentarMonedas * viajero.cantGranjas;
            return viajero.monedasDelViajero;
        }
    }
}
