using patron_decorator.Interfaces;
using System;

namespace patron_decorator.Decoradores
{
    public class DecoradorHTML : DecoradorNotificador
    {
        public DecoradorHTML(INotificador notificador) : base(notificador) { }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine("[HTML] Formateando mensaje a HTML");
            base.Enviar($"<html><body><p>{mensaje}</p></body></html>");
        }
    }
}
