using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{

    //No van a tener implementacion

    //Si quiero implementar en algun momento algo del tipo "Animal". No uso la palabra "abstract"

    //Para usarla como plantilla
    public abstract class Animal
    {
        protected string nombre;
        protected double peso;
        protected int edad;

        public Animal(string nombre, double peso, int edad)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.edad = edad;
        }

        // Si quiero que sea sobreescrito sin que yo lo implemente lo dejo "abstrac".

        // Como es abstract no puede tener implemntacion
        public abstract string EmitirSonido();
        // Las llaves y el return se van
        //{
        //    return "RRRRRRRRRRR";
        //}


        // Si quiero que tenga una implementacion pero que a su vez cada uno de ellos pueda sobreescribirlo, uso el metodo "Virtual".

        //     //Agrego la palabra "Virtual" para poder ser sobreescrito en cualquiera de las clases derivadas o (hijas).
        //public virtual string EmitirSonido()
        //{
        //    return "RRRRRRRRRRR";
        //}

        // Primero lo tengo que crear en la clase padre"ANIMAL".
        // Agregando un metodo propio de cada clase.
        // y si quiero que exista el polimorfismo. tengo que hacer lo siguiente.

        public abstract string EjercerAccion();

        // EJEMPLO: de virtual
        // Como es "virtual" no estoy obligado a implementarlo en todos lados.
        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} Peso: {peso} Edad: {edad}";



        }
    }


}
