using PrimeraEvaluacion;
using System.Drawing;
//using System.Drawing;

namespace TesteoPrimeraEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            F. En un proyecto de consola crear un objeto del tipo Auto, 
            mostrar todos su valores y dentro de un bucle repetitivo usar el metodo avanzar(), 
            este debera repetirse hasta que el auto agote su combustible 
            y se debera informar cuantas repeticiones logra realizar.
             */

            Auto miAuto = new Auto("Toyota", 65, Color.Coral);
            int repeticiones = 0;

            Console.WriteLine(miAuto.AutoToString());

            while (miAuto.Avanzar(8))
            {
                repeticiones++;
            }

            Console.WriteLine($"El Auto se quedo sin combustible y logro realizar {repeticiones} repeticiones");



        }
    }
}
