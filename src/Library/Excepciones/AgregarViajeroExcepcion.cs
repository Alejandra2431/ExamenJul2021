using System;
namespace Library
{
    /// <summary>
    /// Representa un error en el estado del juego
    /// </summary>
    public class AgregarViajeroExcepcion : Exception
    {
        public AgregarViajeroExcepcion(string mensaje) : base(mensaje)
        {
            
        }
    }
}