using System.Collections.Generic;
namespace Library
{
    public class Oceano: Experiencia, IPaisaje
    {
        private int monedaXOceano;
        private List<Viajero> viajerosEnOceano;

        public Oceano(int maxViajeros, Experiencia sigExperiencia): base (maxViajeros, sigExperiencia)
        {
            this.monedaXOceano= 1;
            this.cantViajeros=2;
            List<Viajero> viejaerosEnOceano= new List<Viajero>();
        }

        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantOceanos += 1;
            viajero.puntosDelViajero += CalcularPuntaje(viajero.cantOceanos);
        }

        public int AumentarCant(int cantAnteriorOceanos)   // VER SI PONGO ESTE MÉTODO EN OTRA CLASE
        {
            return cantAnteriorOceanos + 1;
        }

        public int Moneda()
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