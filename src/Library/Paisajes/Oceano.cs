using System.Collections.Generic;
namespace Library
{
    /*
        Se aplica el patron expert en esta clase ya que es la experta en los datos de los océanos y en cómo hacer los cálculos de ellos.
        Además cumple con SRP porque su única responsabilidad es saber cómo resolverse a sí misma.
    */
    /// <summary>
    /// Oceano representa la experiencia-paisaje Oceano
    /// </summary>
    public class Oceano: Experiencia, IPaisaje
    {
        /// <summary>
        /// Monedas a otorgar por visitar un Oceano
        /// </summary>
        /// <value>int</value>
        private int monedaXOceano;
        public Oceano(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
            this.monedaXOceano= 1;
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantOceanos += 1;
            viajero.puntosDelViajero += CalcularPuntaje(viajero.cantOceanos);
            viajero.monedasDelViajero += Monedas();
        }
        /// <summary>
        /// Retorna las monedas por la visita
        /// </summary>
        /// <param name="monedaXOceano"></param>
        /// <returns>int</returns>
        public int Monedas()
        {
            return this.monedaXOceano;
        }
        /// <summary>
        /// Retorna los puntos que se le suman al viajero por visitar la experiencia Oceano
        /// </summary>
        /// <param name="cantOceanos"></param>
        /// <returns>int</returns>
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