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
           foreach (Viajero viaj in viajerosEnFinal)
           {
            
           }
       }
    }
}