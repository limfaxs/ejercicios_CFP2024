namespace ClaseDeComputadora
{
    public class Computadora
    {
        // Atributos
        private List<string> programas;

        // Propiedades
        public int MemoriaRam; //{ get; }
        public int CapacidadDisco; // { get; }
        public string Procesador; // { get; }
        public string SistemaOperativo; // { get; }
        public string Programas => string.Join(", ", programas);

        // Constructor privado
        private Computadora()
        {
            programas = new List<string>();
        }

        // Constructor público
        public Computadora(int memoriaRam, int capacidadDisco, string procesador, string sistemaOperativo)
            : this()
        {
            MemoriaRam = memoriaRam;
            CapacidadDisco = capacidadDisco;
            Procesador = procesador;
            SistemaOperativo = sistemaOperativo;
        }

        // Método para agregar programa a la lista
        public void AgregarPrograma(string programa)
        {
            programas.Add(programa);
        }

        // Método estático para obtener lista de procesadores
        public static List<string> ListadoDeProcesadores()
        {
            return new List<string>
        {
            "Intel Core i7",
            "AMD Ryzen 5",
            "Apple M1",
            "Qualcomm Snapdragon",
            "ARM Cortex-A76"
        };
        }
        ////int CapacidadDeDisco;
        ////int memoriaRam;
        ////string Procesador;
        ////string programas;
        ////string sistemaOperativo;

        ////public Computadora(int capacidadDeDisco, int memoriaRam, string procesador, string programas, string sistemaOperativo)
        ////{
        ////    CapacidadDeDisco = capacidadDeDisco;
        ////    this.memoriaRam = memoriaRam;
        ////    Procesador = procesador;
        ////    this.programas = programas;
        ////    this.sistemaOperativo = sistemaOperativo;
        ////}

        ////public int CapacidadDeDisco1 { get => CapacidadDeDisco; set => CapacidadDeDisco = value; }
        ////public int MemoriaRam { get => memoriaRam; set => memoriaRam = value; }
        ////public string Procesador1 { get => Procesador; set => Procesador = value; }
        ////public string Programas { get => programas; set => programas = value; }
        ////public string SistemaOperativo { get => sistemaOperativo; set => sistemaOperativo = value; }


    }




}
