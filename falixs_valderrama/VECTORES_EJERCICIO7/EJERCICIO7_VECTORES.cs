namespace VECTORES_EJERCICIO7
{
    internal class EJERCICIO7_VECTORES
    {
        static void Main(string[] args)
        {
            /*
              Crear 3 vectores. En los primeros dos pedirle al usuario que cargue valores. El tercer vector deberá guardar el valor más grande como resultado de la comparación de los otros dos.
                Por ej: 

                Vector a
                Vector b
                Vector c
                5
                9
                9
                4
                3
                4
                2
                10
                10
                9
                9
                9
                3
                1
                3        
             */

            int longitudVector;

            Console.Write("Ingrese la longitud de los vectores a y b: ");
            longitudVector = Convert.ToInt32(Console.ReadLine());

            int[] vectorA = new int[longitudVector];
            int[] vectorB = new int[longitudVector];
            int[] vectorC = new int[longitudVector];

            // Ingresar valores en el vector A
            Console.WriteLine("Ingrese los valores del vector A:");
            for (int i = 0; i < longitudVector; i++)
            {
                Console.Write("Valor " + (i + 1) + ": ");
                vectorA[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Ingresar valores en el vector B
            Console.WriteLine("\nIngrese los valores del vector B:");
            for (int i = 0; i < longitudVector; i++)
            {
                Console.Write("Valor " + (i + 1) + ": ");
                vectorB[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Comparar valores de vector A y B y guardar el máximo en vector C
            for (int i = 0; i < longitudVector; i++)
            {
                vectorC[i] = Math.Max(vectorA[i], vectorB[i]);
            }

            // Mostrar el vector C que contiene el máximo de cada posición de A y B
            Console.WriteLine("\nEl vector C que contiene los valores máximos de A y B es:");
            for (int i = 0; i < longitudVector; i++)
            {
                Console.WriteLine("Valor " + (i + 1) + ": " + vectorC[i]);
            }
        }


    }

}
