namespace EJERCICIO5
{
    internal class Ejercicio5_ENTRADAS_SALIDAS
    {
        static void Main(string[] args)
        {
            /*
            /// E/S
            /// En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología.
            /// El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
            /// Área Porcentaje del presupuesto
            /// Cardiología         40 %
            /// Pediatría           45 %
            /// Traumatología       15 %
            */

            Double presupuestoAnual;
            Double porcentajeCardio;
            Double porcentajePediatria;
            Double porcentajeTrauma;
            Double valorPorcentajeCardio;
            Double valorPorcentajePediatria;
            Double valorPorcentajeTrauma;

            valorPorcentajeCardio = 40;
            valorPorcentajePediatria = 45;
            valorPorcentajeTrauma = 15;

            Console.Write("Ingrese presupuesto anual: ");
            presupuestoAnual = Double.Parse(Console.ReadLine());

            porcentajeCardio = presupuestoAnual * valorPorcentajeCardio / 100;
            porcentajePediatria = presupuestoAnual * valorPorcentajePediatria / 100;
            porcentajeTrauma = presupuestoAnual * valorPorcentajeTrauma / 100;

            Console.WriteLine(" A cardio le corresponde: " + porcentajeCardio);
            Console.WriteLine(" A peddiatria le corresponde: " + porcentajePediatria);
            Console.WriteLine(" A trauma le corresponde: " + porcentajeTrauma);
            Console.ReadKey();

        }
    }
}
