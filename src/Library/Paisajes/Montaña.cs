using System.Collections.Generic;
namespace Library
{
    public class Montaña: Experiencia, IPaisaje 
    {
        private int monedaXMontaña;  //lo saco??? no es necesario, se calcula la cantidad en Viajero
        
        public Montaña(int maxViajeros, Experiencia sigExperiencia): base (maxViajeros, sigExperiencia)
        {
            this.monedaXMontaña= 1;
        }

        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantMontañas += 1;
            viajero.puntosDelViajero += CalcularPuntaje(viajero.cantMontañas);
        }

        public int AumentarCant(int cantAnteriorMontañas)
        {
            return cantAnteriorMontañas + 1;
        }


        public int Moneda() 
        {
          return this.monedaXMontaña;
        }


        public int CalcularPuntaje(int cantMontañas) 
        {
            return cantMontañas;
        }
        
    }
}

    