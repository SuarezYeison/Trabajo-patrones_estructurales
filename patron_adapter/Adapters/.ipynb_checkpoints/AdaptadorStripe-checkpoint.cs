using patron_adapter.APIsExternas;
using patron_adapter.Interfaces;

namespace patron_adapter.Adapters
{
    public class AdaptadorStripe : IPasarelaPago
    {
        private readonly StripeAPI _stripe;

        public AdaptadorStripe(StripeAPI stripe)
        {
            _stripe = stripe;
        }

        public bool Pagar(decimal monto)
        {
            int montoCentavos = (int)(monto * 100);
            string idCargo = _stripe.CrearCargo(montoCentavos, "Compra");
            return !string.IsNullOrEmpty(idCargo);
        }

        public bool Reembolsar(string idTransaccion)
        {
            return _stripe.DevolverCargo(idTransaccion);
        }
    }
}
