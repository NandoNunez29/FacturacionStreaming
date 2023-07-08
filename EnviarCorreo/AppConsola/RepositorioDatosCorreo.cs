namespace AppConsola;

public class RepositorioDatosCorreo
{
    public List<DatosCorreo> correos;

    public RepositorioDatosCorreo(){
        correos = new List<DatosCorreo>();
    }

    public void AgregarCorreos(DatosCorreo datosCorreo){
        correos.Add(datosCorreo);
    }

    public void InicializarParaPrueba(){
    DatosCorreo datosCorreo = new DatosCorreo("spammer007.noreply@gmail.com","OnlyFans","Primo ajuiciese");
    correos.Add(datosCorreo);
    DatosCorreo datosCorreo1 = new DatosCorreo("yenirozzo@gmail.com","la reina del bitcoins","Gasta algo");
    correos.Add(datosCorreo1);
    DatosCorreo datosCorreo2 = new DatosCorreo("hernando.nunez@school.devzeros.com","HOla","Buenas");
    correos.Add(datosCorreo2);
    }


}
