namespace EjemploRelevamiento
{
  public class Turno
  {
    private datetime fechaHora;
    private Servicio servicio;
    private Mascotas mascotas;
    private Profesionales profesionales;
    private estadoTurno estado ;
    private Modalidad modalidad;

    public Turno (datetime fechaHora, Servicio servicio, Mascotas mascotas, Profesionales profesionales, estadoTurno estado, Modalidad modalidad)
   {
      Validar.ValidacionFechaHora(fechaHora,servicio);
      this.fechaHora = fechaHora;
      this.servicio  = servicio;
      this.mascotas = mascotas;
      Validar.ValidarDisponibilidad(profesionales, servicio);
      this.profesionales = profesionales,

   }
    public void MostrarInfo()
    {
      Console.WriteLine( "")
    }
  }
}
