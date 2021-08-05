namespace Library
{
    /// <summary>
    /// Representa la abstraccion de un paisaje
    /// </summary>
    public interface IPaisaje
    {
        /// <summary>
        /// Representa la operacion necesaria para clacular las monedas que le corresponde adquirir
        /// </summary>
        /// <returns>int</returns>
        int Monedas();
        /// <summary>
        /// Representa la operacion necesaria para calcular el puntaje que le corresponde adquirir
        /// </summary>
        /// <returns>int</returns>
        int CalcularPuntaje(int cant);
    }
}