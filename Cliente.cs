
namespace EjemploRelevamiento
{
    public enum MetodoPago
    {
        Tarjeta,
        Efectivo,
        Transferencia
    }
    public class Cliente
    {
        public string NombreCompleto { get; private set; }
        public string Direccion { get; private set; }
        public int Telefono { get; private set; }
        public string Correo { get; private set; }
        public MetodoPago MetodoDePago { get; private set; }
        private List<Mascota> mascotas;
        private List<Turno> turnos;
        public Cliente(string nombreCompleto, string direccion, int telefono, string correo, MetodoPago metodoDePago)
        {
            this.NombreCompleto = nombreCompleto;
            this.Direccion = direccion;
            Validaciones.ValidarTelefono(telefono);
            this.Telefono = telefono;
            Validaciones.ValidarCorreo(correo);
            this.Correo = correo;
            this.MetodoDePago = metodoDePago;
            this.mascotas = new List<Mascota>();
            this.turnos = new List<Turno>();
        }
        public void MostrarDatos()
        {
            Console.WriteLine("-----Informacion del Cliente-----:");
            Console.WriteLine($"Nombre: {NombreCompleto}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Método de pago: {MetodoDePago}");
        }
        public void AgregarMascota(Mascota mascota)
        {
            mascotas.Add(mascota);
        }

        public void MostrarMascotas()
        {
            Console.WriteLine("Mascotas del cliente: ");
            foreach (Mascota mascota in mascotas)
            {
                mascota.MostrarInformacion();
            }
        }

        public void AgregarTurno(Turno turno)
        {
            turnos.Add(turno);
        }
        public void MostrarTurnos()
        {
        Console.WriteLine("Turnos del cliente:");
            foreach (Turno turno i  n turnos)
            {
                turno.MostrarInfo();
            }
        }
  }
}
