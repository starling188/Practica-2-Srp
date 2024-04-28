using Practica_2_SRP.Entities;
using Practica_2_SRP.Interface;


namespace Practica_2_SRP.Service
{
    public class ImprimirInformacionPersona : IImprimirDatos
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.ObtenerNombre()}");
            Console.WriteLine($"Edad: {persona.ObtenerEdad()}");
            Console.WriteLine($"Correo Electrónico: {persona.ObtenerCorreoElectronico()}");
            Console.WriteLine($"Dirección: {persona.ObtenerDireccion()}");
        }

    }
}
