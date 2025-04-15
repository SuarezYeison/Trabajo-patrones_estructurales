using System;

namespace patron_decorator.Notificadores
{
    public class NotificadorSMS : NotificadorBase
    {
        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando SMS: {mensaje}");
        }
    }
}
