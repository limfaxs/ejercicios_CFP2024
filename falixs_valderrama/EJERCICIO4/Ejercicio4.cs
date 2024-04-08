namespace EJERCICIO4
{
    internal class Ejercicio4
    {
        static void Main(string[] args)

         //Ingresar 5 números enteros, calcular y mostrar el promedio

        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int numero5;

            Console.Write("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el cuarto numero: ");
            numero4 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el quinto numero: ");
            numero5 = int.Parse(Console.ReadLine());

            double promedio = Convert.ToDouble(numero1 + numero2 + numero3 + numero4 + numero5) / 5;

            Console.Write("El promedio es: " + promedio);
            Console.ReadKey();




            
        }
    }
}
