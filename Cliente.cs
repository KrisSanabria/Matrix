
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
    private string nombreCompleto;
    private string direccion;
    private  int telefono;
    private string correo;
    private MetodoPago metodoDePago;
    private List <Mascota> mascotas;
   
    public Cliente (string nombreCompleto,string direccion, int telefono,string correo,MetodoPago metodoDePago)
{
    this.nombreCompleto = nombreCompleto;
    this.direccion= direccion;
    Validaciones.ValidarTelefono(telefono);
    this.telefono= telefono;
    Validaciones.ValidarCorreo(correo);
    this.correo = correo;
    this.metodoDePago = metodoPago;
    this.Mascotas =new List <Mascota> ();
} 
    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombreCompleto);
        Console.WriteLine("Dirección: " + direccion);
        Console.WriteLine("Teléfono: " + telefono);
        Console.WriteLine("Correo: " + correo);
        Console.WriteLine("Método de pago: " + metodoDePago);
    }
    public void AgregarMascota(Mascota mascota)
    {
        mascotas.Add(mascota);
    }

      public void MostrarMascotas()
    {
        Console.WriteLine("Mascotas de " + nombre + ":");
        foreach (Mascota mascota in mascotas)
        {
        mascota.MostrarInfo();
        }
     }

     public void AgregarTurno(Turno turno)
     {
        turnos.Add(turno);
     }
  }
}
