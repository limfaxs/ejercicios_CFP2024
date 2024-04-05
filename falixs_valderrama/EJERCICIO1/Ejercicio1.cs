namespace EJERCICIO1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Bienvenido " + nombre + " " + apellido);
        }
    }
}
