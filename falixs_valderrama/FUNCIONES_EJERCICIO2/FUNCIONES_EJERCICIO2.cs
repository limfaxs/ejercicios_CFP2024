using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FUNCIONES_EJERCICIO2
{
    internal class FUNCIONES_EJERCICIO2
    {
        //Crear una función que determine si el número recibido por parámetro es primo o no

        static void Main(string[] args)
        {
            int numero = 19; 
            bool esPrimo = EsPrimo(numero);

            if (esPrimo)
            {
                Console.WriteLine(numero + " es un número primo.");
            }
            else
            {
                Console.WriteLine(numero + " no es un número primo.");
            }

        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
