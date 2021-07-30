using System;
using Library;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Viajero viajero1 = new Viajero();
            Montaña montaña4 = new Montaña(1, null);
            Montaña montaña3 = new Montaña(1, montaña4);
            Montaña montaña2 = new Montaña(1, montaña3);
            Montaña montaña1 = new Montaña(1, montaña2);

            montaña1.AgregarViajero(viajero1);
            Console.WriteLine(viajero1.puntosDelViajero);
            montaña2.AgregarViajero(viajero1);
            Console.WriteLine(viajero1.puntosDelViajero);
            montaña3.AgregarViajero(viajero1);        
            Console.WriteLine(viajero1.puntosDelViajero);
            montaña4.AgregarViajero(viajero1);        
            Console.WriteLine(viajero1.puntosDelViajero);
            */

            Viajero viajero1 = new Viajero();
            Oceano oceano4 = new Oceano(1, null);
            Oceano oceano3 = new Oceano(1, oceano4);
            Oceano oceano2 = new Oceano(1, oceano3);
            Oceano oceano1 = new Oceano(1, oceano2);

            oceano1.AgregarViajero(viajero1);
            Console.WriteLine(viajero1.puntosDelViajero);
            oceano2.AgregarViajero(viajero1);
            Console.WriteLine(viajero1.puntosDelViajero);
            oceano3.AgregarViajero(viajero1);        
            Console.WriteLine(viajero1.puntosDelViajero);
            oceano4.AgregarViajero(viajero1);        
            Console.WriteLine(viajero1.puntosDelViajero);
        }
    }
}
