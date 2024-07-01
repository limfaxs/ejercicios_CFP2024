using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeEmpleado
{
    public class Analista : Empleado
    {
        public string Especialidad { get; set; }
        public int Proyectos { get; set; }

        public override void Trabajar()
        {
            Console.WriteLine("El analista está analizando los datos.");
        }

        public override double CalcularBonificacion()
        {
            // Bonificación específica para analistas (10% del salario)
            return Salario * 0.10;
        }

        public void PrepararInforme()
        {
            Console.WriteLine("El analista está preparando informes de sus proyectos.");
        }

        public override double SalarioTotal()
        {
            return Salario + CalcularBonificacion();
        }
    }
}
