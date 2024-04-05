using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace EJERCICIO2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)

        //Ingresar el nombre, apellido y edad por consola
        {
            string nombre;
            string apellido;
            string edad;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = Console.ReadLine();

            Console.WriteLine("Bienvenido: " + nombre + " " + apellido  + ", su edada es: " + edad);



        }
    }
}
