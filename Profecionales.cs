
namespace EjemploRelevamiento
{
    public enum Especialidades
    {
        Veterinario,
        Paseador,
        Peluquero
    }

    public class Profesional
     {
        public string NombreCompleto { get; private set;}
        public Especialidades Especialidad { get; private set;}
        public string NumeroMatricula { get; private set;}
        public List <DateTime> Disponibilidad { get; private set;}

        public Profesional(string nombreCompleto, Especialidades especialidad, string numeroMatricula)
        {
            NombreCompleto = nombreCompleto;
            Especialidad = especialidad;
            NumeroMatricula = numeroMatricula;
            Disponibilidad = new List<DateTime>();
        }
       
        public void AgregarHorario(DateTime fechaHora)
        {
            Disponibilidad.Add(fechaHora);
        }
        public bool EstaDisponible(DateTime fechaHora)
        {
            return !
            Disponibilidad.Contains(fechaHora);
        }
        public void MostrarInfo()
        {
            Console.WriteLine("----- Profesional -----");
            Console.WriteLine($"Nombre completo: {NombreCompleto}");
            Console.WriteLine($"Especialidad: {Especialidad}");
            Console.WriteLine($"Número de matrícula: {(string.IsNullOrWhiteSpace(NumeroMatricula) ? "No aplica" : NumeroMatricula)}");
            Console.WriteLine("------------------------");
        }
    }
}
