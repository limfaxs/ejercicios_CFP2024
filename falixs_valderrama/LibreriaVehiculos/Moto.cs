using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVehiculos
{
    // si no quiero que hereden mas de coche lo agrego "sealed"
    public class Moto: Vehiculo // Aplico herencia ": y llamo a la clase de la cual quiero heredar (Vehiculo)".
    {
        // Tambien puedo agragale "protected" si quisiera que se hereden de Moto"
        string tipo;
        int cilindrada;

        // Agrego los atributos de la  clase padre "string marca, string modelo".
        public Moto(string marca, string modelo, string tipo, int cilindrada) // LOs recivo por parametros "string marca, string modelo".
                                                                              // Tenemos que sobreescribir el constructor "(:) la palabra reservada (base) y {()} ahi lo tengo que pasar los atributos marca y modelo".
            : base("yamaha","2000") //DETALLES: Como son string los 2. facilmente puedo pasarlos harkodeados ("yamaha","2000").
        {
            this.tipo = tipo;
            this.cilindrada = cilindrada;
        }

        // 1.
        // Personalizo y lo hago que sea propio de "Moto".
        //public string conducirMoto()// Agrego "Moto"
        //{
        //    return "Estoy conduciendo una moto";
        //}

        // 2. Agrego el metodo polimorfico.
        // Le saco la palabra "Moto". osea queda: el metododo "Conducir".
        // Agrego la palabra "override".
        public override string Conducir()
        {
           //return "Estoy conduciendo una moto";
            return $"{base.Conducir()} una moto";
        }

        public string HacerCaballito()
        {
            return "La moto esta haciendo un caballito";
        }

        // 1.
        //public string MostrarInfoMoto()
        //{
        //    //return $"marca y modelo - Cant. Puertas: {numeroPuertas} - capacidad del maletero: {capacidadMaletero}";

        //    // Agrego el "this" a los atributos propios de la clase que estoy trabajando.
        //    // Si quiero acceder a la clase "base", solo tengo que agarrar y utilizar la palabra "base"
        //    //return $"Marca: {base.marca} - modelo: {base.modelo} - Cant. Puertas: {this.numeroPuertas} - capacidad del maletero: {this.capacidadMaletero}";

        //    // Puedo remplasarlo y llamar al metodo de la clase "base.MostrarInfo()"
        //      return $"{base.MostrarInfo()} - Tipo: {this.tipo} - Cilindrada: {this.cilindrada}";
        //}


        // 2. Agregamos (polimorfismo).
        // Agregamos la palabra "override".
        public override string MostrarInfo() // Sacamos la palabra "Moto"
        {
            return $"{base.MostrarInfo()} - Tipo: {this.tipo} - Cilindrada: {this.cilindrada}";
        }

    }
}
