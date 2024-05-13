using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace VECTORES_EJERCICIO4
{
    internal class EJERCICIO4_VECTORES
    {
        static void Main(string[] args)
        {
            /*
            Crear un menú de opciones que permita:
            Cargar un array de caracteres.Recomendación: utilizar el método toCharArray().
            Ordenar vector.
            Contar vocales dentro del vector. (Cuantas a, e, i, o y u)
            Reemplazar consonantes por el carácter ‘*’ y mostrar
            */

            char[] vector = null;

            while (true)
            {
                Console.WriteLine("\nMENU DE OPCIONES");
                Console.WriteLine("1. Cargar array de caracteres");
                Console.WriteLine("2. Ordenar vector");
                Console.WriteLine("3. Contar vocales");
                Console.WriteLine("4. Reemplazar consonantes por '*'");
                Console.WriteLine("5. Salir");

                Console.Write("\nSeleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        vector = CargarVector();
                        break;
                    case 2:
                        OrdenarVector(vector);
                        break;
                    case 3:
                        ContarVocales(vector);
                        break;
                    case 4:
                        ReemplazarConsonantes(vector);
                        break;
                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static char[] CargarVector()
        {
            Console.Write("Ingrese una cadena de caracteres: ");
            string entrada = Console.ReadLine();
            return entrada.ToCharArray();
        }

        static void OrdenarVector(char[] vector)
        {
            if (vector == null)
            {
                Console.WriteLine("Primero debe cargar un vector.");
                return;
            }

            Array.Sort(vector);
            Console.WriteLine("Vector ordenado: " + new string(vector));
        }

        static void ContarVocales(char[] vector)
        {
            if (vector == null)
            {
                Console.WriteLine("Primero debe cargar un vector.");
                return;
            }

            int contadorA = 0, contadorE = 0, contadorI = 0, contadorO = 0, contadorU = 0;

            foreach (char c in vector)
            {
                switch (char.ToLower(c))
                {
                    case 'a':
                        contadorA++;
                        break;
                    case 'e':
                        contadorE++;
                        break;
                    case 'i':
                        contadorI++;
                        break;
                    case 'o':
                        contadorO++;
                        break;
                    case 'u':
                        contadorU++;
                        break;
                }
            }

            Console.WriteLine("Número de vocales:");
            Console.WriteLine("A: " + contadorA);
            Console.WriteLine("E: " + contadorE);
            Console.WriteLine("I: " + contadorI);
            Console.WriteLine("O: " + contadorO);
            Console.WriteLine("U: " + contadorU);
        }

        static void ReemplazarConsonantes(char[] vector)
        {
            if (vector == null)
            {
                Console.WriteLine("Primero debe cargar un vector.");
                return;
            }

            for (int i = 0; i < vector.Length; i++)
            {
                if (!EsVocal(vector[i]) && Char.IsLetter(vector[i]))
                {
                    vector[i] = '*';
                }
            }

            Console.WriteLine("Vector con consonantes reemplazadas por '*': " + new string(vector));
        }

        static bool EsVocal(char c)
        {
            switch (char.ToLower(c))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }







    }


   


}
