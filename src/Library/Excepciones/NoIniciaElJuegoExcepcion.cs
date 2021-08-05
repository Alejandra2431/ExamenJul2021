using System;
namespace Library
{
    /// <summary>
    /// Representa un error al iniciar el juego
    /// </summary>
    public class NoIniciaElJuegoExcepcion : Exception
    {
        public NoIniciaElJuegoExcepcion(string mensaje) : base(mensaje)
        {
            
        }
    }
}