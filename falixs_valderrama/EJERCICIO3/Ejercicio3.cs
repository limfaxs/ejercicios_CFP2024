using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EJERCICIO3
{
    internal class Ejercicio3
    {
        static void Main(string[] args)

         //   Ingresar 2 números y mostrar la suma de los mismos

        {
           // int numer01;
            //int numero2;
            //int resultado;

            Console.Write("Escribe un numero ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe otro numero ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado;

            resultado = numero1 + numero2;

            Console.WriteLine("La suma de " + numero1 + " + " + numero2 + ", es : " + resultado);








        }
    }
}
