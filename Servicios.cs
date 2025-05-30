
namespace EjemploRelevamiento
{
    public class Servicio
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public TimeSpan Duracion { get; private set; }
        public double Costo { get; private set; }
        public bool RequiereReserva { get; private set; }

        public Servicio(string nombre, string descripcion, TimeSpan duracion, double costo, bool requiereReserva)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Validaciones.ValidarDuracion(duracion);
            Duracion = duracion;
            Validaciones.ValidarCosto(costo);
            Costo = costo;
            RequiereReserva = requiereReserva;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("----- Servicio -----");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Duración: {Duracion.TotalMinutes} minutos");
            Console.WriteLine($"Costo: ${Costo}");
            Console.WriteLine($"¿Requiere reserva?: {(RequiereReserva ? "Sí" : "No")}");
        }

        public bool GetRequiereReservaAnticipada()
        {
            return RequiereReserva;
        }
    }
}
