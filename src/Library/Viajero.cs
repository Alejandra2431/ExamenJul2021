namespace Library
{
    public class Viajero
    {
        //La cantidad de visitas a vada experiencia se aumenta en la clase de cada experiencia pero se guarda en el viajero
        public int cantAguasTermales;
        public int cantGranjas;
        public int cantMontañas;
        public int cantOceanos;
        public int puntosDelViajero;
        public int monedasDelViajero;
        public int bonosDelViajero;
        public int posicionEnCamino;
        public bool viajeroEnFin;
        
        public Viajero()
        {
            //solo son necesarias las cant de paisajes?? pq los
            //no paisajes no necesitan saber la cantidad?
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