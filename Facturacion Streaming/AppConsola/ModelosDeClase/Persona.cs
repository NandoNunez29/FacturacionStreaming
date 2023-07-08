namespace AppConsola.ModelosDeClase;

public abstract class Persona
{
    public string Nombre { get; set;} = string.Empty;
    public String Cedula { get; set; } 
    public string Email { get; set;} = string.Empty;
    public string Telefono { get; set; }= string.Empty;


    public Persona( string nombre, string cedula, string email, string telefono){
        Nombre = nombre;
        Cedula = cedula;
        Email = email;
        Telefono = telefono;     
    }

   
   public void ActualizarEmail(string email){
    Email = email;
   }

   public void ActualizarTelefono(string telefono){
    Telefono = telefono;
   }
}
