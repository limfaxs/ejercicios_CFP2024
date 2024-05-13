using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace VECTORES_EJERCICIO6
{
    internal class EJERCICIO6_VECTORES
    {
        static void Main(string[] args)
        {
            /*
            Ingresar números en un vector, pueden ser positivos o negativos.Mostrar los negativos de forma creciente y los positivos de forma decreciente.
            Ejemplo:
            Vector ingresado: { 5, 1, -9, -1, 9, 3, -2, 2}
            Vector ordenado: { -9, -2, -1, 9, 5, 3, 2, 1}
            */

            int longitudVector;

            Console.Write("Ingrese la longitud del vector: ");
            longitudVector = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[longitudVector];

            // Ingresar números en el vector
            for (int i = 0; i < longitudVector; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Ordenar números negativos en forma creciente y positivos en forma decreciente
            OrdenarVector(vector);

            // Mostrar el vector ordenado
            Console.WriteLine("\nVector ordenado:");
            for (int i = 0; i < longitudVector; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }

        static void OrdenarVector(int[] vector)
        {
            // Ordenar números negativos en forma creciente
            Array.Sort(vector, (a, b) =>
            {
                if (a < 0 && b < 0)
                {
                    return a.CompareTo(b);
                }
                else if (a < 0)
                {
                    return -1;
                }
                else if (b < 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            // Ordenar números positivos en forma decreciente
            Array.Sort(vector, (a, b) =>
            {
                if (a > 0 && b > 0)
                {
                    return b.CompareTo(a);
                }
                else if (a > 0)
                {
                    return -1;
                }
                else if (b > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
        }

    }

    

}
