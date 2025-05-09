using EjemploRelevamiento;
   public class Profesional
{
    private string nombreCompleto;
    private string especialidad;
    private string numeroMatricula;
    private List <DateTime> disponibilidad;

    public Profesional(string nombre, string especialidad, string numeroMatricula, List<DateTime> disponibilidad)
    {
        this.nombreCompleto = nombre;
        this.especialidad = especialidad;
        this.numeroMatricula = numeroMatricula;
        this.disponibilidad = disponibilidad ?? new List<DateTime>();
    }

  
    public string Nombre => nombreCompleto;
    public string Especialidad => especialidad;
    public string NumeroMatricula => numeroMatricula;
    public List<DateTime> Disponibilidad => disponibilidad;

    
    public bool EstaDisponible(DateTime fechaHora)
    {
        return disponibilidad.Contains(fechaHora);
    }

    
    public void AgregarDisponibilidad(DateTime fechaHora)
    {
        if (!disponibilidad.Contains(fechaHora))
        {
            disponibilidad.Add(fechaHora);
        }
    }

    public void EliminarDisponibilidad(DateTime fechaHora)
    {
        disponibilidad.Remove(fechaHora);
    }
}
