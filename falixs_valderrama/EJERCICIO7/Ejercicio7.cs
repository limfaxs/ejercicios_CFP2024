using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

namespace EJERCICIO7
{
    internal class Ejercicio7
    {
        static void Main(string[] args)
        {
            /*
            (REPETITIVAS)
            Ingresar 15 números y determinar:
            Suma de los negativos.
            Suma de los positivos.
            Cantidad de positivos.
            Cantidad de negativos.
            Cantidad de ceros.
            Cantidad de números pares.
            Promedio de positivos.
            Promedio de negativos.
            Diferencia entre positivos y negativos, (positivos - negativos).
            El número máximo
            De los negativos el mínimo
            */

            int i;
            string iN;
            int sumaPositivos = 0;
            int sumaNegativos = 0;
            int cantidadPositivos = 0;
            int cantidadNegativos = 0;
            int cantidadCeros = 0;
            int cantidadNumerosPares = 0;
            int promedioPositivos = 0;
            int promedioNegativos = 0;
            int diferenciaPositivosNegativos = 0;
            int numeroMaximo;
            numeroMaximo = 0;
            int nMinimoNegativo = 0;
            int numeroMinimo = 0;
            int nMaximo = 0;
            bool maximo;
            bool minimo;
            maximo = true;
            minimo = true;
            int xi;
            int nM;
            
            for (xi=0; xi < 15; xi++)
            {

            

                Console.WriteLine("por favor ingrese un numero entre -1000 y + 1000 entero:?");
                iN = Console.ReadLine();
                i = int.Parse(iN);
                
                if ((1 % 2) == 0) 
                {
                    {
                        cantidadNumerosPares = cantidadNumerosPares + 1;
                    }
                    

                    if (i < 0)
                    {
                        sumaNegativos = sumaNegativos + 1;
                        cantidadNegativos = cantidadNegativos + 1;
                    }
                    else
                    {
                       if (i == 0)
                       { 
                            cantidadCeros = cantidadCeros + 1;
                       } 

                       else
                       {
                            cantidadPositivos = cantidadPositivos + 1;
                            sumaPositivos = sumaPositivos + 1;
                       }

                    }
                }
                
            }   promedioPositivos = sumaPositivos / cantidadPositivos;
                promedioNegativos = sumaNegativos / cantidadNegativos;
                diferenciaPositivosNegativos = sumaPositivos - sumaNegativos;

                Console.WriteLine("La suma de los numeros negativos es igual a: " + sumaNegativos);
                Console.WriteLine("La suma de los numeros positivos es igual a: " + sumaPositivos);
                Console.WriteLine("La cantidad de numeros positivos es igual a: " + cantidadPositivos);
                Console.WriteLine("La cantidad de numeros negativos es igual a: " + cantidadNegativos);
                Console.WriteLine("La cantidad de ceros es igual a: " + cantidadCeros);
                Console.WriteLine("La cantidad de numeros pares aes igual a: " + cantidadNumerosPares);
                Console.WriteLine("El promedio de numeros positivos es igual a: " + promedioPositivos);
                Console.WriteLine("El promedio de los numeros negativos es igual a: " + promedioNegativos);
                Console.WriteLine("La diferencia de numeros positivos y numeros negativos es igual: " +diferenciaPositivosNegativos);
                Console.WriteLine("El numero positivo maximo es iagual a: " + nMaximo);
                Console.WriteLine("El numero minimo de los negativos es igual a: " + nMinimoNegativo);
        }
    }
}

            