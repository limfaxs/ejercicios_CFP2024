namespace OBJETOS_EJERCICIO1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

            Deberá tener los atributos:

            Titular: que contendrá la razón social del titular de la cuenta.
            TipoDeCuenta: que contendra información sobre el tipo de cuenta(sueldo, corriente, dolares)
            Saldo:  que será un número decimal que representa al monto actual de dinero en la cuenta.

            Construir los siguientes métodos para la clase:

            Un constructor que permita inicializar todos los atributos.
            Un método getter para cada atributo.
            CuentaToString: retornará una cadena de texto con todos los datos de la cuenta.
            IngresarDinero: recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            RetirarDinero: recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.

            En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando cómo va variando el saldo.

             */

           

namespace MiBiblioteca
    {
        public class Cuenta
        {
            public string Titular { get; private set; }
            public string TipoDeCuenta { get; private set; }
            public decimal Saldo { get; private set; }

            // Constructor
            public Cuenta(string titular, string tipoDeCuenta, decimal saldoInicial)
            {
                Titular = titular;
                TipoDeCuenta = tipoDeCuenta;
                Saldo = saldoInicial;
            }

            // Método para convertir la cuenta a una cadena de texto
            public string CuentaToString()
            {
                return $"Titular: {Titular}, Tipo de Cuenta: {TipoDeCuenta}, Saldo: {Saldo}";
            }

            // Método para ingresar dinero a la cuenta
            public void IngresarDinero(decimal monto)
            {
                if (monto > 0)
                {
                    Saldo += monto;
                    Console.WriteLine($"Se ingresaron {monto} a la cuenta. Saldo actual: {Saldo}");
                }
                else
                {
                    Console.WriteLine("No se puede ingresar un monto negativo.");
                }
            }

            // Método para retirar dinero de la cuenta
            public void RetirarDinero(decimal monto)
            {
                Saldo -= monto;
                Console.WriteLine($"Se retiraron {monto} de la cuenta. Saldo actual: {Saldo}");
            }
        }
    }
}
   

