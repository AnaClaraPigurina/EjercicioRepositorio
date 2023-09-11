namespace Program;
using Library;

class Program
{
    static void Main(string[] args)
    {
        Ejercicio ejercicio = new Ejercicio();
            string mensaje = ejercicio.aprender();
            Console.WriteLine(mensaje);
    }
}
