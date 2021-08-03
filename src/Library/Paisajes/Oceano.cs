using System.Collections.Generic;
namespace Library
{
    public class Oceano: Experiencia, IPaisaje
    {
        private int monedaXOceano;
        private List<Viajero> viajerosEnOceano;
        public Oceano(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
            this.monedaXOceano= 1;
            this.cantViajeros=2;
            List<Viajero> viejaerosEnOceano= new List<Viajero>();
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantOceanos += 1;
            viajero.puntosDelViajero += CalcularPuntaje(viajero.cantOceanos);
            viajero.monedasDelViajero += Monedas();
        }
        public int Monedas()
        {
            return this.monedaXOceano;
        }
        public int CalcularPuntaje(int cantOceanos)
        {
            if (cantOceanos != 1)
            {
                cantOceanos += cantOceanos - 1;
            }
            return cantOceanos;
        }
    }
}