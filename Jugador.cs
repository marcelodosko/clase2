using System.Collections.Generic;
namespace Jugadores
{
  public class Jugador {
    public string Name { get; set; }
    public int Edad { get; set; }
    public bool Activo { get; set; }

    public List<Arma> Armas { get; set; }

    public Jugador(string Name, int Edad, List<Arma> Armas, bool Activo = false) {
      this.Name = Name;
      this.Edad = Edad;
      this.Activo = Activo;
      this.Armas = Armas;
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
}
