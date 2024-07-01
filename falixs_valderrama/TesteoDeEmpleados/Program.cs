using LibreriaDeEmpleado;

namespace TesteoDeEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Gerente, Desarrollador y Analista
            Gerente gerente = new Gerente
            {
                Nombre = "Juan Pérez",
                Salario = 5000,
                Departamento = "IT",
                Antiguedad = 5,
                NumeroEmpleados = 10
            };

            Desarrollador desarrollador = new Desarrollador
            {
                Nombre = "María López",
                Salario = 4000,
                Departamento = "Desarrollo",
                Antiguedad = 3,
                LenguajeProgramacion = "C#",
                Experiencia = 7
            };

            Analista analista = new Analista
            {
                Nombre = "Pedro Ramirez",
                Salario = 4500,
                Departamento = "Análisis",
                Antiguedad = 4,
                Especialidad = "Análisis de datos",
                Proyectos = 8
            };

            // Llamar a métodos específicos de cada clase derivada
            Console.WriteLine("== Trabajos ==");
            gerente.Trabajar();
            desarrollador.Trabajar();
            analista.Trabajar();

            Console.WriteLine("\n== Información del empleado ==");
            gerente.MostrarInfo();
            Console.WriteLine($"Bonificación: {gerente.CalcularBonificacion():C}");
            Console.WriteLine($"Salario Total: {gerente.SalarioTotal():C}");
            Console.WriteLine(gerente.Planificar());

            Console.WriteLine("\n== Información del empleado ==");
            desarrollador.MostrarInfo();
            Console.WriteLine($"Bonificación: {desarrollador.CalcularBonificacion():C}");
            Console.WriteLine($"Salario Total: {desarrollador.SalarioTotal():C}");
            desarrollador.DepurarCodigo();

            Console.WriteLine("\n== Información del empleado ==");
            analista.MostrarInfo();
            Console.WriteLine($"Bonificación: {analista.CalcularBonificacion():C}");
            Console.WriteLine($"Salario Total: {analista.SalarioTotal():C}");
            analista.PrepararInforme();
        }
    }
}
