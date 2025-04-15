using System;

namespace patron_adapter.APIsExternas
{
    public class StripeAPI
    {
        public string CrearCargo(int montoCentavos, string descripcion)
        {
            Console.WriteLine($"Creando cargo en Stripe: {montoCentavos} centavos por {descripcion}");
            return "ch_" + Guid.NewGuid().ToString();
        }

        public bool DevolverCargo(string idCargo)
        {
            Console.WriteLine($"Devolviendo cargo Stripe ID: {idCargo}");
            return true;
        }
    }
}
