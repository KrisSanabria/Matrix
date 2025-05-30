using EjemploRelevamiento;

Console.WriteLine("------ REGISTRO DE CLIENTE ------");

Console.Write("Ingrese el nombre completo: ");
string nombre = Console.ReadLine();

Console.Write("Ingrese la direccion: ");
string direccion = Console.ReadLine();

Console.Write("Ingrese un telefono (solo numeros): ");
int telefono = int.Parse(Console.ReadLine());

Console.Write("Ingrese un correo electrónico: ");
string correo = Console.ReadLine();

Console.WriteLine("Ingrese el tipo de metodo de pago (0 = Tarjeta, 1 = Efectivo, 2 = Transferencia): ");
int almacenMetodoPago = int.Parse(Console.ReadLine());
MetodoPago metodoPago = (MetodoPago)almacenMetodoPago;

Cliente cliente = new Cliente(nombre, direccion, telefono, correo, metodoPago);

//Mascota
Console.WriteLine("----- REGISTRO DE MASCOTA ------");

Console.Write("Ingrese el nombre: ");
string nombreMascota = Console.ReadLine();

Console.Write("Ingrese la especie: ");
string especie = Console.ReadLine();

Console.Write("Ingrese la raza: ");
string raza = Console.ReadLine();

Console.Write("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Ingrese el peso: ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Ingrese historial de vacunas: ");
string vacunas = Console.ReadLine();

Console.Write("Ingrese la condicion medica: ");
string condicion = Console.ReadLine();

Mascota mascota = new Mascota(nombreMascota, especie, raza, edad, peso, vacunas, condicion);
cliente.AgregarMascota(mascota);


// Servicio
Console.WriteLine("\n------ REGISTRO DE SERVICIO ------");

Console.Write("Ingrese el nombre del servicio: ");
string nombreServicio = Console.ReadLine();

Console.Write("Ingrese la descripcion: ");
string descripcion = Console.ReadLine();

Console.Write("Ingrese la duracion (en minutos): ");
int minutos = int.Parse(Console.ReadLine());

Console.Write("Ingrese costo: ");
double costo = double.Parse(Console.ReadLine());

Console.Write("¿Este servicio necesita reserva anticipada? (true(SI)/false(NO)): ");
bool requiereReserva = bool.Parse(Console.ReadLine());

Servicio servicio = new Servicio(nombreServicio, descripcion, TimeSpan.FromMinutes(minutos), costo, requiereReserva);


// Profesional
Console.WriteLine("------- REGISTRO DE PROFESIONAL ------");

Console.Write("Ingrese el nombre del profesional: ");
string nombreProfesional = Console.ReadLine();

Console.WriteLine("Ingrese el tipo de especialidad (0 = Veterinario, 1 = Paseador, 2 = Peluquero): ");
int especialidadInput = int.Parse(Console.ReadLine());
Especialidades especialidad = (Especialidades)especialidadInput;

Console.Write("Ingrese el numero de matricula (o dejar vacio si no tiene): ");
string matricula = Console.ReadLine();

Profesional profesional = new Profesional(nombreProfesional, especialidad, matricula);


// Turno
Console.WriteLine("------ REGISTRO DE TURNO ------");
Console.Write("Fecha y hora del turno (ejemplo: 30/05/2025 15:00): ");
DateTime fechaHora = DateTime.Parse(Console.ReadLine()); 

profesional.AgregarHorario(fechaHora);

Turno turno = new Turno(fechaHora, servicio, mascota, profesional, EstadoTurno.Confirmado, Modalidad.Presencial);
cliente.AgregarTurno(turno);


// Muestra la informacion
Console.WriteLine("------ DATOS REGISTRADOS ------");
cliente.MostrarDatos();
cliente.MostrarMascotas();
cliente.MostrarTurnos();
profesional.MostrarInfo();
