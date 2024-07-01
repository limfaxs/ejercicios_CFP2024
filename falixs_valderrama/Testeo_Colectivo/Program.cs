using Bliblioteca_Colectivo;

namespace Testeo_Colectivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colectivo colectivo1 = new Colectivo("AD123BC", 85, "MONSA", 50, "Lanus", "Retiro");
            Colectivo colectivo2 = new Colectivo("CD456BC", 07, "CAT", 45, "Lanus", "Retiro");
            Colectivo colectivo3 = new Colectivo("SC852BC", 22, "SUR", 30, "Lomas", "Avellaneda");
            Colectivo colectivo4 = new Colectivo("MN201BC", 285, "RAPIDO", 50, "Constitucion", "Recoleta");
            Colectivo colectivo5 = new Colectivo("LO741BC", 458, "NORTE", 65, "Once", "Barracas");

            Colectivo[] misColectivos = new Colectivo[5];
            misColectivos[0] = colectivo1;
            misColectivos[1] = colectivo2;
            misColectivos[2] = colectivo3;
            misColectivos[3] = colectivo4;
            misColectivos[4] = colectivo5;

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

            List<Colectivo> listaDeColectivos = new List<Colectivo>();

            listaDeColectivos.Add(colectivo1);
            listaDeColectivos.Add(colectivo2);
            listaDeColectivos.Add(colectivo3);
            listaDeColectivos.Add(colectivo4);
            listaDeColectivos.Add(colectivo5);

            Console.WriteLine("*****Mostrando el array completo*****");

            foreach (Colectivo item in listaDeColectivos)
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

            listaDeColectivos.Sort(comparaColectivosPorLinea);

            Console.WriteLine("*****Mostrando el array Ordenado por linea*****");

            foreach (Colectivo item in listaDeColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            }
            //Colectivo[] misColectivos = { colectivo1, colectivo2, colectivo3, colectivo4, colectivo5 };

            // foreach (Colectivo item in misColectivos)
            // {
            //     Console.WriteLine(item.ColectivoToString());
            // }
        }
        public static int comparaColectivosPorLinea(Colectivo c1, Colectivo c2)
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
