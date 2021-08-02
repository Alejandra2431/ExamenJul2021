using System.Collections.Generic;
namespace Library
{
    public class Comienzo: Experiencia
    {
        private List<Viajero> viajerosEnJuego;
        public Comienzo(int maxViajeros, Experiencia sigExperiencia): base (maxViajeros, sigExperiencia)
        {
            List<Viajero> viajerosEnJuego= new List<Viajero>();

        }
        public override void ActualizarViajero(Viajero viajero)
        {
            this.cantViajeros= 4; 
        }
    }
}
