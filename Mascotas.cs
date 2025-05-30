
namespace EjemploRelevamiento
{
    public class Mascota
    {
        public string Nombre { get; private set; }
        public string Especie { get; private set; }
        public string Raza { get; private set; }
        private int edad;
        private double peso;
        public int Edad
        {
            get => edad;
            set
            {
                Validaciones.ValidarEdad(value);
                edad = value;
            }
        }
        public double Peso
        {
            get => peso;
            set
            {
                Validaciones.ValidarPeso(value);
                peso = value;
            }
        }
        public string HistorialVacunas { get; private set; }
        public string CondicionMedica { get; private set; }

        public Mascota(string nombre, string especie, string raza, int edad, double peso, string historialVacunas, string condicionMedica)
        {
            this.Nombre = nombre;
            this.Especie = especie;
            this.Raza = raza;
            this.Edad = edad;
            this.Peso = peso;
            this.HistorialVacunas = historialVacunas;
            this.CondicionMedica = condicionMedica;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("------Informacion de la mascota------: ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Raza: {Raza}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Vacunas: {HistorialVacunas}");
            Console.WriteLine($"Condicion Medica: {CondicionMedica}"); 
        }
    }
    
}

