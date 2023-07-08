namespace AppConsola.ModelosDeClase;

public class DetalleFactura
{
    public string Id { get; set; } = "";
    public decimal Subtotal { get; set; }
    public decimal Total { get; set; }
    public int Cantidad { get; set; }      
    public decimal Descuento { get; set; }
    public Servicio Servicio { get; set; }
    public DateTime FechaActivacion { get; set; }
    public DateTime FechaCorte {get; set;}
    public int MesesSuscripcion { get; set;}


    public DetalleFactura(Servicio servicio,int cantidad, int mesesSuscripcion){
        Servicio = servicio;
        Cantidad = cantidad;        
        SetId();
        FechaActivacion = DateTime.Now;
        MesesSuscripcion = mesesSuscripcion;
        CalcularFechaCorte(); 
    }

    public void SetId(){
        Id += 1;
    }   

    public void CalcularFechaCorte(){
    FechaCorte = FechaActivacion.AddMonths(MesesSuscripcion);      
    }

    public void CalcularSubtotal(Cliente cliente){
        if(cliente.Tipo == "Mayorista"){
            Subtotal = Servicio.PrecioMayorista * Cantidad;
        }  else {
            Subtotal = Servicio.PrecioFinal* Cantidad;
        }
    }
    public void CalcularTotal(){
        Total = Subtotal - Descuento;
    }
    public void CalcularDescuento(){
        if (Cantidad >= 3){
            Descuento = Subtotal * CacularPorcentajeDescuento();
        } 
    }  

    public decimal CacularPorcentajeDescuento (){
        decimal PorcentajeDescuento = 0;
        if(MesesSuscripcion >= 6){
        PorcentajeDescuento = 0.15m;
        } else 
            if(MesesSuscripcion >= 3) {
                PorcentajeDescuento = 0.10m;
            }
            return PorcentajeDescuento;
    }

}
