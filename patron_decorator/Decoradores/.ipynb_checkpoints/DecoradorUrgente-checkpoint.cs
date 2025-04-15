using patron_decorator.Interfaces;
using System;

namespace patron_decorator.Decoradores
{
    public class DecoradorUrgente : DecoradorNotificador
    {
        public DecoradorUrgente(INotificador notificador) : base(notificador) { }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine("[URGENTE] Marcando mensaje como urgente");
            base.Enviar($"¡URGENTE! {mensaje}");
        }
    }
}
