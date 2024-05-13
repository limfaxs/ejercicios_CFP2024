namespace VECTORES_EJERCICIO5
{
    internal class EJERCICIO5_VECTORES
    {
        static void Main(string[] args)
        {
            //Ingresar datos en un vector y mostrarlos al revés.

            int longitudVector;

            Console.Write("Ingrese la longitud del vector: ");
            longitudVector = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[longitudVector];

            // Ingresar datos en el vector
            for (int i = 0; i < longitudVector; i++)
            {
                Console.Write("Ingrese el elemento " + (i + 1) + ": ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Mostrar los datos al revés
            Console.WriteLine("\nDatos del vector al revés:");
            for (int i = longitudVector - 1; i >= 0; i--)
            {
                Console.WriteLine("Elemento " + (i + 1) + ": " + vector[i]);
            }

        }
    }
}
