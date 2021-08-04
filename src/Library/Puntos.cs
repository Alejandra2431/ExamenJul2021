
namespace Library
{
    public class Puntos
    {
        public Puntos()
        {

        }

        public int monedasAPuntos(Viajero viajero)
        {
            if (viajero.monedasDelViajero<=6)
            {
                viajero.puntosDelViajero+= 2;
            }
            else if (viajero.monedasDelViajero == 9)
            {
                viajero.puntosDelViajero+=  4;
            }
            else
            {
                viajero.puntosDelViajero+= 6; 
            }
            return viajero.puntosDelViajero;
        }
        public int bonosAPuntos(Viajero viajero)
        {
            if (viajero.bonosDelViajero<=10)
            {
                viajero.puntosDelViajero+= 5;
            }
            else if (viajero.bonosDelViajero == 15)
            {
                viajero.puntosDelViajero+= 8;
            }
            else
            {
                viajero.puntosDelViajero+= 10; 
            }
            return viajero.puntosDelViajero;
        }
    }
}