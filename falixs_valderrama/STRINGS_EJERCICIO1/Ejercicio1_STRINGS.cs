﻿using System;

namespace STRINGS_EJERCICIO1
{
    internal class Ejercicio1_STRINGS
    {
        static void Main(string[] args)
        {
            /*
            Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres 
            de no ser así informar, luego mostrar los primeros 3 caracteres.
            ej: zapallo->zap
            */

            string palabra;

            do
            {
                Console.WriteLine("Por favor ingrese una palabra con mas de 5 caracteres");
                palabra = Console.ReadLine();

                if(palabra.Length < 5)
                {
                    Console.WriteLine("La palabra ingresada es muy corta)");
                }

            }
            while(palabra.Length < 5);

            for(int i = 0; i < 3; i++)
            {
                Console.Write(palabra[i]);
            }




        }
    }
}
