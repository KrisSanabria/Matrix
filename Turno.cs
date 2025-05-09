

namespace EjemploRelevamiento
{
    public enum  estadoTurno
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
    private DateTime fechaHora;
    private Servicio servicio;
    private Mascota mascota;
    private Profesionales profesionales;
    private estadoTurno estado ;
    private Modalidad modalidad;

    public Turno (DateTime fechaHora, Servicio servicio, Mascota mascota, Profesionales profesionales, estadoTurno estado, Modalidad modalidad)
   {
      Validaciones.ValidarFechaHora(fechaHora,servicio);
      this.fechaHora = fechaHora;
      this.servicio  = servicio;
      this.mascota = mascota;
      Validaciones.ValidarDisponibilidad(profesionales, servicio);
      this.profesionales = profesionales;

   }
    public void MostrarInfo()
    {
      Console.WriteLine($"Turno para {mascota.nombre} - {Servicio.Nombre}");
      Console.WriteLine($"Fecha y Hora {fechaHora}");
      Console.WriteLine($"Profesional: {profesionales.nombreCompleto}");
      Console.WriteLine($"Estado: {estadoTurno}");
      Console.WriteLine($"Modalidad {modalidad}");

    }
  }
}
	
