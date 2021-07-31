namespace Library
{
    public class AguasTermales: Experiencia
    {
        public int bonoXAguas;
        public int GetBono()
        {
            return this.bonoXAguas;
        } // Llamar a este metodo cuando el viajero llega a una experiencia de tipo aguasTermailes para sumarle 3 a moneda
        
        public AguasTermales(int maxViajeros, Experiencia experiencia): base(maxViajeros, sigExperiencia)
        {
        }
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantGranjas += 1;
            viajero.bonosDelViajero += CalcularBonos(viajero);
        }
        //El bono por pasar por AguasTermales es igual a la cantidad de de visitas a AguasTermales
        //dividido 2, si la cant de visitas es 1 se da 0 bonos, si la cant de 
        //visitas es impar se da bonos= a la (cant de visitas menos 1) dividido 2 
        //TERMINAAAAR--------------------------------------------
        public int CalcularBonos(Viajero viajero)
        {
            bonoXAguas= 0;
            if (viajero.cantAguasTermales !=1)
            {
                bonoXAguas= viajero.cantAguasTermales/ 2;
            }
            else
            {
                bonoXAguas= 0;
            }
            return bonoXAguas;
        }
        
    }
}*/