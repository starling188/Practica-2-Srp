using Practica_2_SRP.Service;
using Practica_2_SRP.Entities;
using Practica_2_SRP.Interface;

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.EstablecerNombre("oscar");
        persona.EstablecerDireccion("San Pedro");
        persona.EstablecerEdad(34);
        persona.EstablecerCorreoElectronico("Oscar2gmail.com");


        IImprimirDatos imprimir = new ImprimirInformacionPersona();
        imprimir.ImprimirDatos(persona);
        Console.WriteLine($"\n");
       


        var mensaje = "hola este es un mensaje para tu correo";
        IEnviarMensajeCorreo enviarCorreoGmail = new EnviarCorreoElectronicoGmail();
        enviarCorreoGmail.EnviarMensajeCorreos(mensaje, persona.ObtenerCorreoElectronico());
        
       
    }
}