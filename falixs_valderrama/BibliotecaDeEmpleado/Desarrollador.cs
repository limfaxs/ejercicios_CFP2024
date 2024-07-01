using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeEmpleado
{
    public class Desarrollador : Empleado
    {
        public string LenguajeProgramacion { get; set; }
        public int Experiencia { get; set; }

        public override void Trabajar()
        {
            Console.WriteLine("El desarrollador está escribiendo código.");
        }

        public override double CalcularBonificacion()
        {
            // Bonificación específica para desarrolladores (15% del salario)
            return Salario * 0.15;
        }

        public void DepurarCodigo()
        {
            Console.WriteLine($"El desarrollador está depurando código en {LenguajeProgramacion}.");
        }

        public override double SalarioTotal()
        {
            return Salario + CalcularBonificacion();
        }

    }      

           
}
