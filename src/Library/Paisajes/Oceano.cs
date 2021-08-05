using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Oceano representa la experiencia-paisaje Oceano
    /// </summary>
    public class Oceano: Experiencia, IPaisaje
    {
        /// <summary>
        /// Monedas a otorgar por visitar un oceano
        /// </summary>
        /// <value>int</value>
        private int monedaXOceano;
        public Oceano(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
            this.monedaXOceano= 1;
            this.cantViajeros=2;
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
        /// Retorna los puntos que se le suman la viajero por visitar la experiencia Oceano
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