using AppConsola.LogicaAccesoADatos;
using AppConsola.ModelosDeClase;


namespace AppConsola.Vista
{
    public class MenuGeneralConsola
    {  
    
        public void MostrarMenu(){        
            Console.WriteLine($"Factura de Ventas Streaming\n");
            Console.WriteLine($"1. Crear Factura.\n2. Crear Cliente.\n3. Crear Servicio.\n4. Listar Clientes.\n5. Listar Servicios.\n6.Listar Facturas\n9. Salir.");                   
        }

        public int ObtenerOpcionMenuGeneral(){
            int opcion = int.Parse(Console.ReadLine());
            //VALIDAR OPCIONES
            return opcion;
        }

     
        public int OpcionMenuServicios(){
            return int.Parse(Console.ReadLine());
        }

        
    }

}