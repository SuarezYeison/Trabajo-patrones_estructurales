using patron_decorator.Interfaces;

namespace patron_decorator.Notificadores
{
    public abstract class NotificadorBase : INotificador
    {
        public abstract void Enviar(string mensaje);
    }
}
