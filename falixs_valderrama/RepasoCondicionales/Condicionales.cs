using System.ComponentModel.Design;

namespace RepasoCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Al ingresar una edad menor a 18 años y un estado civil distinto a soltero, 
            //mostrar el mensaje: “Es muy pequeño para NO ser soltero”


            int edad;
            string edadTexto;
            string estadoCivil;

            Console.Write("Ingrese su edad: ");
            edadTexto = Console.ReadLine();

            edad = int.Parse(edadTexto);


            Console.Write("Ingrese su estado Civil: ");

            estadoCivil = Console.ReadLine();

            if (edad < 18 && estadoCivil == "casado")
            {
                Console.WriteLine("Es muy pequeño para no ser soltero");
            }

        }
    }
}

