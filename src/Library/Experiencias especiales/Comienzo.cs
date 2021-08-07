using System.Collections.Generic;
namespace Library
{
    /*
        Comienzo cumple con SRP porque su única responsabilidad es encargarse de la inicio del juego.
        También cumple con el patrón Expert porque sabe todo lo necesario para realizar su tarea. 
        Esta es clase es complemento de Tablero.
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