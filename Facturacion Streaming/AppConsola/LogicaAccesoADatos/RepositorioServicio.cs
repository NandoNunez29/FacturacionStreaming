using AppConsola.ModelosDeClase;
namespace AppConsola.LogicaAccesoADatos;

public class RepositorioServicio
{
    public List<Servicio> Servicios {get; set;}

    public RepositorioServicio(){
        Servicios = new List<Servicio>();
    }

    public void AgregarServicio(Servicio servicio){
    Servicios.Add(servicio);
    }

    public Servicio BuscarServicio(string nombre){
    
    foreach (var item in Servicios)
    {
        if(item.Nombre == nombre){
            return item;
        }
    }
    return new Servicio("",0,0,2023,4,10,2);
    }


public void ListarServicios(){
        Console.Clear();
        Console.WriteLine($"LISTA DE SERVICIOS");   
        int cont=1;   
        Console.WriteLine(Servicios[0].Nombre);
        cont++;
    }     
            
        
    

    public void InicializarServiciosParaPrueba(){
    Servicio servicio = new Servicio("Netflix",20000,23000,2023,07,30,2);
    Servicios.Add(servicio);
    Servicio servicio1 = new Servicio("Prime Video",4000,8000,2023,07,30,6);
    Servicios.Add(servicio1);
    Servicio servicio2 = new Servicio("Star Plus",4000,8000,2023,07,30,8);
    Servicios.Add(servicio2);
    Servicio servicio3 = new Servicio("Hbo Max",3000,7000,2023,07,30,8);
    Servicios.Add(servicio3);   
    }


}
