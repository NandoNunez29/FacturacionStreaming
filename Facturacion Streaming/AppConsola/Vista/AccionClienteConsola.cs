using AppConsola.ModelosDeClase;
using AppConsola.LogicaAccesoADatos;
namespace AppConsola.Vista;

public class AccionClienteConsola
{
    public Cliente CrearCliente(){
        RepositorioCliente respositorioCliente = new RepositorioCliente();
        Console.WriteLine("Cedula: ");
        string cedula = Console.ReadLine();
        Cliente cliente = respositorioCliente.BuscarCliente(cedula);
        if(cliente.Cedula != cedula){        
            Console.WriteLine("Nombre Completo: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email= Console.ReadLine();
            Console.WriteLine("Telefono: ");
            string telefono= Console.ReadLine();
            string tipo = ObtenerTipoCliente();
            Console.WriteLine("Cliente Creado con Exito!");
            return new Cliente(nombre, cedula, email, telefono,tipo);
        } else{
            Console.WriteLine("Cliente YA EXISTE!");
            return new Cliente("","","","","");
        }     
            
    }

    public string ObtenerTipoCliente(){
        string TipoCliente = string.Empty;
        Console.WriteLine("TIPO DE CLIENTE: \n1. Mayorista.\n2. Cliente Final.");
        int tipo = int.Parse(Console.ReadLine());

        switch (tipo)
        {
            case 1:  TipoCliente = "Mayorista";
                break;
                case 2: TipoCliente = "Final";
                break;
            default: { 
                Console.WriteLine("Valor fuera de rango, intenta de nuevo ");
                ObtenerTipoCliente();
                break;
            }
        }
        return TipoCliente;
    }  

    public Cliente ValidarCliente(){
        
        Console.WriteLine("Cedula Cedula: ");
        string cedula = Console.ReadLine();
        RepositorioCliente respositorioCliente = new RepositorioCliente();
        return respositorioCliente.BuscarCliente(cedula);     
    }

}
