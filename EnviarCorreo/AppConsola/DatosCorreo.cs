namespace AppConsola;

public class DatosCorreo
{
    public string Email {get; set;}
    public string Asunto {get; set;}
    public string Cuerpo {get; set;}

    public DatosCorreo(string email, string asunto, string cuerpo){
        Email = email;
        Asunto = asunto;
        Cuerpo = cuerpo;
    }

   
    
}
