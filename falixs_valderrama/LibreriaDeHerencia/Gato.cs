using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public class Gato: Animal // Agrego la Herencia. (Animal).
    {
        // Elimino los 3 atributos de la clase hija, por que ya los tengo en la clase padre. (Animal).
        //string nombre;
        //double peso;
        //int edad;
        string colorDePelo;
        string raza;

        public Gato(string nombre, double peso, int edad, string colorDePelo , string raza)
            :base(nombre,peso,edad) // LLamo al constructor (Base)
        {
            //Elimino los 3 primeros constructores. ya no hace falta por que puse el constructor (Base). De la clase padre (Animal).
            //this.nombre = nombre;
            //this.peso = peso;
            //this.edad = edad;
            this.colorDePelo = colorDePelo;
            this.raza = raza;
        }

             //Agrego la palabra "override"
        public override string EmitirSonido()
        {
            return "MIAUUU MIAUUU";
        }

        // Agregando un metodo propio de cada clase.
        // y si quiero que exista el polimorfismo. tengo que hacer lo siguiente.
        public override string EjercerAccion()
        {
            return "Rasguñar";
        }

        // EJEMPLO virtual: "Gato" tiene dos datos mas, asi que tendria que sobreescribir ese metodo como el virtual me lo permite.

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} Colo de pelo: {colorDePelo} Raza: {raza}";
        }

    }
}
