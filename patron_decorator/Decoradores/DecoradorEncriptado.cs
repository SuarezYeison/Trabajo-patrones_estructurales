using System;
using patron_decorator.Interfaces;

namespace patron_decorator.Decoradores
{
    public class DecoradorEncriptado : DecoradorNotificador
    {
        public DecoradorEncriptado(INotificador notificador) : base(notificador) { }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine("[ENCRIPTADO] Simulando encriptación del mensaje...");
            base.Enviar(mensaje);
        }
    }
}