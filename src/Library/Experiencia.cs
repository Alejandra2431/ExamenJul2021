using System.Collections.Generic;
namespace Library
{
    public abstract class Experiencia
    {
        public Experiencia proxExperiencia {get; private set;}
        public List<Viajero> viajeros;
        public int cantViajeros;
        public int posicionEnCamino;
        public virtual void AgregarViajero(Viajero viajero)
        {
            if (viajeros.Count<this.cantViajeros)
            {
                viajeros.Add(viajero);
                viajero.posicionEnCamino =this.posicionEnCamino;
                this.ActualizarViajero(viajero);
            }
            else
            {
                if (proxExperiencia!= null) 
                {
                    proxExperiencia.AgregarViajero(viajero);
                }
                else
                {
                    //tirar excepcion
                }
            } 
        }
        public void RemoverViajero(Viajero viajero)
        {
            this.viajeros.Remove(viajero);
        }
        public Experiencia(int cantViajeros, Experiencia experiencia, int posicionEnCamino)
        {
            this.cantViajeros= cantViajeros;
            this.proxExperiencia= experiencia;
            this.viajeros= new List<Viajero>();
            this.posicionEnCamino= posicionEnCamino; 
        }
        public abstract void ActualizarViajero(Viajero viajero);

        
        
        //cuando es una experiencia con dos lugares el que llega primero va a la
        //posicion 0, y el siguiente a la 1 => se son los últimos 2, se mueve el
        //de la posicion 0
    }
}