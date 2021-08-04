using System;
namespace Library
{
    /// <summary>
    /// Representa un error en el estado del juego
    /// </summary>
    public class NoIniciaElJuegoExcepcion : Exception
    {
        public NoIniciaElJuegoExcepcion(string mensaje) : base(mensaje)
        {
            
        }
    }
}