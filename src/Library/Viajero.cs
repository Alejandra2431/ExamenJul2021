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
        public int posicionEnCamino{get; set;}
        
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
/*
        public void GuardarVisitas()
        {
            if this.
        }*/

        public void MoverseEnCamino()
        {

        }

/*
        public int MonedasDelViajero()
        {
            return cantMontañas+cantOceanos+ OBJETOgRANJA.GetMonedas() * cantGranjas; 
        }

        public int BonosDelViajero()
        {
            return cantAguasTermales * OBJETOaGUAS.bonoXAguas;
        }
        

        private int monedasAPuntos()
        {
            if (MonedasDelViajero()<=6)
            {
                puntosDelViajero= puntosDelViajero + 2;
            }
            else if (MonedasDelViajero() == 9)
            {
                puntosDelViajero= puntosDelViajero + 4;
            }
            else
            {
                puntosDelViajero= puntosDelViajero + 6; 
            }
            return puntosDelViajero;
        }

        private int bonosAPuntos()
        {
            if (BonosDelViajero()<=10)
            {
                puntosDelViajero= puntosDelViajero + 5;
            }
            else if (BonosDelViajero() == 15)
            {
                puntosDelViajero= puntosDelViajero + 8;
            }
            else
            {
                puntosDelViajero= puntosDelViajero + 10; 
            }
            return puntosDelViajero;
        }
        */
    }
}