using System.Collections.Generic;
namespace Library
{
    public class Fin: Experiencia
    {
       private List<Viajero> viajerosEnFinal;
       public Fin(int maxViajeros, Experiencia sigExperiencia): base (maxViajeros, sigExperiencia)
       {
           List<Viajero> viajerosEnFinal= new List<Viajero>();
       }
       public override void ActualizarViajero(Viajero viajero) 
       {

       }
    }
}