using System.Drawing;
using System.Text;

namespace LibreriaDeLapiceras
{
    public class Lapicera
    {

        // Atributos
        Color color;
        int precio;
        string marca;
        int nivelDeTinta;

        public Color Color { get => color; }
        public int Precio { get => precio; }
        public string Marca { get => marca; }
        public int NivelDeTinta { get => nivelDeTinta;  }



        //public string Color { get; }
        //public decimal Precio { get; }
        //public string Marca { get; }
        //public int NivelDeTinta { get; private set; }

        // Constructor
        //public Lapicera(string color, decimal precio, string marca)
        //{
        //    Color = color;
        //    Precio = precio;
        //    Marca = marca;
        //    NivelDeTinta = 100;  // Todas las lapiceras se crean con el nivel de tinta al 100
        //}


        // Constructor
        public Lapicera(Color color, decimal precio, string marca, int nivelDeTinta)
        {
            this.color = color;
            this.precio = (int)precio;
            this.marca = marca;
            this.nivelDeTinta = nivelDeTinta;
        }


        // Método ToString() sobrescrito para mostrar todos los valores
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Precio: {Precio}");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Nivel de tinta: {NivelDeTinta}%");
            return sb.ToString();
        }

        //
        public string LapiceraToString()
        {
            return $"Color: {Color}, Precio: {precio}, marca: {marca}, NivelDeTinta: {nivelDeTinta}";
            //StringBuilder sb = new StringBuilder();
        }

        // Método para escribir con la lapicera
        public bool Escribir(int cantLetras)
        {
            if (NivelDeTinta >= cantLetras)
            {
                nivelDeTinta -= cantLetras;
                return true;  // Hay suficiente tinta para escribir
            }
            else
            {
                return false;  // No hay suficiente tinta para escribir
            }
        }

        // Método para recargar la lapicera (restablecer nivel de tinta a 100)
        public void Recargar()
        {
            nivelDeTinta = 100;
        }
    }
}
