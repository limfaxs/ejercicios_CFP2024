﻿namespace primera_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edadTexto;
            int edadNumerica;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edadTexto = Console.ReadLine();

            edadNumerica = int.Parse(edadTexto);

            //Console.WriteLine("Bienvenido " + nombre + " " + apellido + ", usted tiene: " + edadNumerica + " años.");


            //Console.WriteLine("{1} Bienvenido {2} {0}, ud tiene: {1} años. ", apellido, edadNumerica, nombre);

            Console.WriteLine($"Bienvenido {nombre} {apellido}, ud tiene: {edadNumerica} años.");
            

        }

    }
    }
