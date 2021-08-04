using System.Collections.Generic;
namespace Library
{
    public class Fin: Experiencia
    {
       private List<Viajero> viajerosEnFinal;
       public Fin(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
       {
           List<Viajero> viajerosEnFinal= new List<Viajero>();
       }
       public override void ActualizarViajero(Viajero viajero) 
       {
            viajero.viajeroEnFin= true;
            Puntos puntos = new Puntos();
            viajero.puntosDelViajero= puntos.monedasAPuntos(viajero);
            viajero.puntosDelViajero=puntos.bonosAPuntos(viajero);
       }
       public override void AgregarViajero(Viajero viajero)
       {
           
            if (this.viajeros.Count<this.cantViajeros)
            {
                this.viajeros.Add(viajero);
                this.ActualizarViajero(viajero);
            }
            else
            {
                //tirar excepcion de que se llegó al máximo de jugadores
            }
       }
    }
}