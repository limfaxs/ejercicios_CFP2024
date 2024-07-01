using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVehiculos
{
// "internal" Lo cambiamos por un "public" por que queremos que sea visible por cualquier otro proyecto. No solamente dentro de la (libreria).
    public class Coche: Vehiculo
    {
        int numeroPuertas;
        double capacidadMaletero;

        // Agrego los atributos de la  clase padre "string marca, string modelo".
        public Coche(string marca, string modelo, int numeroPuertas, double capacidadMaletero)
            : base(marca,modelo) // Agrego la clase "base(marca, modelo)" 
        {
            this.numeroPuertas = numeroPuertas;
            this.capacidadMaletero = capacidadMaletero;
        }
        // Le agrego coche. osea queda: "CondicirCoche".
        // 1.
        //public string ConducirCoche()
        //{
        //    return "Estoy conduciendo un coche";
        //}

        // 2. Agrego el metodo polimorfico.
        // Le saco la palabra "Coche". osea queda: el metododo "Conducir".
        // Agrego la palabra "override".
        public override string Conducir() // Agrego "Coche".
        {
           // return "Estoy conduciendo un coche";
            return  $"{base.Conducir()} un coche";
        }
        
        public string AbrirMaletero()
        {
            return "El maletero del coche se ha habierto";
        }

        // 1.
        //public string MostrarInfoCoche()
        //{
        //    // 1.
        //    //return $"marca y modelo - Cant. Puertas: {numeroPuertas} - capacidad del maletero: {capacidadMaletero}";

        //    // Agrego el "this" a los atributos propios de la clase que estoy trabajando.
        //    // Si quiero acceder a la clase "base", solo tengo que agarrar y utilizar la palabra "base"
        //    return $"Marca: {base.marca} - modelo: {base.modelo} - Cant. Puertas: {this.numeroPuertas} - capacidad del maletero: {this.capacidadMaletero}";

        //    // Puedo remplasarlo y llamar al metodo de la clase "base.MostrarInfo()"
        // //   return $"{base.MostrarInfo()} - Cant. Puertas: {this.numeroPuertas} - capacidad del maletero: {this.capacidadMaletero}";
            
        //}

        // 2. Agregamos (polimorfismo)
        // Agregamos la palabra "override".
        // sacamos la palabra "Coche"
        public override string MostrarInfo() // Sacamos la palabra "Coche".
        {
            return $"Marca: {base.marca} - modelo: {base.modelo} - Cant. Puertas: {this.numeroPuertas} - capacidad del maletero: {this.capacidadMaletero}";
        }


    }
}
