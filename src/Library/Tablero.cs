using System.Collections.Generic;
using System;
namespace Library
{
    public class Tablero
    {
      private Comienzo comienzo;
      private List<Viajero> viajeros;
      public Tablero (List<Viajero> viajeros, Comienzo comienzoDelJuego)
        {
          this.viajeros= viajeros;
          this.comienzo= comienzoDelJuego;
          this.AgregarViajerosAlComienzo(viajeros, comienzoDelJuego);
        }
      private Random rand = new Random();
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
          //excepcion no se encontró comienzo
        }
      }
      public void Jugar()
      {
        bool juegoTerminado= true;
        if (viajeros != null)
        {
          foreach (Viajero viajero in viajeros)
          {
              if (viajero.viajeroEnFin == false)
              {
                juegoTerminado = false;
              }
          }
          if (!juegoTerminado)
          {
            Viajero viajeroAMover = viajeros[0];
            foreach (Viajero viajero in viajeros)
            {
              if (viajero.posicionEnCamino < viajeroAMover.posicionEnCamino)
              {
                viajeroAMover= viajero; 
              }
              else if (viajero.posicionEnCamino == viajeroAMover.posicionEnCamino)
              {
                //mover el que llegó primero a la experiencia 
              }
              MoverViajero(viajeroAMover);
            }
            foreach (Viajero viajero in viajeros)
            {
                MoverViajero(viajero);
            }
          }
          else 
          {
            foreach (Viajero viajero in viajeros)
            {
              //calcular puntos fianles de los viajeros con la clase Puntos
            }
          }
        }
        else
        {
          //EXCEPCIÓN??
        }
      }
    }
}


/*  foreach (Viajero viajero in viajeros)
      {
         MoverViajero(viajero);
      }*/