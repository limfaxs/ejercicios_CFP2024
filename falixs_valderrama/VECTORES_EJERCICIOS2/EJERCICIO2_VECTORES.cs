namespace VECTORES_EJERCICIOS2
{
    internal class EJERCICIO2_VECTORES
    {
        static void Main(string[] args)
        {
            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo

            int[] vector = new int[5]; // Crear un vector de enteros con 5 elementos
            int suma = 0; // Variable para almacenar la suma de los elementos

            // Cargar el vector con valores
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el elemento " + (i + 1) + ": ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calcular la suma de los elementos
            for (int i = 0; i < 5; i++)
            {
                suma += vector[i];
            }

            // Mostrar la suma
            Console.WriteLine("\nLa suma de los elementos del vector es: " + suma);
        }
    }
}
