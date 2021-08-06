namespace Library
{
    /*
        Se aplica el patron expert en esta clase ya que es la experta en los datos de las aguas termales y en cómo hacer los cálculos de ellas.

    */
    /// <summary>
    /// AguasTermales representa la experiencia- no paisaje: AguasTermales
    /// </summary>
    public class AguasTermales: Experiencia
    {
        /// <summary>
        /// Bono por visitar AguasTermales
        /// </summary>
        /// <value>int</value>
        public int bonoXAguas;
        /// <summary>
        /// Devuleve el bono por visitar AguasTermales
        /// </summary>
        /// <returns>int</returns>
        public int GetBono()
        {
            return this.bonoXAguas;
        }
        public AguasTermales(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base(maxViajeros, sigExperiencia, posicionEnCamino)
        {
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        /// <param name="viajero"></param>
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantAguasTermales += 1;
            viajero.bonosDelViajero += CalcularBonos(viajero);
        } 
        /// <summary>
        /// Calcula los bonos que le corresponden al viajero por la visita a AguasTermales
        /// </summary>
        /// <param name="viajero"></param>
        /// <returns>int</returns>
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