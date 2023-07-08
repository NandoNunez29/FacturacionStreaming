namespace AppConsola.ModelosDeClase;
using System;
public class Servicio
{
    public string Id { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public decimal PrecioMayorista { get; set; } = 0;
    public decimal PrecioFinal { get; set; } = 0;
    public DateTime FechaVencimiento { get; set; }   
    public decimal PorcentajeDescuento {get; protected set;}
    public int Stock { get; protected set; }


    public  Servicio(string nombre, decimal precioMayorista, decimal precioFinal, int AA, int MM, int DD, int stock){
        Nombre = nombre;
        PrecioMayorista = precioMayorista;
        PrecioFinal = precioFinal;
        FechaVencimiento = new DateTime(AA,MM,DD);
        SetId();
        Stock = stock;      
    }

    public void SetId(){
        var randon = new Random ();
        string aux = Convert.ToString(randon.Next(0,999));
    }
}




