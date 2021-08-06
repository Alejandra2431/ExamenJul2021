
namespace Library
{
    /// <summary>
    /// Representa el cálculo del los puntos totales
    /// </summary>
    public class Puntos
    {
        public Puntos()
        {

        }
        /// <summary>
        /// Calcula la cantidad de puntos que le corresponden al viajero según cuántas monedas obtuvo
        /// </summary>
        /// <param name="viajero"></param>
        public int MonedasAPuntos(Viajero viajero)
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
        /// <summary>
        /// Calcula la cantidad de puntos que le corresponden al viajero según cuántos bonos obtuvo
        /// </summary>
        /// <param name="viajero"></param>
        public int BonosAPuntos(Viajero viajero)
        {
            if (viajero.bonosDelViajero<=2)
            {
                viajero.puntosDelViajero+= 5;
            }
            else if (viajero.bonosDelViajero == 3)
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