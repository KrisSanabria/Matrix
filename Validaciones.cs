namespace EjemploRelevamiento
{
    public static class Validaciones
    {
       
        public static void ValidarPeso (double peso)
        {
            if ( peso < = 0)
            throw new ArgumentException ("El peso debe ser mayor a 0");
        }
        public static void ValidarTelefono (int telefono)
        {
            if( telefono = "")
            throw ArgumentException ("El mensaje no puede estar vacío")
        }
        public static void ValidarCorreo (string correo)
        {
            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@") || !correo.Contains("."))
            throw new Exception("El correo electrónico no tiene un formato válido");

        }
        public static void ValidarEdad (int edad)
        {
            if(edad <0 || edad > 25)
            throw new ArgumentException ("La edad debe ser entre 0 y 25 años");
        }
        public static void ValidarCosto (decimal costo);
        {
            if(costo < 0)
            throw new ArgumentException ("El costo no puede ser 0")
        }
        public static void ValidarNombre (string nombre)
        {
            if(string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException ("El nombre no puede estar vacio");
        }
       
        public static void ValidarFechaHora(DateTime fechaHora, Servicio servicio)
        {
            if (servicio.GetRequiereReservaAnticipada())
            {
                if ((fechaHora - DateTime.Now).TotalHours < 24)
                throw new ArgumentException("Este servicio requiere reserva con al menos 24 horas de anticipación.");
            }
        }

        public static void ValidarDisponibilidad(Profesionales profesional, DateTime fechaHora)
        {
            if (!profesional.EstaDisponible(fechaHora))
                throw new ArgumentException("El profesional no está disponible en esa fecha y hora");
        }

    }
}



