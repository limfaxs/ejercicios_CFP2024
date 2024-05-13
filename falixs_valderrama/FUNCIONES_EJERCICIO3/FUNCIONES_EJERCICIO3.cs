namespace FUNCIONES_EJERCICIO3
{
    internal class FUNCIONES_EJERCICIO3
    {
        /*
         Se requiere la creación de una función que cumpla con los siguientes requisitos:
         La función debe recibir tres parámetros: 'valor' (numérico), 'porcentaje' (numérico) y 'esAumento' (booleano).
         Si el parámetro 'esAumento' es verdadero, la función debe aumentar el 'valor' original aplicando el 'porcentaje' dado. 
         Si el parámetro 'esAumento' es falso, la función debe disminuir el 'valor' original aplicando el 'porcentaje' dado. 
         El resultado obtenido después de aplicar el porcentaje al 'valor' original debe ser retornado por la función.
        */

        static void Main(string[] args)
        {
            double valorOriginal = 100;
            double porcentaje = 10;
            bool esAumento = true;

            double resultado = AplicarPorcentaje(valorOriginal, porcentaje, esAumento);

            if (esAumento)
            {
                Console.WriteLine("Después de aumentar en " + porcentaje + "%, el resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("Después de disminuir en " + porcentaje + "%, el resultado es: " + resultado);
            }
        }
        static double AplicarPorcentaje(double valor, double porcentaje, bool esAumento)
        {
            if (esAumento)
            {
                return valor * (1 + (porcentaje / 100));
            }
            else
            {
                return valor * (1 - (porcentaje / 100));
            }

        }
    }
}
