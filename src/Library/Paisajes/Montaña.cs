using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Montaña representa la experiencia-paisaje Montaña
    /// </summary>
    public class Montaña: Experiencia, IPaisaje 
    {
        /// <summary>
        /// Monedas a otorgar por visitar una montaña
        /// </summary>
        /// <value>int</value>
        private int monedaXMontaña;
        public Montaña(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
            this.monedaXMontaña= 1;
            this.cantViajeros=2;
        }
        /// <summary>
        /// Actualizar la información del viajero
        /// </summary>
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantMontañas += 1;
            viajero.puntosDelViajero += CalcularPuntaje(viajero.cantMontañas);
            viajero.monedasDelViajero += Monedas();
        }
        /// <summary>
        /// Retorna las monedas por la visita
        /// </summary>
        /// <param name="monedaXMontaña"></param>
        /// <returns>int</returns>
        public int Monedas() 
        {
          return this.monedaXMontaña;
        }
        /// <summary>
        /// Retorna los puntos que se le suman la viajero por visitar la experiencia Montaña
        /// </summary>
        /// <param name="cantMontañas"></param>
        /// <returns>int</returns>
        public int CalcularPuntaje(int cantMontañas) 
        {
            return cantMontañas;
        }        
    }
}