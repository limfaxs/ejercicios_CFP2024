namespace INSTANCIA_AUTO
{
    public class ClaseInstanciaAuto
    {
        /*
         Crear la clase de instancia Auto.

            La misma debe tener:
            A. Los atributos marca, cantCombustible, color.
            B. un constructor que inicialice todos los atributos.
            C. Solo metodos Get() para todos sus atributos.
            D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
            E. El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer o no la cantidad de kilometros
            recibo por parametro, tener en cuenta que para poder avanzar se debe tener conbustible
            y por cada litro de combustible se pueden 10km.
            F. En un proyecto de consola crear un objeto del tipo Auto, mostrar todos su valores 
            y dentro de un bucle repetitivo usar el metodo avanzar(), este debera repetirse hasta que el auto agote su combustible
            y se debera informar cuantas repeticiones logra realizar.
         */

        // Atributos
        private string marca;
        private int cantCombustible;
        private string color;

        // Constructor
        public ClaseInstanciaAuto(string marca, int cantCombustible, string color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }

        // Métodos Get
        public string GetMarca()
        {
            return marca;
        }

        public int GetCantCombustible()
        {
            return cantCombustible;
        }

        public string GetColor()
        {
            return color;
        }

        // Método AutoToString
        public override string ToString()
        {
            return $"Marca: {marca}, Combustible: {cantCombustible} litros, Color: {color}";
        }

        // Método Avanzar
        public bool Avanzar(int km)
        {
            int maxKm = cantCombustible * 10;
            if (km <= maxKm)
            {
                cantCombustible -= km / 10;
                return true;
            }
            else
            {
                return false;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Crear un objeto Auto
                ClaseInstanciaAuto miAuto = new ClaseInstanciaAuto("Toyota", 50, "Rojo");

                // Mostrar los valores iniciales
                Console.WriteLine("Valores iniciales del auto:");
                Console.WriteLine(miAuto);

                // Repetir el método Avanzar hasta que el auto agote su combustible
                int repeticiones = 0;
                while (miAuto.Avanzar(50))
                {
                    repeticiones++;
                }

                // Mostrar cuántas repeticiones se lograron antes de agotar el combustible
                Console.WriteLine($"El auto agotó su combustible después de {repeticiones} repeticiones.");
            }
        }

    }

}
