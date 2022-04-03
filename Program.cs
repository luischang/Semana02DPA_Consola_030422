// See https://aka.ms/new-console-template for more information
using Semana02DPA_Consola;

Console.WriteLine("Hello, World!");

string nombreCurso = "Curso de Desarrollo de ambiente web";
int edad = 30;
double monto = 200.01;
bool estaVacio = false;

var nuevoCurso = "Desarrollo de ambiente web v2";
var nuevaEdad = 32;
var nuevoMonto = 350.01;
var nuevoEstaVacio = true;

var persona = new Persona();
persona.dni = "11223344";
persona.nombreCompleto = "Juan Perez";
persona.edad = 34;

var persona2 = new Persona()
{
    dni = "22334455",
    nombreCompleto = "Paolo Guerrero",
    edad = 36
};

var persona3 = new Persona("99887766", "Gianluca Ladapula", 32);

//List<Persona> personas = new List<Persona>();
var personas = new List<Persona>();
personas.Add(persona);
personas.Add(persona2);
personas.Add(persona3);

//Recorrer las personas
foreach (var item in personas)
{
    Console.WriteLine(item.dni + " " + item.nombreCompleto + " " + item.edad);
}

//Busqueda de persona
var personaEncontrada = personas.Find(p => p.dni == "99887766");
//Validar si existe
if (personaEncontrada != null)
{
    Console.WriteLine(personaEncontrada.dni + " " + personaEncontrada.nombreCompleto + " " + personaEncontrada.edad);
}
else
{
    Console.WriteLine("No se encontro la persona");
}