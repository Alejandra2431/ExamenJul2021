namespace Library
{
    public class AguasTermales: Experiencia
    {
        public int bonoXAguas;
        public int GetBono()
        {
            return this.bonoXAguas;
        }
        
        public AguasTermales(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base(maxViajeros, sigExperiencia, posicionEnCamino)
        {
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantGranjas += 1;
            viajero.bonosDelViajero += CalcularBonos(viajero);
        } 
        public int CalcularBonos(Viajero viajero)
        {
            bonoXAguas= 0;
            if (viajero.cantAguasTermales == 1)
            {
                bonoXAguas += 0;
            }
            else if (viajero.cantAguasTermales % 2 == 0)
            {
                bonoXAguas += viajero.cantAguasTermales / 2 ;
            }
            else
            {
                bonoXAguas += (viajero.cantAguasTermales - 1) / 2 ;
            }
            return bonoXAguas;
        }
    }
}