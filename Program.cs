using Jugadores;
using System;
using System.Collections.Generic;

namespace clase2
{
  class Program
    {
        static void Main(string[] args)
        { 
          Arma arma1 = new Arma("Cañon Laser", 100);
          Arma arma2 = new Arma("Misil", 100);

          List<Arma> Armas = new List<Arma>() {arma1, arma2};

          Arma arma3 = new Arma("Pistola", 20);
          Armas.Add(arma3);

          Escudo esc1 = new Escudo("escudo1", 100, "test");
          Escudo esc2 = new Escudo("escudo2", 100, "test");
          Escudo esc3 = new Escudo("escudo3", 100, "test");
          Escudo esc4 = new Escudo("escudo4", 100, "test");

          List<Escudo> Escudos1 = new List<Escudo>() {esc1, esc2, esc3, esc4};

          Jugador jug1 = new Jugador("Pepe", 30, Armas, Escudos1);


          foreach(Escudo escudo in Escudos1) {
            Console.WriteLine(escudo.Name);
          }
          Console.WriteLine("Terminó Foreach");

          for(int i = 0; i < Escudos1.Count; i++) { 
              Console.WriteLine(Escudos1[i].Name);
              i++;
          }
          
        }
    }
}
