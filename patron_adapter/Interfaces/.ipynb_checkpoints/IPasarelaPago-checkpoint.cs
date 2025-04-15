namespace patron_adapter.Interfaces
{
    public interface IPasarelaPago
    {
        bool Pagar(decimal monto);
        bool Reembolsar(string idTransaccion);
    }
}
