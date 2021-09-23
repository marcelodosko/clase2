using System.Collections.Generic;
namespace Jugadores
{
  public class Jugador {
    public string Name { get; set; }
    public int Edad { get; set; }
    public bool Activo { get; set; }

    public List<Arma> Armas { get; set; }
    public List<Escudo> Escudos { get; set; }

    public Jugador(string name, int edad, List<Arma> armas, List<Escudo> escudos, bool activo = false) {
      Name = name;
      Edad = edad;
      Activo = activo;
      Armas = armas;
      Escudos = escudos;
    }

    public string IsActivo() { 
      return this.Activo ? "Jugador Activo" : "Jugador necesita activar su cuenta";
    }

  }
  public class Arma {
    public string Name { get; set; }
    public int Balas { get; set; }

    public Arma(string Name, int Balas) {
      this.Name = Name;
      this.Balas = Balas;
    }

    
  }
  public class Escudo {
    public string Name { get; set; }
    public int Porcentaje { get; set; }

    public string Test { get; set; }

    public Escudo(string Name, int Porcentaje, string Test) {
      this.Name = Name;
      this.Porcentaje = Porcentaje;
      this.Test = Test;
    }

    
  }
}
