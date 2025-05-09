namespace EjemploRelevamiento
{
public class Servicio
{
private string nombre;
private string descripcion;
private int duracionAproximada; 
private decimal costo; 
private bool RequiereReservaAnticipada;

public Servicio(string nombre, string descripcion, int duracionAproximada, decimal costo, bool RequiereReservaAnticipada)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
      
        Validador.ValidarDuracion(duracionAproximada);
        this.duracionAproximada = duracionAproximada;
        Validador.ValidarCosto(costo);
        this.costo = costo;
        this.RequiereReservaAnticipada= RequiereReservaAnticipada;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Descripción: {descripcion}");
        Console.WriteLine($"Duración: {duracionAproximada}");
        Console.WriteLine($"Costo: ${costo}");
        Console.WriteLine($"¿Requiere reserva anticipada?: {(requiereReservaAnticipada ? "Sí" : "No")}");
    }
    public string GetNombre() => nombre;
    public bool GetRequiereReservaAnticipada() => RequiereReservaAnticipada;
    public int GetDuracion() => duracionAproximada;
    public decimal GetCosto() => costo;
}

}
