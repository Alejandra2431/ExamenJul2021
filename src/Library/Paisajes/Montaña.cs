using System.Collections.Generic;
namespace Library
{
    /*
        Se aplica el patron expert en esta clase ya que es la experta en los datos de los océanos y en cómo hacer los cálculos de ellos.
    */
    /// <summary>
    /// Montaña representa la experiencia-paisaje Montaña
    /// </summary>
    public class Montaña: Experiencia, IPaisaje 
    {
        /// <summary>
        /// Monedas a otorgar por visitar una Montaña
        /// </summary>
        /// <value>int</value>
        private int monedaXMontaña;
        public Montaña(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
            this.monedaXMontaña= 1;
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        /// <param name="viajero"></param>
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