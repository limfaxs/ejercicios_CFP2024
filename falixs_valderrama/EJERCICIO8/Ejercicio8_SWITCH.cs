using System.Diagnostics;

namespace EJERCICIO8
{
    internal class Ejercicio8_SWITCH
    {
        static void Main(string[] args)
        {
            /*
            (SWITCH)
            Pedir una opción al usuario(1,2,3,4,5,6)
            1.Fondo azul y letras rojo
            2.Fondo verde y letras amarillas
            3.Fondo amarillo y letras azules
            4.Fondo blanco y letras negras
            5.Fondo magenta oscuro y letras amarillas
            6.Fondo blanco y letras azules
            Mostrar un mensaje que introdujo el usuario con la combinación deseada.
            Utilizar las propiedades de la clase Console:
            ForegroundColor
            BackGroundColor
            Y los enumerados de: ConsoleColor(black, grey, green, etc)
            */

            string mensaje;
            int opcion;
            string opcionN;

            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("1° fondo azul , letras rojo");
            Console.WriteLine("2° fondo verde , letras amarillas");
            Console.WriteLine("3° fondo amarillo , letras amarillas ");
            Console.WriteLine("4° fondo blanco , letras negras");
            Console.WriteLine("5° Fondo magenta oscuro , letras amarillas");
            Console.WriteLine("6° fondo blanco , letras azules");
            Console.WriteLine("Introdusca la opcion que desea(de 1 a 6) :");

            opcionN = Console.ReadLine();
            opcion = int.Parse(opcionN);

            Console.WriteLine("Por favor iuntrodusca un mensaje");
            mensaje = Console.ReadLine();

            switch (opcion)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mensaje);
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(mensaje);
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(mensaje);
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(mensaje);
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(mensaje);
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(mensaje);
                    break;
                default:
                    Console.WriteLine("Por favor ingrese una opcion correcta");
                    break;
                    
            }

        }
    }
}
