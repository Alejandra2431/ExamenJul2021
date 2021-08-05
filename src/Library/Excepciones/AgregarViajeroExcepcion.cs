using System;
namespace Library
{
    /// <summary>
    /// Representa un error al agregar un viajero
    /// </summary>
    public class AgregarViajeroExcepcion : Exception
    {
        public AgregarViajeroExcepcion(string mensaje) : base(mensaje)
        {
            
        }
    }
}