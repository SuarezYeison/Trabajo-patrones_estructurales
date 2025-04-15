using System;

namespace patron_adapter.APIsExternas
{
    public class PayPalAPI
    {
        public bool RealizarPago(decimal monto, string moneda)
        {
            Console.WriteLine($"Pagando {monto} {moneda} via PayPal");
            return true;
        }

        public bool SolicitarReembolso(string idPago)
        {
            Console.WriteLine($"Reembolsando pago PayPal ID: {idPago}");
            return true;
        }
    }
}
