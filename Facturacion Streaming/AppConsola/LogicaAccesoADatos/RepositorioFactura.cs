using AppConsola.ModelosDeClase;
namespace AppConsola.LogicaAccesoADatos;

public class RepositorioFactura
{
    protected List<Factura> facturas {get; set;} 

    public RepositorioFactura (){
        facturas = new List<Factura>();
    }

    public void AgregarFactura(Factura factura){
    facturas.Add(factura);
    }

   

    public void ListarFactura(){
        Console.Clear();
        Console.WriteLine($"F A C T U R A S");
        foreach (var item in facturas)
        {
            Console.WriteLine($"{item.Id}\t/\t{item.Cliente.Nombre}");
            foreach (var item1 in item.Detalles)
            {
                Console.WriteLine($"{item1.Id}/{item1.Servicio}/{item.Total}");
            }
            Console.WriteLine($"{item.Subtotal}\t/\t{item.Total}");
        }   
    }

    public bool BuscarFactura(string Id){
        bool existe = false;
        foreach (var item in facturas)
        {            
            if(item.Id == Id){
                existe = true;
            }          
        }
    return existe;
    }

    


}
