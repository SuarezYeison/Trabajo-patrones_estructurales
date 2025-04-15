using patron_adapter.APIsExternas;
using patron_adapter.Interfaces;

namespace patron_adapter.Adapters
{
    public class AdaptadorPayPal : IPasarelaPago
    {
        private readonly PayPalAPI _paypal;

        public AdaptadorPayPal(PayPalAPI paypal)
        {
            _paypal = paypal;
        }

        public bool Pagar(decimal monto)
        {
            return _paypal.RealizarPago(monto, "USD");
        }

        public bool Reembolsar(string idTransaccion)
        {
            return _paypal.SolicitarReembolso(idTransaccion);
        }
    }
}
