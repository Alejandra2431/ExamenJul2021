using System.Collections.Generic;
namespace Library
{
    /*
        Se aplica el patron Singleton ya que se crea una única vez la instancia de Comienzo. 
    */
    /// <summary>
    /// Representa la primera experiencia del juego
    /// </summary>
    public class Comienzo: Experiencia
    {
        public Comienzo(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        /// <param name="viajero"></param>
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.posicionEnCamino =this.posicionEnCamino;
        }
        /// <summary>
        /// Agrega viajero a la experiencia Comienzo si se cumple la condición
        /// </summary>
        /// <param name="viajero"></param>
        public override void AgregarViajero(Viajero viajero)
        {
            if (this.viajeros.Count<this.cantViajeros)
            {
                this.viajeros.Add(viajero);
                this.ActualizarViajero(viajero);
            }
            else
            {
                throw new AgregarViajeroExcepcion("Se agregó la máxima cantidad de viajeros posible");
            }
        }
    }
}