using System;

namespace patron_adapter.APIsExternas
{
    public class BitcoinAPI
    {
        public string EnviarBTC(double cantidadBTC, string direccionBitcoin)
        {
            Console.WriteLine($"BitcoinAPI: Enviando {cantidadBTC} BTC a la dirección {direccionBitcoin}");
            // Simulación de envío de Bitcoin
            if (cantidadBTC > 0 && !string.IsNullOrEmpty(direccionBitcoin))
            {
                Console.WriteLine("BitcoinAPI: Transacción completada exitosamente");
                return $"tx_{Guid.NewGuid().ToString("N")}"; // Simula un hash de transacción
            }
            Console.WriteLine("BitcoinAPI: Error - Transacción fallida");
            return string.Empty;
        }

        public bool VerificarTransaccion(string hashTransaccion)
        {
            Console.WriteLine($"BitcoinAPI: Verificando transacción {hashTransaccion}");
            // Simulación de verificación de transacción
            bool resultado = !string.IsNullOrEmpty(hashTransaccion);
            Console.WriteLine($"BitcoinAPI: Transacción {(resultado ? "válida" : "inválida")}");
            return resultado;
        }

        public bool DevolverBTC(string hashTransaccion, string direccionRetorno)
        {
            Console.WriteLine($"BitcoinAPI: Iniciando reembolso para la transacción {hashTransaccion}");
            Console.WriteLine($"BitcoinAPI: Dirección de retorno: {direccionRetorno}");
            // Simulación de devolución de Bitcoin
            if (!string.IsNullOrEmpty(hashTransaccion) && !string.IsNullOrEmpty(direccionRetorno))
            {
                Console.WriteLine("BitcoinAPI: Reembolso completado exitosamente");
                return true;
            }
            Console.WriteLine("BitcoinAPI: Error - Reembolso fallido");
            return false;
        }

        public double ConvertirUSDaBTC(decimal montoUSD)
        {
            Console.WriteLine($"BitcoinAPI: Convirtiendo ${montoUSD} USD a BTC");
            // Simulación de tasa de conversión (1 BTC = 50,000 USD)
            const decimal TASA_BTC_USD = 50000m;
            double cantidadBTC = (double)(montoUSD / TASA_BTC_USD);
            Console.WriteLine($"BitcoinAPI: ${montoUSD} USD = {cantidadBTC} BTC (Tasa: 1 BTC = ${TASA_BTC_USD} USD)");
            return cantidadBTC;
        }
    }
}