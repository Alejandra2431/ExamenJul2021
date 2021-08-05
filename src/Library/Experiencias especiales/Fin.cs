using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Representa la última experiencia del juego
    /// </summary>
    public class Fin: Experiencia
    {   
        /// <summary>
        /// Lista de viajeros
        /// </summary>
        /// <value>List<Viajero></value>
        private List<Viajero> viajerosEnFinal;
        private Puntos puntos;
        public Fin(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
            List<Viajero> viajerosEnFinal= new List<Viajero>();
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        /// <param name="viajero"></param>
        public override void ActualizarViajero(Viajero viajero) 
        {
            viajero.viajeroEnFin= true;
            Puntos puntos = new Puntos();
            viajero.puntosDelViajero= puntos.monedasAPuntos(viajero);
            viajero.puntosDelViajero=puntos.bonosAPuntos(viajero);
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