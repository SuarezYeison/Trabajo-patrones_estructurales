using patron_adapter.APIsExternas;
using patron_adapter.Interfaces;

namespace patron_adapter.Adapters
{
    public class AdaptadorBitcoin : IPasarelaPago
    {
        private readonly BitcoinAPI _bitcoin;
        private readonly string _direccionBitcoin;

        public AdaptadorBitcoin(BitcoinAPI bitcoin, string direccionBitcoin)
        {
            _bitcoin = bitcoin;
            _direccionBitcoin = direccionBitcoin;
        }

        public bool Pagar(decimal monto)
        {
            double cantidadBTC = _bitcoin.ConvertirUSDaBTC(monto);
            string hashTransaccion = _bitcoin.EnviarBTC(cantidadBTC, _direccionBitcoin);
            return !string.IsNullOrEmpty(hashTransaccion);
        }

        public bool Reembolsar(string idTransaccion)
        {
            return _bitcoin.DevolverBTC(idTransaccion, _direccionBitcoin);
        }
    }
}