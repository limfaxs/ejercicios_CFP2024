using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

namespace FUNCIONES_EJERCICIO1
{   //Crear una función que evalúe si una palabra es corta o larga. Se considera larga si tiene más de 8 caracteres.
    //La función debe recibir un parámetro de tipo cadena(string) y su retorno debe ser booleano.
    internal class Program
    {

        static void Main(string[] args)
        {
            string palabra = "dinosaurio";
            bool esLarga = EsPalabraLarga(palabra);

            if (esLarga)
            {
                Console.WriteLine("La palabra es larga.");
            }
            else
            {
                Console.WriteLine("La palabra es corta.");
            }
            

        }
        static bool EsPalabraLarga(string palabra)
        {
            return palabra.Length > 8;
        }


    }
}
