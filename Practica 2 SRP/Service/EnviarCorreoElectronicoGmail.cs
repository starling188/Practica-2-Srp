using Practica_2_SRP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_SRP.Service
{
    public class EnviarCorreoElectronicoGmail : IEnviarMensajeCorreo
    {

        public bool EnviarMensajeCorreos(string mensaje, string correo)
        {
            try
            {
                // Aquí se simula el envío del correo electrónico
                Console.WriteLine($"mensaje Enviado a: {correo}: {mensaje}");

                // Si el envío se realiza sin errores, retornar true
                return true;
            }
            catch (Exception ex)
            {
                // Si ocurre algún error en el envío, retornar false
                Console.WriteLine($"Error al enviar el correo electrónico: {ex.Message}");
                return false;
            }
        }
    }
}
