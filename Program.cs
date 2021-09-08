using Jugadores;
using System.Collections.Generic;

namespace clase2
{
  class Program
    {
        static void Main(string[] args)
        { 
          Arma arma1 = new Arma("Cañon Laser", 100);
          Arma arma2 = new Arma("Misil", 100);
          Arma arma3 = new Arma("Pistola", 20);

          List<Arma> Armas = new List<Arma>() {arma1, arma2};

          Armas.Add(arma3);

          Jugador jug1 = new Jugador("Pepe", 30, Armas, true);


          foreach(Arma arma in Armas) {

          }

          for (int i = 0; i < Armas.Count; i++)
          {
            
          }
          
        }
    }
}
