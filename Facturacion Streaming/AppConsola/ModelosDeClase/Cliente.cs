namespace AppConsola.ModelosDeClase;

public class Cliente : Persona 
{
    public string Tipo { get; set; } = string.Empty; 

    public Cliente(string nombre, string cedula, string email, string telefono, string tipo) : base(nombre, cedula, email,telefono)
    {
        Tipo = tipo;

    }
}
