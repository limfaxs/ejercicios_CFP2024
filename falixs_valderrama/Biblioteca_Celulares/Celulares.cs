namespace Biblioteca_Celulares
{
    public class Celulares
    {
        //Atributos:(van a ser privados en este caso -si no le pongo nada asume que son privados)

        private string Marca;
        private string Modelo;
        private string empresa;
        private int capacidadAlmacenamiento;
        private int cantidadRam;
        private string Procesador;
        private int Bateria;


        //Constructor:el unico metodo que no tenia retorno (void)
        //constructor va a ser de instancia
        //no tiene retorno y lleva siempre el nombre de la clase
        //puedo tener varios constructores pero respetando los parametros
        public Celulares(string Marca, string Modelo, string empresa, int capacidadAlmacenamiento, int cantidadaRam, string Procesador, int Bateria)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.empresa = empresa;
            this.capacidadAlmacenamiento = capacidadAlmacenamiento;
            this.cantidadRam = cantidadaRam;
            this.Procesador = Procesador;
            this.Bateria = Bateria;

        }
        //Metodos Getters y Setters-> Permitir consultar(get)
        //y/o modificar atributos(set insertar o agregar)
        //tienen que hacer referencia al atributo con el q estan trabajando
        public string GetMarca()
        {
            return Marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public string GetEmpresa()
        {
            return empresa;
        }
        public int GetCapacidadAlmacenamiento()
        {
            return capacidadAlmacenamiento;
        }
        public int GetCantidadRam()
        {
            return cantidadRam;
        }
        public string GetProcesador()
        {
            return Procesador;
        }
        public int GetBateria()
        {
            return Bateria;
        }

        // los set no tienen retorno;
        public void SetBateria(int comiensoDeBateria)
        {
            Bateria = comiensoDeBateria;
        }
        public void SetBateria(int FinDeBateria)
        {
            Bateria = FinDeBateria;
        }

        //Metodos //Comportamientos:
        public string ColectivoToString()
        {
            return $"Patente: {patente} - linea: {linea} - empresa: {empresa} - capacidad: {capacidad} - cabecera: {cabecera} - terminal: {terminal}"; //-Cantidad de pasajeros:{cantidadDePasajeros}";

        }

        public bool SubirPasajeros(int cantidad)
        {
            bool puedenSubir = false;
            if ((this.capacidad > this.cantidadDePasajeros) && (this.cantidadDePasajeros + cantidad <= capacidad))
            {
                this.cantidadDePasajeros += cantidad;
                puedenSubir = true;
            }
            return puedenSubir;
        }
    }
}
