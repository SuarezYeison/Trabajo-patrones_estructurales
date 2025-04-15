using patron_adapter.Adapters;
using patron_adapter.APIsExternas;
using patron_adapter.Interfaces;
using System;

namespace patron_adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMOSTRACIÓN DEL PATRÓN ADAPTER");
            Console.WriteLine("-------------------------------\n");

            // Crear instancias de las APIs externas
            var paypalAPI = new PayPalAPI();
            var stripeAPI = new StripeAPI();

            // Crear adaptadores
            IPasarelaPago pasarelaPayPal = new AdaptadorPayPal(paypalAPI);
            IPasarelaPago pasarelaStripe = new AdaptadorStripe(stripeAPI);

            // Probar PayPal
            Console.WriteLine("\n--- Probando PayPal ---");
            bool resultadoPayPal = pasarelaPayPal.Pagar(150.75m);
            Console.WriteLine($"Resultado del pago: {resultadoPayPal}");

            if (resultadoPayPal)
            {
                pasarelaPayPal.Reembolsar("PAY-12345");
            }

            // Probar Stripe
            Console.WriteLine("\n--- Probando Stripe ---");
            bool resultadoStripe = pasarelaStripe.Pagar(200.50m);
            Console.WriteLine($"Resultado del pago: {resultadoStripe}");

            if (resultadoStripe)
            {
                pasarelaStripe.Reembolsar("ch_abc123");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
