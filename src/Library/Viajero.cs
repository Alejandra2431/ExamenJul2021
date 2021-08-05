namespace Library
{
    /// <summary>
    /// Representa a los viajeros en el juego
    /// </summary>
    public class Viajero
    {
        //La cantidad de visitas a cada experiencia se aumenta en la clase de cada experiencia pero se guarda en el viajero
        /// <summary>
        /// Cantidad de visitas a una experiencia AguasTermales 
        /// </summary>
        /// <value>int</value>
        public int cantAguasTermales;
        /// <summary>
        /// Cantidad de visitas a una experiencia Granja 
        /// </summary>
        /// <value>int</value>
        public int cantGranjas;
        /// <summary>
        /// Cantidad de visitas a una experiencia Montaña 
        /// </summary>
        /// <value>int</value>
        public int cantMontañas;
        /// <summary>
        /// Cantidad de visitas a una experiencia Oceano 
        /// </summary>
        /// <value>int</value>
        public int cantOceanos;
        /// <summary>
        /// Puntos que acumula el viajero durante las experiencias 
        /// </summary>
        /// <value>int</value>
        public int puntosDelViajero;
        /// <summary>
        /// Monedas que acumula el viajero durante las experiencias 
        /// </summary>
        /// <value>int</value>
        public int monedasDelViajero;
        /// <summary>
        /// Bonos que acumula el viajero durante las experiencias 
        /// </summary>
        /// <value>int</value>
        public int bonosDelViajero;
        /// <summary>
        /// Posición del viajero en el camino 
        /// </summary>
        /// <value>int</value>
        public int posicionEnCamino;
        /// <summary>
        /// Indica si el viajero llegó a la experiencia Fin
        /// </summary>
        public bool viajeroEnFin;
        public Viajero()
        {
            cantAguasTermales= 0;
            cantGranjas= 0;
            cantMontañas= 0;
            cantOceanos= 0;
            puntosDelViajero= 0;
            monedasDelViajero= 0;
            bonosDelViajero= 0;
            posicionEnCamino= 0;
        }
        public void MoverseEnCamino()
        {
        }
    }
}