namespace LibreriaVehiculos
{
    // Creamos una clase
    public class Vehiculo
    {
        // Creamos los atributos
     // Agregamos "protected"
        protected string marca;
        protected string modelo;

        // Creamos el constructor
        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        /// Creamos dos metodos

        // Metodo "uno"
        // Agregamos "public"
        // 1.
        //public string conducir()
        //{
        //    return "Estoy conduciendo";
        //}

        // 2.
        // Si quiero agregar(polimorfismo) agrego la palabra reservada "virtual" a la clase padre. (vehiculo).
        public virtual string Conducir()
        {
            return "Estoy conduciendo";
        }

        // 1.
        // Metodo "dos"
        // Agrgamos "public"
        //public string MostrarInfo()
        //{
        //    return $"Marca: {marca} - Modelo: {modelo} ";
        //}

        // 2.
        // Si quiero agregar(polimorfismo) agrego la palabra reservada "virtual" a la clase padre. (Vehiculo).

        public virtual string MostrarInfo()
        {
            return $"Marca: {marca} - Modelo: {modelo} ";
        }


    }
}
