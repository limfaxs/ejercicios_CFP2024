

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeEmpleado
{
    public abstract class Empleado
    {
        // Atributos comunes a todos los empleados
        string nombre;
        double salario;
        string departamento;
        int antiguedad;
        //public string Nombre { get; set; }
        //public double Salario { get; set; }
        //public string Departamento { get; set; }
        //public int Antiguedad { get; set; }

        // Método abstracto que deberá ser implementado por las clases derivadas
        public abstract void Trabajar();

        // Método virtual para mostrar información básica del empleado
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Salario: {salario:C}");
            Console.WriteLine($"Departamento: {departamento}");
            Console.WriteLine($"Antigüedad: {antiguedad} años");
        }
        //public virtual void MostrarInfo()
        //{
        //    Console.WriteLine($"Nombre: {Nombre}");
        //    Console.WriteLine($"Salario: {Salario:C}");
        //    Console.WriteLine($"Departamento: {Departamento}");
        //    Console.WriteLine($"Antigüedad: {Antiguedad} años");
        //}

        // Método virtual para calcular bonificación base (por defecto es 0)
        public virtual double CalcularBonificacion()
        {
            return 0;
        }

        // Método abstracto para calcular el salario total
        public abstract double SalarioTotal();
    }

}




