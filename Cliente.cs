namespace EjemploRelevamiento
{
    public class Cliente
    {
    private string nombreCompleto;
    private string direccion;
    private  int telefono;
    private string correo;
    private string MetodoDePago;
    private list<Mascotas>mascota;
   
    public Cliente cliente = new Cliente (string nombreCompleto,string direccion, int telefono,string correo,string MetodoDePago)
{
    this.nombreCompleto = nombreCompleto;
    this.direccion= direccion;
    this.telefono= telefono;
    this.correo = correo;
    this.MetodoDePago = MetodoPago;
    this.mascota=new list<Mascotas>();
} 
    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Dirección: " + direccion);
        Console.WriteLine("Teléfono: " + telefono);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Método de pago: " + metodoPago);
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
}
    }

