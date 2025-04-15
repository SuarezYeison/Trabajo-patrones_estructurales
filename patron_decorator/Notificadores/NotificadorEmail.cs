using System;

namespace patron_decorator.Notificadores
{
    public class NotificadorEmail : NotificadorBase
    {
        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando email: {mensaje}");
        }
    }
}
