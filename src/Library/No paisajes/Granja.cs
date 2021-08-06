namespace Library
{
    /*
        Se aplica el patron expert en esta clase ya que es la experta en los datos de las granjas y cómo hacer los cálculos de ellas.
        
    */
    /// <summary>
    /// Granja representa la experiencia- no paisaje: Granja
    /// </summary>
    public class Granja: Experiencia
    {
        /// <summary>
        /// Valor para el cálculo de monedas
        /// </summary>
        /// <value>int</value>
        private int aumentarMonedas;
        /// <summary>
        /// Monedas a sumar a monedasDelViajero
        /// </summary>
        /// <value>int</value>
        private int sumarMonedas;
        public Granja(int maxViajeros, Experiencia sigExperiencia, int posicionEnCamino): base(maxViajeros, sigExperiencia, posicionEnCamino)
        {
        }
        /// <summary>
        /// Actualiza la información del viajero
        /// </summary>
        /// <param name="viajero"></param>
        public override void ActualizarViajero(Viajero viajero)
        {
            viajero.cantGranjas += 1;
            viajero.monedasDelViajero += CalcularMonedas(viajero);
        }
        //Por cada visita a una granja se le da en monedas, el doble de la cantidad de visitas
        /// <summary>
        /// Calcula las monedas que le corresponden al viajero por la visita a la experiencia Granja
        /// </summary>
        /// <param name="viajero"></param>
        /// <returns>int</returns>
        public int CalcularMonedas(Viajero viajero)
        {
            aumentarMonedas= 2;
            sumarMonedas = aumentarMonedas * viajero.cantGranjas;
            return sumarMonedas;
        }
    }
}
