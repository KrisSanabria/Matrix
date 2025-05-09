Yanina Piuca
	
15:24 (hace 0 minutos)
	
para celestezuritaet12d1
namespace EjemploRelevamiento
{
public class Mascota
{
private string nombre;
private string especie;
private string raza;
private int edad;
private double peso;
private string historialVacunas;
private string condicionMedica;

public string Nombre
{
get=> nombre ;
set=> nombre = value;
}
public string Especie
{
get=> especie;
set=> especie = value;
}
public string Raza
{
get=> raza;
set=> raza = value;
}
public int Edad
{
get=> edad;
set
{
Validaciones.ValidarEdad(value);
edad= value;
}
}
public double Peso
{
get=> peso;
set
{
Validaciones.ValidarPeso(value);
peso=value;
}
}
public string HistorialVacunas
{
get=> historialVacunas;
set=> historialVacunas = value;
}
public string CondicionMedica
{
get=> condicionMedica;
set=> condicionMedica = value ;
}

public Mascota (string nombre, string especie, string raza, int edad, double peso,string historialVacunas, string condicionMedica)
{
this.Nombre= nombre;
this.Especie= especie;
this.Raza=raza;
this.Edad=edad;
this.Peso=peso;
this.HistorialVacunas=historialVacunas;
this.CondicionMedica=condicionMedica;
}

}
}



namespace EjemploRelevamiento
{
public static class Validaciones
{
public static void ValidarEdad(int edad)
{
if( edad <0)
throw new ArgumentException ("La edad debe ser un numero positivo");
}

public static void ValidarPeso (double peso)
{
if (peso <=0)
throw new ArgumentException ("El peso debe ser mayor a 0");
}
}
}




