using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public class Loro: Animal
    {
        // Los atributos los elimino por que ya viene de la clase padre. (Animal).
        //string nombre;
        //double peso;
        //int edad;

        public Loro(string nombre, double peso, int edad)
            : base(nombre, peso, edad)// LLamo al constructor (Base)
        {
            //Lo elimino, ya no hace falta por que puse el constructor (Base). De la clase padre (Animal).
            //this.nombre = nombre;
            //this.peso = peso;
            //this.edad = edad;
        }

        //Agrego la palabra "override"
        public override string EmitirSonido()
        {
            return "PRRRRRR PRRRRRR";
        }

        // Agregando un metodo propio de cada clase.
        // y si quiero que exista el polimorfismo. tengo que hacer lo siguiente.
        public override string EjercerAccion()
        {
            return "Volar";
        }

        // Ejemplo virtual: Como tiene los mismos datos que la clase padre (Animal) no hace falta que lo implemente.
    }
}
