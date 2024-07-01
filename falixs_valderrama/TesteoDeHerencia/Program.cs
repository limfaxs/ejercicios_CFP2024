using LibreriaDeHerencia;

namespace TesteoDeHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializamos 
            //(1) DE UNA FORMA
            //Puedo guardarlas en variable de tipo padre "Animal"(GENERICO). Pero el constructor sigue siendo el mismo.(Loro,Gato,Perro).
            //Generico         //Constructor
            Animal loro1 = new Loro("Pepe", 500, 30);
            Animal gato1 = new Gato("Minino", 5000, 5, "Naranja", "Siameses");
            Animal perro1 = new Perro("Betoben", 20000, 7, "Corto", "Pastor aleman", "jorge");

            //Loro loro1 = new Loro("Pepe", 500, 30);
            //Gato gato1 = new Gato("Minino", 5000, 5, "Naranja", "Siameses");
            //Perro perro1 = new Perro("Betoben", 20000, 7, "Corto", "Pastor aleman", "jorge");

            // Animal animal1 = new Animal("Generico", 0, 0); //Me maraca como error ya que la clase es "abstract". Ejemplo.

            //Tambien puedo instaciar mi lista y hacerla anonima
            // Como son animales se puede de otra forma
            //(2) DE OTRA FORMA
            //List<Animal> animales = new List<Animal>();
            //{
            //    new Loro("Pepe", 500, 30);
            //    new Gato("Minino", 5000, 5, "Naranja", "Siameses");
            //    new Perro("Betoben", 20000, 7, "Corto", "Pastor aleman", "jorge");

            //};


            // Tengo mi lista de animales
            List<Animal> animales = new List<Animal>();

            // Guardo mi lista de animales
            animales.Add(perro1);
            animales.Add(loro1);
            animales.Add(gato1);
            // animales.Add(animal1); //Ejemplo de "Generico"

            //Empiezo a recorrer
            foreach (Animal animal in animales)
            {
                //Condicional
                //if (animal is Perro)
                //{
                //    Console.WriteLine(((Perro)animal).EmitirSonido());
                //}
                //else if (animal is Gato)
                //{
                //    Console.WriteLine(((Gato)animal).EmitirSonido());
                //}
                //else if(animal is Loro)
                //{
                //    Console.WriteLine(((Loro)animal).EmitirSonido());
                //}
                // Console.WriteLine($"Tipo de animal: {animal.GetType().Name} Sonido: {animal.EmitirSonido()}");

                // EJEMPLO: 1
                // Tambien lo tengo que implementar aca.
                // Agregando un metodo propio de cada clase.
                // y si quiero que exista el polimorfismo. tengo que hacer lo siguiente
                // Console.WriteLine($"Tipo de animal: {animal.GetType().Name} Sonido: {animal.EmitirSonido()} Accion: {animal.EjercerAccion()}");

                // EJEMPLO: 2
                // Y si yo quiero que cada uno tenga su propio metodo en cada clase
                // ya no hay polimorfismo
                //Console.WriteLine($"Tipo de animal: {animal.GetType().Name} Sonido: {animal.EmitirSonido()} Accion: {animal.EjercerAccion()}");
                //if (animal is Gato) 
                //{

                //}

                // Ejemplo de virtual.
                Console.WriteLine($"Tipo de animal: {animal.GetType().Name} {animal.MostrarInfo()}");





            }




        }
    }
}
