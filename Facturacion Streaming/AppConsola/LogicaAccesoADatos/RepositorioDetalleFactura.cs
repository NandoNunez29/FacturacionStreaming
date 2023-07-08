using AppConsola.Vista;
using AppConsola.ModelosDeClase;
namespace AppConsola.LogicaAccesoADatos;

public class RepositorioDetalleFactura
{
protected List<DetalleFactura> detalles;

public RepositorioDetalleFactura(){
    detalles = new List<DetalleFactura>();
    }

    public void AgregarDetalle(DetalleFactura detalle){
    detalles.Add(detalle);
    }


    public bool BuscarDetalle(string Id){
        bool existe = false;
        foreach (var item in detalles)
        {            
            if(item.Id == Id){
                existe = true;
            }          
        }
        return existe;
    }
        
    
    }


    

     





