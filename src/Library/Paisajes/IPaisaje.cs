namespace Library
{
    /// <summary>
    /// Representa la abstraccion de un paisaje
    /// </summary>
    public interface IPaisaje
    {
        /* 
            En esta interfaz para cumplir con el principio OCP (Open-Closed Principle), así se puede extender el código a traves de
            la implementación de la interfaz ICard, en el caso de que se quieran agregar más paisajes.
            Se cumple con el principio ISP (Interface Segregation Principle) porque al ser una interfaz pequeña se evita que las clases
            dependen de la interfaz tengan que implementar algo que no utilizan.
            También se cumple el principio DIP (Dependency Inversion Principle) para depender de una abstracción y no de una clase directamente. 
        */
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