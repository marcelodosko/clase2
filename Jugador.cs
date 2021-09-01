namespace Jugadores
{
  public class Jugador {
    public string Name { get; set; }
    public int Edad { get; set; }

    public bool Activo { get; set; }

    public Jugador(string Name, int Edad, bool Activo = false) {
      this.Name = Name;
      this.Edad = Edad;
      this.Activo = Activo;
    }

    public string IsActivo() { 
      return this.Activo ? "Jugador Activo" : "Jugador necesita activar su cuenta";
    }

  }
}