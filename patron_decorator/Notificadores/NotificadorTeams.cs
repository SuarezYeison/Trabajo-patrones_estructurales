using System;

namespace patron_decorator.Notificadores
{
    public class NotificadorTeams : NotificadorBase
    {
        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando mensaje por Teams: {mensaje}");
        }
    }
}