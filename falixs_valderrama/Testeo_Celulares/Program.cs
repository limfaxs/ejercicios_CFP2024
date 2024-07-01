using Biblioteca_Celulares;

namespace Testeo_Celulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celulares celular1 = new Celulares("Nokia", 85, "MONSA", 50, "Lanus", "Retiro");
            Celulares celular2 = new Celulares("Motorola", Moto, "CAT", 45, "Lanus", "Retiro");
            Celulares celular3 = new Celulares("Samsung", 22, "SUR", 30, "Lomas", "Avellaneda");
            Celulares celular4 = new Celulares("poco", 285, "RAPIDO", 50, "Constitucion", "Recoleta");
            Celulares celular5 = new Celulares("Redmi", 458, "NORTE", 65, "Once", "Barracas");

            Celulares[] misCelulares = new Celulares[5];
            misCelulares[0] = celular1;
            misCelulares[1] = celular2;
            misCelulares[2] = celular3;
            misCelulares[3] = celular4;
            misCelulares[4] = celular5;

            //Console.WriteLine("Mostrando el array completo");

            //foreach (Colectivo item in misColectivos)
            //{
            //    Console.WriteLine(item.ColectivoToString());
            //}
            //misColectivos[4] = null;

            //Console.WriteLine("Mostrando el array, borrando el ultimo elemento");
            //foreach (Colectivo item in misColectivos)
            //{
            //    if (item is not null)
            //    {
            //        Console.WriteLine(item.ColectivoToString());
            //    }
            //}

            List<Celulares> listaDeCelulares = new List<Celulares>();

            listaDeCelulares.Add(celular1);
            listaDeCelulares.Add(celular2);
            listaDeCelulares.Add(celular3);
            listaDeCelulares.Add(celular4);
            listaDeCelulares.Add(celular5);

            Console.WriteLine("*****Mostrando el array completo*****");

            foreach (Celulares item in listaDeCelulares)
            {
                Console.WriteLine(item.ColectivoToString());
            }
            ////listaDeColectivos.Remove(colectivo5); //metodo uno
            //listaDeColectivos.RemoveAt(4); //metodo dos

            //Console.WriteLine("\n*****Mostrando el array, borrando el ultimo elemento*****");
            //foreach (Colectivo item in listaDeColectivos)
            //{
            //    Console.WriteLine(item.ColectivoToString());
            //}

            listaDeCelulares.Sort(compararCelularesPorMarca);

            Console.WriteLine("*****Mostrando el array Ordenado por linea*****");

            foreach (Celulares item in listaDeCelulares)
            {
                Console.WriteLine(item.ColectivoToString());
            }
            //Colectivo[] misColectivos = { colectivo1, colectivo2, colectivo3, colectivo4, colectivo5 };

            // foreach (Colectivo item in misColectivos)
            // {
            //     Console.WriteLine(item.ColectivoToString());
            // }
        }
        public static int compararCelularesPorMarca(Celulares c1, Celulares c2)
        {
            int resultado = 0;

            if (c1.GetLinea() < c2.GetLinea())
            {
                resultado = -1;
            }
            else
            {
                if (c1.GetLinea() < c2.GetLinea())
                {
                    resultado = 1;
                }
            }
            return resultado;
        }
    }
}
