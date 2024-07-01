namespace LibreriaDeHerencia
{
    public class Perro: Animal // Agrego la Herencia. (Animal).
    {
        // Elimino los 3 atributos de la clase hija, por que ya los tengo en la clase padre. (Animal).
        //string nombre;
        //double peso;
        //int edad;
        string tipoDePelo;
        string raza;
        string dueño;

        public Perro(string nombre, double peso, int edad, string tipoDePelo, string raza, string dueño)
            :base(nombre,peso,edad) // LLamo al constructor (Base)
        {
            //Elimino los primeros 3 constructores. ya no hace falta por que puse el constructor (Base). De la clase padre (Animal)
            //this.nombre = nombre;
            //this.peso = peso;
            //this.edad = edad;
            this.tipoDePelo = tipoDePelo;
            this.raza = raza;
            this.dueño = dueño;
        }

             //Agrego la palabra "override"
        public override string EmitirSonido()
        {
            return "GUAUUU GUAUUU";
        }

        // Agregando un metodo propio de cada clase.
        // y si quiero que exista el polimorfismo. tengo que hacer lo siguiente.
        public override string EjercerAccion()
        {
            return "MORDER";
        }

        // EJEMPLO virtual: "Perro" tiene tres datos mas, asi que tendria que sobreescribir ese metodo como el virtual me lo permite.

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} Tipo de pelo: {tipoDePelo} Raza: {raza} Dueño: {dueño}";
        }


    }
}
