namespace EjemploRelevamiento
{
public class Servicios
{
private string nombre;
private string descripción;
private int duraciónAproximada; 
private decimal costo; 
private bool RequiereReservaAnticipada;


public Servicios Servicios = new Servicios (string nombre,string descripcion, int duracionAproximada,string correo,decimal costo,bool RequiereReservaAnticipada)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.duracionAproximada = duracionAproximada ;
        this.costo = costo ;
        this.RequiereReservaAnticipada = RequiereReservaAnticipada;
     } 
  }
}
