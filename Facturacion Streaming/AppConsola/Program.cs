
using AppConsola.Vista;
using AppConsola.ModelosDeClase;
using AppConsola.LogicaAccesoADatos;

//INICIAZAMOS CON VALORES ESTANDAR UNA LISTA CLIENTES Y OTRA LISTA SERVICIOS PARA PODER PROBAR EL CODIGO
RepositorioCliente repositorioCliente = new RepositorioCliente();
repositorioCliente.InicializarClientesParaPrueba();
RepositorioServicio repositorioServicio = new RepositorioServicio();
repositorioServicio.InicializarServiciosParaPrueba();
RepositorioFactura repositorioFactura = new RepositorioFactura();
RepositorioDetalleFactura repositorioDetalle = new RepositorioDetalleFactura();

bool Seguir = false;
do{
    MenuGeneralConsola menuGeneralConsola = new MenuGeneralConsola();
    menuGeneralConsola.MostrarMenu();
    int opcion = menuGeneralConsola.ObtenerOpcionMenuGeneral();
    EjecutarAccion(opcion);

    void EjecutarAccion(int opcion){
    switch (opcion)
        {
            case 1:
            {
                AccionClienteConsola accionClienteConsola = new AccionClienteConsola();
                Cliente cliente = accionClienteConsola.ValidarCliente();
                AccionFacturaConsola accionFacturaConsola = new AccionFacturaConsola(cliente);
                Factura factura = accionFacturaConsola.CrearFactura(cliente);
                repositorioFactura.AgregarFactura(factura);       
                Seguir =true;
                break;
            }
            case 2:
            {
                AccionClienteConsola accionClienteConsola = new AccionClienteConsola();
                Cliente cliente = accionClienteConsola.CrearCliente();
                repositorioCliente.AgregarCliente(cliente);
                Seguir =true;
                break;
            }
            case 3:
            {
                AccionServicioConsola accionServicioConsola = new AccionServicioConsola();
                Servicio servicio = accionServicioConsola.CrearServicio();
                repositorioServicio.AgregarServicio(servicio);
                Seguir =true;
                break;
            }

            case 4:
            {
                repositorioCliente.ListarClientes();
                Seguir =true;
                break;
            }

            case 5:
            {
                repositorioServicio.ListarServicios();
                Seguir =true;
                break;
            }

            case 6:
            {
                repositorioFactura.ListarFactura();
                Seguir =true;
                break;
            }

            case 9:
            {
                Seguir =false;
                break;
            }
            default:
            Seguir =true;
                break;
        }
    }

    
}while(Seguir);
Console.ReadKey();
    