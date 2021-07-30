using System.Collections.Generic;
namespace Library
{
    public class Montaña: Experiencia, IPaisaje 
    {
        private int monedaXMontaña;
        
        public Montaña(int maxViajeros, Experiencia sigExperiencia): base (maxViajeros, sigExperiencia)
        {
            this.monedaXMontaña= 1;
            this.cantViajeros=2;
            List<Viajero> viajerosEnMontaña= new List<Viajero>();
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantMontañas += 1;
            viajero.puntosDelViajero += CalcularPuntaje(viajero.cantMontañas);
            viajero.monedasDelViajero += Monedas();
        }
        public int Monedas() 
        {
          return this.monedaXMontaña;
        }
        public int CalcularPuntaje(int cantMontañas) 
        {
            return cantMontañas;
        }        
    }
}