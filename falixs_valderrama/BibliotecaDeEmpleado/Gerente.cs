using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeEmpleado
{
    public class Gerente : Empleado
    {
        public int NumeroEmpleados { get; set; }

        public override void Trabajar()
        {
            Console.WriteLine("El gerente está gestionando el departamento.");
        }

        public override double CalcularBonificacion()
        {
            // Bonificación específica para gerentes (25% del salario)
            return Salario * 0.25;
        }

        public string Planificar()
        {
            return $"El gerente está planificando para {NumeroEmpleados} empleados.";
        }

        public override double SalarioTotal()
        {
            return Salario + CalcularBonificacion();
        }
    }

}

