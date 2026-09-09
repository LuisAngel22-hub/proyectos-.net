using System;

namespace MiPrimerPrograma
{
    class Program
    {
        // El método Main es el punto de entrada. Aquí es donde comienza a ejecutarse el programa.
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a .NET!");
            Console.WriteLine("-------------------");

            Console.WriteLine("Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine(); // Lee lo que escribe el usuario

            Console.WriteLine($"Hola, {nombre}. Vamos a sumar dos números.");

            // Declaramos variables
            int numero1 = 5;
            int numero2 = 10;
            int resultado = numero1 + numero2;

            // Mostramos el resultado
            Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");
            
            // Pausar para que la consola no se cierre inmediatamente
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey(); 
        }
    }
}