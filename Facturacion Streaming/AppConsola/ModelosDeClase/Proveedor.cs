namespace AppConsola.ModelosDeClase;

public class Proveedor : Persona
{
    public string LinkPagina { get; set; } = "";
   public Proveedor(string nombre, string cedula, string email, string telefono, string linkPagina) : base(nombre, cedula, email,telefono)
    {
        LinkPagina = linkPagina;

    }
    public void ActualizarLink(string linkPagina){
        LinkPagina = linkPagina;
    }
}
