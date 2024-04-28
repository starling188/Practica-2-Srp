using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_SRP.Interface
{
    public interface IEnviarMensajeCorreo
    {
        bool EnviarMensajeCorreos(string mensaje, string correo);

      
    }
}
