using LibreriaVehiculos;

namespace Testeo_Vehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Crear instancia de coche y moto.
              Llamar a los metodos conducir() y MostrarInfo() para cada instancia.
              Utilizar GetType() y el casteo para llamar a los métodos específicos de las clases derivadas
              (AbrirMaletero() y hacer caballito()).
           */
            Vehiculo vehiculo = new Vehiculo("Fiat", "1998");
            Vehiculo coche2 = new Coche("Fiat", "2023", 3, 100);
            Vehiculo moto2 = new Moto("yamaha", "2022", "Paseo", 150);
            Moto moto1 = new Moto("Honda", "2015", "Carrera", 200);
            Coche coche1 = new Coche("Ford", "2024", 5, 200);

            // 2.
            //List<Vehiculo> vehiculos = new List<Vehiculo>() {
            //    vehiculo,coche2,moto2,moto1,coche1
            //};

            //foreach (Vehiculo item in vehiculos)
            //{
            //    Console.WriteLine(item.Conducir());
            //}

            // 2.1 
            List<Vehiculo> vehiculos = new List<Vehiculo>() {
                vehiculo,coche2,moto2,moto1,coche1
            };

            foreach (Vehiculo item in vehiculos)
            {
                Console.WriteLine(item.MostrarInfo());
            }



            // 1.
            //List<Vehiculo> vehiculos = new List<Vehiculo>() { };

            // 1.
            //vehiculos.Add(vehiculo);
            //vehiculos.Add(coche2);
            //vehiculos.Add(moto2);
            //vehiculos.Add(coche1);
            //vehiculos.Add(moto1);

            // 1.
            //foreach (Vehiculo item in vehiculos)
            //{
            //    if (item.GetType() == typeof(Moto))
            //    {
            //        Console.WriteLine(((Moto)item).MostrarInfoMoto());
            //    }
            //    else if(item.GetType() == typeof(Coche))
            //    {
            //        Console.WriteLine(((Coche)item).MostrarInfoCoche());

            //    } else
            //    {
            //        Console.WriteLine(item.MostrarInfo());
            //    }


            //}

        }
            
    }
}
