using System.Numerics;

namespace VECTORES_EJERCICIO1
{
    internal class EJERCICIO1_VECTORES
    {
        static void Main(string[] args)
        {
            // Cargar un vector de enteros de 5 elementos y mostrarlos.

            int[] misNumeros = cargarArrayDeEnteros(5);

            for (int i = 0; i < 5; i++) 
            {           
                Console.Write($"Ingrese el numero {i + 1} de 5: ");
                misNumeros[i] = int.Parse( Console.ReadLine());
            }

            foreach (int numero in misNumeros) 
            {
                Console.WriteLine(numero);
            }



        }

        static int[] cargarArrayDeEnteros(int cantidad)
        {
            int[] numeros = new int[cantidad];
            for(int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el numero {i+1} de {cantidad}: ");
                numeros[i] = int.Parse( Console.ReadLine());
            }
            return numeros;
        }

    }
}



