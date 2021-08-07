using System.Collections.Generic;
namespace Library
{
    /*
        En esta clase se aplica el patron polimorfismo, el programa es capaz de utilizar diferentes 
        experiencias que implementen esta clase abstracta Experiencia. Si se decide crear otro paisaje/no paisaje
        (Ejemplo Volcán) y utilizar esta clase solo es necesario crearla y que ella implemente 
        esta clase abstracta.

        Experiencia permite cumplir con el principio OCP (Open-Closed Principle), así se puede extender el código a traves de
        la implementación de ella, en el caso de que se quieran agregar más paisajes/no paisajes.

        Permite aplicar el principio DIP (Dependency inversion principle) debido a que es una abstraccion
        y las experiencias van a depender de ella y no de una clase directamente.

        También cumple con el patrón Chain of Responsibility, a cada objeto de la clase Experiencia se le asocia otro objeto de la misma clase
        que es una experiencia siguiente. Cada experiencia tiene su propio método para agregar viajeros, y cuando una está llena le delega
        a la siguiente que lo agregue. Cada experiencia recive una solicitud y decide si la procesa o si la pasa al siguiente manejador
        de la cadena.
    */
    /// <summary>
    /// Representa la abstraccion de una experiencia
    /// </summary>
    public abstract class Experiencia
    {
        /// <summary>
        /// Próxima experiencia a la que va el viajero a moverse
        /// </summary>
        public Experiencia proxExperiencia {get; private set;}
        /// <summary>
        /// Lista de viajeros
        /// </summary>
        /// <value>List<Viajero></value>
        public List<Viajero> viajeros;
        /// <summary>
        /// Cantidad de Viajeros
        /// </summary>
        /// <value>int</value>
        public int cantViajeros;
        /// <summary>
        /// Posición del viajero en el camino
        /// </summary>
        /// <value>int</value>
        public int posicionEnCamino;
        public Experiencia(int cantViajeros, Experiencia experiencia, int posicionEnCamino)
        {
            this.cantViajeros= cantViajeros;
            this.proxExperiencia= experiencia;
            this.viajeros= new List<Viajero>();
            this.posicionEnCamino= posicionEnCamino;
            if (posicionEnCamino<=0)
            {
                throw new NoIniciaElJuegoExcepcion("La posición no puede ser negativa o cero");
            } 
        }
        /// <summary>
        /// Agrega un viajero a la experiencia si se cumple la condición
        /// </summary>
        /// <param name="viajero"></param>
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
                    throw new AgregarViajeroExcepcion("No hay próxima experiencia, el viajero llegó al final");
                }
            } 
        }
        /// <summary>
        /// Quita de la experiencia al viajero que se mueve a otra experiencia
        /// </summary>
        /// <param name="viajero"></param>
        public void RemoverViajero(Viajero viajero)
        {
            this.viajeros.Remove(viajero);
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        /// <param name="viajero"></param>
        public abstract void ActualizarViajero(Viajero viajero);
    }
}