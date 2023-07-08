using AppConsola.LogicaAccesoADatos;
using AppConsola.ModelosDeClase;
namespace AppConsola.Vista;


public class AccionServicioConsola
{
    public Servicio CrearServicio(){
        Console.WriteLine("Nombre de la plataforma: ");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Precio para Mayorista: ");
        decimal PrecioMayorista = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Precio para Cliente final: ");
        decimal precioClienteFinal = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite fecha de Vencimiento  AA MM DD");
        int AA = Convert.ToInt32(Console.ReadLine());
        int MM = Convert.ToInt32(Console.ReadLine());
        int DD = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Servicio Creado con Exito!");

        return new Servicio(Nombre, PrecioMayorista, precioClienteFinal, AA,MM,DD,9);
    }   

    public Servicio ValidarServicio(int opcion){
        string NombreServicio = string.Empty;
        bool seguir = false;
        do{
                switch (opcion)
            {
                case 1:{
                    NombreServicio = "Netflix";
                    break;               
                }
                    
                case 2:{
                    NombreServicio = "Prime Video";
                    break;
                    
                }
                    
                case 3:{
                    NombreServicio = "Hbo Max";
                    break;                
                }
                case 4:{
                    NombreServicio = "Star Plus";
                    break;                
                }
                    
                default:{
                    Console.WriteLine("OPCION FUERA DE RANGO");
                    seguir = true;
                    break;
                }              
            }
        }while(seguir);    
        RepositorioServicio repositorioServicio = new RepositorioServicio();
        return repositorioServicio.BuscarServicio(NombreServicio);        
    }


}
