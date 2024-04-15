using Microsoft.Win32;
using System;
using System.ComponentModel.Design;

namespace EJERCICIO6
{
    internal class Ejercicio6_CONDICIONALES
    {
        static void Main(string[] args)
        {
            /*
            (CONDICIONALES)
            Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus ventas,
            los siguientes datos: marca y cantidad.El precio de cada lamparita es de $150(Sin importar la marca).
            El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
            A.Si compra 6 lamparitas o más, tiene un descuento del 50 %.
            B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40 % y si es de otra marca,
            el descuento es del 30 %.
            C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25 %,
            y si es de otra marca el descuento es del 20 %.
            D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15 %,
            si es “FelipeLamparas se hace un descuento del 10 % y si es otra marca, 5 %.
            E.Si el importe final con descuento suma más de $950, se debe agregar el 10 % de ingresos brutos.
            Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento,
            y si corresponde total de ingresos brutos y total a pagar.
            */

            string marca;
            int cantidad;
            float precio;
            int porcentaje;
            float totalSinDescuento;
            float descuento;
            float totalConDescuento;
            float importeMiniIngresosBrutos;
            float valorIngresosBrutos;
            float totalAPagar;

            precio = 150;
            importeMiniIngresosBrutos = 950;

            Console.WriteLine("Ingrese la marca de lampara elegida: ");
            marca = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de lamparas compradas: ");
            cantidad = int.Parse(Console.ReadLine());

            marca = "Felipe lamparas";
            cantidad = 4;

            totalSinDescuento = cantidad * precio;
            porcentaje = 0;

            if (cantidad >= 6)
            {
                porcentaje = 50;

            }
            else
            {
                if (cantidad == 5)
                {
                    porcentaje = 30;

                    if (marca == "Argentinaluz")
                    {
                        porcentaje = 40;
                    }
                }
                else
                {
                    if (cantidad == 4)
                    {
                        porcentaje = 20;

                        if ((marca == "ArgentinaLuz") || (marca == "FelipeLamparas"))
                        {
                            porcentaje = 25;
                        }


                    }
                    else
                    {
                        if (cantidad == 3)
                        {
                            porcentaje = 5;

                            if (marca == "ArgentinaLuz")
                            {
                                porcentaje = 15;
                            }
                            else
                            {
                                if (marca == "FelipeLamparas")
                                {
                                    porcentaje = 10;
                                }
                            }
                        }
                    }
                }
            }

            //Console.WriteLine($"Vendio" {cantidad} {apellido}, ud tiene: {edadNumerica} años.");
            Console.Write("marca: "  , marca, " | cantidad: ", cantidad, " | precio unitario: $", precio, " | precio: $", totalSinDescuento);
           
            if ( porcentaje != 0)
                
            {
                descuento = porcentaje * totalSinDescuento / 100;
                totalConDescuento = totalSinDescuento - descuento;

                Console.Write("% de descuento: ", porcentaje, "% | Descuento: $", descuento, " | precio con descuento: $", totalConDescuento);

               
                if (totalConDescuento >= importeMiniIngresosBrutos)
                { 
                    valorIngresosBrutos = totalConDescuento * 10 / 100;
                    totalAPagar = totalSinDescuento - valorIngresosBrutos;

                    Console.Write($"Por ingresos brutos se le cobra un impuesto de: ", valorIngresosBrutos, " | total a pagar: ", totalAPagar);


                }

                //E.Si el importe final con descuento suma más de $950, se debe agregar el 10 % de ingresos brutos.
                //Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento,
                //y si corresponde total de ingresos brutos y total a pagar.

                Console.WriteLine($"se vendieron: " + (cantidad) + "Lamparas , marca: " + marca);
                Console.WriteLine($"precio total sin descuento " + (precio) + "pesos");
                Console.WriteLine($"el descuento es de: " + (descuento) + "pesos");
                Console.WriteLine($"precio sin descuento: " + (totalSinDescuento) + "pesos");
                Console.WriteLine("precio con descuento: "+ (totalConDescuento) + "pesos");
                Console.WriteLine($"precio final : "+ (precio) + "pesos");

                

            }

            


        }
    }
}