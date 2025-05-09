
namespace EjemploRelevamiento
{
    public enum Especialidad
    {
        Veterinario,
        Paseador,
        Peluquero
    }

    public class Profesionales
     {
        private string nombreCompleto;
        private Especialidad especialidad;
        private string numeroMatricula; 
        private List <DateTime> disponibilidad;

        public Profesionales (string nombreCompleto, Especialidad especialidad, string numeroMatricula, List <DateTime> disponibilidad)
        {
            Validaciones.ValidarNombre(nombreCompleto);
            this.nombreCompleto = nombreCompleto;
            this.especialidad = especialidad;
            this.numeroMatricula = numeroMatricula;
            this.disponibilidad = disponibilidad ?? new List<DateTime>();
        }

        public string GetNombreCompleto() => nombreCompleto;
        public Especialidad GetEspecialidad() => especialidad;
        public string GetMatricula() => numeroMatricula;
        public List<DateTime> GetDisponibilidad() => disponibilidad;

        public bool EstaDisponible(DateTime fechaHora)
        {
            return disponibilidad.Contains(fechaHora);
        

        public void AsignarTurno(DateTime fechaHora)
            {
            if (!EstaDisponible(fechaHora))
                throw new Exception("El profesional no está disponible en ese horario.");
            disponibilid.Remove(fechaHora);
            }
        }
    }
}
	
