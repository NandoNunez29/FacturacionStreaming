namespace AppConsola;

public class VistaConsula
{
 public DatosCorreo PedirDatos(){
    char seguir;
   
        Console.WriteLine("Digite Email:");     
        string email = Console.ReadLine();
        Console.WriteLine("Digite Asunto:");     
        string asunto = Console.ReadLine();
        Console.WriteLine("Digite Cuerpo del correo:");     
        string cuerpo = Console.ReadLine();
        DatosCorreo datosCorreo = new DatosCorreo(email,asunto,cuerpo);
        Console.WriteLine("Agregar otro correo?  S/N");
        char.ToUpper (seguir = char.Parse(Console.ReadLine())); 
        

        return datosCorreo;
    
     
}

}
