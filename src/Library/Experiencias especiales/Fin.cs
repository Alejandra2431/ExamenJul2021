using System.Collections.Generic;
namespace Library
{
    /*
        Fin cumple con SRP porque su única responsabilidad es encargarse de la resolución del juego.
        También cumple con el patrón Expert porque sabe todo lo necesario para realizar su tarea.   
    */
    /// <summary>
    /// Representa la última experiencia del juego
    /// </summary>
    public class Fin: Experiencia
    {   
        public Fin(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        /// <param name="viajero"></param>
        public override void ActualizarViajero(Viajero viajero) 
        {
            viajero.viajeroEnFin= true;
            Puntos puntos = new Puntos();
            viajero.puntosDelViajero+= puntos.MonedasAPuntos(viajero);
            viajero.puntosDelViajero+=puntos.BonosAPuntos(viajero);
        }
        /// <summary>
        /// Agrega viajero a la experiencia Fin si se cumple la condición
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