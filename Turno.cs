

namespace EjemploRelevamiento
{
    public enum  EstadoTurno
    {
        Pendiente,
        Confirmado,
        Cancelado,
        Completado
    }
    public enum Modalidad
    {
        Presencial,
        Domicilio
    }

    public class Turno
    {
      public DateTime FechaHora { get; private set; }
      public Servicio Servicio { get; private set; }
      public Mascota Mascota { get; private set; }
      public Profesional Profesional { get; private set; }
      public EstadoTurno Estado { get; private set; }
      public Modalidad Modalidad { get; private set;}

    public Turno(DateTime fechaHora, Servicio servicio, Mascota mascota, Profesional profesional, EstadoTurno estado,
    Modalidad modalidad)
    {
      Validaciones.ValidarFechaHora(fechaHora, servicio);
      FechaHora = fechaHora;
      Servicio = servicio;
      Mascota = mascota;
      Validaciones.ValidarDisponibilidad(profesional, fechaHora);
      Profesional = profesional;
      profesional.AgregarHorario(fechaHora);
      Estado = estado;
      Modalidad = modalidad;
      }
      public void MostrarInfo()
      {
        Console.WriteLine($"Fecha y hora: {FechaHora}");
        Console.WriteLine($"Modalidad: {Modalidad}");
        Console.WriteLine($"Estado: {Estado}");
        Console.WriteLine($"Servicio: {Servicio.Nombre}");
        Console.WriteLine($"Mascota: {Mascota.Nombre}");
        if (Profesional != null)
          Console.WriteLine($"Profesional: {Profesional.NombreCompleto}");
        else
          Console.WriteLine("Profesional: (Profesional no asignado)");
}
  }
}
	
