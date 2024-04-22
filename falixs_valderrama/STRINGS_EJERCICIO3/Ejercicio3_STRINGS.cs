namespace STRINGS_EJERCICIO3
{
    internal class Ejercicio3_STRINGS
    {
        static void Main(string[] args)
        {
            /*
            Pedir el ingreso de una palabra y reemplazar todas las letras A por un carácter especial(* , & , etc).
            ej: Manzana->M * nz * n *.
            */

            string palabra;

            Console.WriteLine("por favor escriba una palabra: ");
            palabra = Console.ReadLine();

            char[] letras = palabra.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == 'a')
                {
                    letras[i] = '#' ;
                }

            }
            
            
            foreach (char unaLetra in letras)
            {
                Console.Write(unaLetra);
            }
            
        }
    }
}
