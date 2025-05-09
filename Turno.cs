
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
    private Mascota mascotas;
    private Profesionales profesionales;
    private estadoTurno estado ;
    private Modalidad modalidad;

    public Turno (DateTime fechaHora, Servicio servicio, Mascotas mascotas, Profesionales profesionales, estadoTurno estado, Modalidad modalidad)
   {
      Validar.ValidacionFechaHora(fechaHora,servicio);
      this.fechaHora = fechaHora;
      this.servicio  = servicio;
      this.mascotas = mascotas;
      Validar.ValidarDisponibilidad(profesionales, servicio);
      this.profesionales = profesionales;

   }
    public void MostrarInfo()
    {
      Console.WriteLine($"Turno para {mascotas.nombre} - {Servicio.Nombre}");
      Console.WriteLine($"Fecha y Hora {fechaHora}");
      Console.WriteLine($"Profesional: {profesionales.nombreCompleto}");
      Console.WriteLine($"Estado: {estadoTurno}");
      Console.WriteLine($"Modalidad {modalidad}");

    }
  }
}
	
