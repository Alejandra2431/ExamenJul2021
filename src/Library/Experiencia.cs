using System.Collections.Generic;
namespace Library
{
    public abstract class Experiencia
    {
        private Experiencia proxExperiencia;
        private List<Viajero> viajeros;
        public int cantViajeros;
        public void AgregarViajero(Viajero viajero)
        {
            //COUNT EMPIEZA EN 1???
            if (viajeros.Count<this.cantViajeros)
            {
                viajeros.Add(viajero);
                this.ActualizarViajero(viajero);
            }
            else
            {
                proxExperiencia.AgregarViajero(viajero);
            }
            
        }
        public Experiencia(int cantViajeros, Experiencia experiencia)
        {
            this.cantViajeros= cantViajeros;
            this.proxExperiencia= experiencia;
            this.viajeros = new List<Viajero>();
        }

        public abstract void ActualizarViajero(Viajero viajero);

        

        
        //cuando es una experiencia con dos lugares el que llega primero va a la
        //posicion 0, y el siguiente a la 1 => se son los últimos 2, se mueve el
        //de la posicion 0
    }
}