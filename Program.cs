using System;
using Jugadores;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        { 
          Jugador jug1 = new Jugador("Pepe", 30, true);
          Jugador jug2 = new Jugador("Pepe1", 20);
          Jugador jug3 = new Jugador("Pepe2", 30, true);

          Console.WriteLine(jug2.IsActivo());
        }
    }
}
