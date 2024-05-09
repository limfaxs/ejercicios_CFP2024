namespace STRINGS_EJERCICIO5
{
    internal class Ejercicio5_STRINGS
    {
        static void Main(string[] args)
        {
            /*
            Pedir el ingreso de nombre y apellido separado por un espacio,
            guardar cada dato en una variable diferente y asegurarse de que respete 
            el formato de la primera letra en mayúscula y el resto en minúsculas, 
            mostrar el apellido y el nombre por separado.
            ej: juAN ROBles (primero nombre luego apelido)
            imprimir:
            Apellido: Robles.
            Nombre: Juan.
            */

            string lectura = "falis Valderrama";
            string[] palabras = lectura.Split(' ');

            char[] vectorNombre = palabras[0].ToLower().ToCharArray();
            char[] vectorApellido = palabras[1].ToLower().ToCharArray();

            vectorApellido[0] = char.ToUpper(vectorApellido[0]);
            vectorNombre[0] = char.ToUpper((char)vectorNombre[0]);

            string nombre = "";
            string apellido = string.Empty;

            foreach (char letra in vectorNombre)
            {
                nombre += letra;
            }

            foreach (char letra in vectorApellido)
            {
                apellido += letra;
            }

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");



        }   

    }
}
