using AppConsola.ModelosDeClase;
namespace AppConsola.LogicaAccesoADatos;


public class RepositorioCliente
{
    public List<Cliente> clientes {get; set;}  
    
    public RepositorioCliente(){
        clientes = new List<Cliente>();
    }

    public Cliente BuscarCliente(string cedula){
    
        foreach (var item in clientes)
        {
            if(item.Cedula == cedula){            
                
                return item;
            }
        }
        return new Cliente ("","","","","");
    }



    public void AgregarCliente(Cliente cliente){
    clientes.Add(cliente);
    }

    public void ListarClientes(){
        Console.Clear();
        Console.WriteLine($"LISTA DE CLIENTES");
        foreach (var item in clientes)
        {
            Console.WriteLine($"{item.Nombre}\t/\t{item.Cedula}\t/\t{item.Tipo}");
        }
    }

    public void InicializarClientesParaPrueba(){
        Cliente cliente = new Cliente("Diana","12345","abc@hotmail.com","3177874903","Mayorista");
        clientes.Add(cliente);
        Cliente cliente1 = new Cliente("Mandela","8888","abcde@hmail.com","666666","Final");
        clientes.Add(cliente1);
        Cliente cliente2 = new Cliente("Yecid","185485","abc@gmail.com","444444","Final");
        clientes.Add(cliente2);
        Cliente cliente3 = new Cliente("YJesus","185485","isd@gmail.com","555555","Final");
        clientes.Add(cliente3);
    }

}
