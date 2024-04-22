namespace STRINGS_EJERCICIO4
{
    internal class Ejercicio4_STRINGS
    {
        static void Main(string[] args)
        {
            /*
             Del string 0000001234500000000 conseguir quedarse con el string 12345 y mostrarlo por pantalla.
             */

            string palabra = "0000001234500000000";
            Console.WriteLine(palabra.Trim('0'));
        }
    }
}
