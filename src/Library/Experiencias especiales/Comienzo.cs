using System.Collections.Generic;
namespace Library
{
    public class Comienzo: Experiencia
    {
        public Comienzo(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base (maxViajeros, sigExperiencia, posicionEnCamino)
        {
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.posicionEnCamino =this.posicionEnCamino;
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
                throw new AgregarViajeroExcepcion("Se agregó la máxima cantidad de viajeros posible");
            }
        }
    }
}