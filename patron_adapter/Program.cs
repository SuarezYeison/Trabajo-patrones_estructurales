﻿using patron_adapter.Adapters;
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
            var bitcoinAPI = new BitcoinAPI();

            // Crear adaptadores
            IPasarelaPago pasarelaPayPal = new AdaptadorPayPal(paypalAPI);
            IPasarelaPago pasarelaStripe = new AdaptadorStripe(stripeAPI);
            IPasarelaPago pasarelaBitcoin = new AdaptadorBitcoin(bitcoinAPI, "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"); // Dirección Bitcoin de ejemplo

            // Probar PayPal
            Console.WriteLine("\n--- Probando PayPal ---");
            bool resultadoPayPal = pasarelaPayPal.Pagar(150.75m);
            Console.WriteLine($"Resultado del pago: {resultadoPayPal}");

            if (resultadoPayPal)
            {
                bool reembolsoPayPal = pasarelaPayPal.Reembolsar("PAY-12345");
                Console.WriteLine($"Resultado del reembolso: {reembolsoPayPal}");
            }

            // Probar Stripe
            Console.WriteLine("\n--- Probando Stripe ---");
            bool resultadoStripe = pasarelaStripe.Pagar(200.50m);
            Console.WriteLine($"Resultado del pago: {resultadoStripe}");

            if (resultadoStripe)
            {
                bool reembolsoStripe = pasarelaStripe.Reembolsar("ch_abc123");
                Console.WriteLine($"Resultado del reembolso: {reembolsoStripe}");
            }

            // Probar Bitcoin
            Console.WriteLine("\n--- Probando Bitcoin ---");
            bool resultadoBitcoin = pasarelaBitcoin.Pagar(0.05m); // Monto pequeño en USD para el ejemplo
            Console.WriteLine($"Resultado del pago: {resultadoBitcoin}");

            if (resultadoBitcoin)
            {
                bool reembolsoBitcoin = pasarelaBitcoin.Reembolsar("tx_abc123def456");
                Console.WriteLine($"Resultado del reembolso: {reembolsoBitcoin}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
