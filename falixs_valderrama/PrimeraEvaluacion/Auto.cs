
using System.Drawing;

///using System.Drawing;
namespace PrimeraEvaluacion
{
    public class Auto
    {
        /*
            Crear la clase de instancia Auto.

         La misma debe tener:
         A. Los atributos marca, cantCombustible, color.
         B. un constructor que inicialice todos los atributos.
         C. Solo metodos Get() para todos sus atributos.
         D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
         E. El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer o no la cantidad de kilometros recibo por parametro, 
            tener en cuenta que para poder avanzar se debe tener conbustible y por cada litro de combustible se pueden recorrer 10km
         F.En un proyecto de consola crear un objeto del tipo Auto, mostrar todos su valores y dentro de un bucle repetitivo usar el metodo avanzar(),
           este debera repetirse hasta que el auto agote su combustible y se debera informar cuantas repeticiones logra realizar.
         */

        private string marca;
        private double cantCombustible;
        private Color color;

        public Auto(string marca, double cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }
        //
        //public Auto(string marca, string Combustible, string color)
        //{
        //    this.ConvertirStringEnCombustible(Combustible);
        //    this.ConvertirStrinEnColor(color);
        //    this.marca = marca;

        //}
        public Auto(string marca, string cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = double.Parse(cantCombustible);
            this.color = color;
        }
        //
        public bool SetColor(Color nuevoColor)
        {
            bool retorno = false;
            if (nuevoColor == Color.Green || nuevoColor == Color.Red || nuevoColor == Color.Blue)
            {
                this.color = nuevoColor;
                retorno = true;
            }
            return retorno;
        }

        //
        public bool SetCantCombustible(double nuevoValor)
        {
            bool retorno = false;

            if (nuevoValor > 0 && nuevoValor <= 100)
            {
                this.cantCombustible = nuevoValor;
            }

            return retorno;
        }

        //

        public string GetMarca()
        {
            return marca;
        }
        public double GetcantCombustible()
        {
            return cantCombustible;
        }
        public Color Getcolor()
        {
            return color;
        }
        public string AutoToString()
        {
            return $"marca: {marca} - cant. de combustible: {cantCombustible} - color: {color.Name}";
        }

        public bool Avanzar(int km)
        {
            bool retorno = false;

            double combustibleNecesario = (double)km / 10;
            if (cantCombustible > 0 && cantCombustible >= combustibleNecesario)
            {
                cantCombustible -= combustibleNecesario;

                retorno = true;
            }

            return retorno;

        }
        //
        public bool ConvertirStringEnCombustible(string combustible)
        {
            bool retorno = false;
            if (double.TryParse(combustible, out double combValido))
            {
                this.cantCombustible = combValido;
                retorno = true;
            }

            return retorno;

        }

        //public static bool ConvertirStringAInt(string valorAconvertir, out double combValido)
        //{
        //    return double.TryParse(valorAconvertir,out combValido);
        //}

        //
        //public bool ConvertirStrinEnColor(string nuevoColor)
        //{
        //    bool retorno = true;

        //    // switch (nuevoColor)
        //    switch (nuevoColor.ToLower())
        //    {
        //        case "rojo":
        //            this.color = Color.Red;
        //            break;
        //        case "azul":
        //            this.color = Color.Blue;
        //            break;
        //        case "negro":
        //            this.color = Color.Black;
        //            break;
        //        default:
        //            retorno = false;
        //            break;

        //    }


        //    return retorno;
        //    //
        //}
        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>() {
            Color.Black,Color.Red,Color.Yellow,Color.Violet,Color.Blue,Color.Green,Color.Orange
            };

            return list;
        }
        
        //public static List<string> ColoresValidos()
        //{
        //    List<string> list = new List<string>() {
        //    "Azul", "Rojo", "Verde", "Amarillo","Gris" };


        //    return list;
        //}

        public override string ToString()
        {
            return this.AutoToString();
        }

    }


}
