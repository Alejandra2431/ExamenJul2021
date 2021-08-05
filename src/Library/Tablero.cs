using System.Collections.Generic;
using System;
namespace Library
{
    /// <summary>
    /// Tablero representa el camino/tablero
    /// </summary>
    public class Tablero
    {
      /// <summary>
      /// Primera experiencia del juego
      /// </summary>
      private Comienzo comienzo;
      /// <summary>
      /// Lista de viajeros
      /// </summary>
      /// <value>List<Viajero></value>
      private List<Viajero> viajeros;
      public Tablero (List<Viajero> viajeros, Comienzo comienzoDelJuego)
        {
          this.viajeros= viajeros;
          this.comienzo= comienzoDelJuego;
          this.AgregarViajerosAlComienzo(viajeros, comienzoDelJuego);
        }
      private Random rand = new Random();
      /// <summary>
      /// Mueve al viajero a una nueva experiencia lo remueve de la anterior 
      /// </summary>
      /// <param name="viajero"></param>
      public void MoverViajero(Viajero viajero)
      {
        int moverAPosicion = rand.Next(1, 7) + viajero.posicionEnCamino;
        Experiencia experienciaActual = comienzo;
        while (experienciaActual != null)
        {  //busca en el tablero
            if (experienciaActual.posicionEnCamino == moverAPosicion)
            {
                experienciaActual.AgregarViajero(viajero);
            }
            else
            { //chequea si no es el final del camino
              if (experienciaActual.proxExperiencia != null)
              {
                experienciaActual = experienciaActual.proxExperiencia;
              }
              else
              { //está en la última experiencia (final)
                experienciaActual.AgregarViajero(viajero);
              } //remover viajero de su posicion anterior
              if (experienciaActual.posicionEnCamino== viajero.posicionEnCamino)
              {
                experienciaActual.RemoverViajero(viajero);
              }
            }
        }
      }
      /// <summary>
      /// Agrega viajeros a la primera experiencia, el comienzo
      /// </summary>
      /// <param name="viajeros"></param>
      /// <param name="comienzo"></param>
      private void AgregarViajerosAlComienzo(List<Viajero> viajeros, Comienzo comienzo)
      {
        if (comienzo != null)
        {
          foreach (Viajero viajero in viajeros)
          {
            comienzo.AgregarViajero(viajero);    
          }   
        }
        else 
        {
          throw new NoIniciaElJuegoExcepcion("No se encontró la Experiencia Comienzo");
        }
      }
      /// <summary>
      /// Indica qué viajero corresponde mover
      /// </summary>
      /// <param name="viajeros"></param>
      public Viajero viajeroAMover(List<Viajero> viajeros) 
      {
        Viajero viajeroAMover = null;
        foreach (Viajero viajero in viajeros)
        {
            if (viajero.viajeroEnFin)
            {
                continue;
            }
            if (viajeroAMover== null)
            {
              viajeroAMover= viajero;
            }
            else
            {
              if (viajero.posicionEnCamino<=viajeroAMover.posicionEnCamino)
              {
                  viajeroAMover= viajero;
              }
            }
        }
        return viajeroAMover;
      }
      /// <summary>
      /// Continúa el juego si este no terminó
      /// </summary>
      public void Jugar()
      {
        if (viajeros==null)
        {
          throw new NoIniciaElJuegoExcepcion("Lista de viajeros vacía");
        }
        bool juegoTerminado= false;
        while (!juegoTerminado)
        {
          Viajero moverAlViajero= viajeroAMover(viajeros);
          MoverViajero(moverAlViajero);
          juegoTerminado=JuegoFinalizado(viajeros);
        }
      }
      /// <summary>
      /// Retorna si todos los jugadores terminaron el juego
      /// </summary>
      /// <param name="viajeros"></param>
      /// <returns></returns>
      private bool JuegoFinalizado(List<Viajero> viajeros)
      {
        bool juegoFinalizado=true;
        foreach (Viajero viajero in viajeros)
        {
          if (!viajero.viajeroEnFin)
          {
            juegoFinalizado=false;
            break;
          }
        }
        return juegoFinalizado;
      }
    }
}
