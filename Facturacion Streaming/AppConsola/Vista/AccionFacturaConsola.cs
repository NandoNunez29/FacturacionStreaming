using AppConsola.ModelosDeClase;
using AppConsola.LogicaAccesoADatos;
namespace AppConsola.Vista;

public class AccionFacturaConsola
{    
    public Factura factura { get; set; }   

    public AccionFacturaConsola(Cliente cliente){
        factura = new Factura(cliente);
    }
    public Factura CrearFactura(Cliente cliente){
        bool existe = cliente.Cedula == "";        
        if(existe!){
            AgregarDetalleFactura(cliente);                                

        }else{
            Console.WriteLine($"Cliente No existe.\nDESEA CREARLO S/N?");            
            char crear =  char.Parse(Console.ReadLine());
            if(crear =='S'){
                AccionClienteConsola accionClienteConsola = new AccionClienteConsola();
                cliente = accionClienteConsola.CrearCliente();
                CrearFactura(cliente);
            }    
        }
        factura.CalcularDescuento();
        factura.CalcularSubtotal();
        factura.CacularTotal();
        return factura;
    }

    public void AgregarDetalleFactura(Cliente cliente){
        char seguir = 'S';
        do{     
            RepositorioServicio repositorioServicio = new RepositorioServicio();
            repositorioServicio.ListarServicios();
            MenuGeneralConsola menuGeneralConsola = new MenuGeneralConsola();
            int opcion = menuGeneralConsola.OpcionMenuServicios();
            AccionServicioConsola accionServicioConsola = new AccionServicioConsola();         
            Servicio servicio = accionServicioConsola.ValidarServicio(opcion);            
            Console.WriteLine("Cantidad: ");
            int Cantidad= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Meses a Contratar: ");
            int Meses = Convert.ToInt16(Console.ReadLine());
            DetalleFactura detalle = new DetalleFactura(servicio,Cantidad,Meses);
            detalle.CalcularSubtotal(cliente);
            detalle.CalcularTotal();
            detalle.CalcularDescuento();            
            factura.Detalles.Add(detalle);               
            Console.WriteLine("Agregar otro servicio? S/N");
            seguir = Convert.ToChar(Console.ReadLine());
            char.ToUpper(seguir);
        }while(seguir == 'S');                
    }             
}



