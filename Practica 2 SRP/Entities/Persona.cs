namespace Practica_2_SRP.Entities
{
    public class Persona
    {
        private string? nombre;
        private int edad;
        private string? correoElectronico;
        private string? direccion;

        // Métodos para acceder y modificar las propiedades
        public string ObtenerNombre()
        {
            return nombre;
        }

        public void EstablecerNombre(string value)
        {
            nombre = value;
        }

        public int ObtenerEdad()
        {
            return edad;
        }

        public void EstablecerEdad(int value)
        {
            edad = value;
        }

        public string ObtenerCorreoElectronico()
        {
            return correoElectronico;
        }

        public void EstablecerCorreoElectronico(string value)
        {
            correoElectronico = value;
        }

        public string ObtenerDireccion()
        {
            return direccion;
        }

        public void EstablecerDireccion(string value)
        {
            direccion = value;
        }


    }
}
