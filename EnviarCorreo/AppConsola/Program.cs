using System.Net;
using System.Net.Mail;
using AppConsola;


RepositorioDatosCorreo repositorioDatosCorreo = new RepositorioDatosCorreo();
repositorioDatosCorreo.InicializarParaPrueba();

string correoBase = "teacher.devzeros@gmail.com";
SmtpClient cliente = new SmtpClient ("smtp.gmail.com", 587);
cliente.EnableSsl = true;
cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
cliente.UseDefaultCredentials = false;
cliente.Credentials = new NetworkCredential (correoBase, "gbrracjxocsfieuu");

VistaConsula vistaConsula = new VistaConsula();
DatosCorreo emailUsuario = vistaConsula.PedirDatos();
repositorioDatosCorreo.AgregarCorreos(emailUsuario);
foreach (var item in repositorioDatosCorreo.correos)
{
MailMessage email = new MailMessage (
from: correoBase,
item.Email,
item.Asunto,
item.Cuerpo
);
email.IsBodyHtml = false;
cliente.Send(email);
}


