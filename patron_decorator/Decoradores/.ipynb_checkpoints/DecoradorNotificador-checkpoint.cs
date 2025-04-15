using patron_decorator.Interfaces;

namespace patron_decorator.Decoradores
{
    public abstract class DecoradorNotificador : INotificador
    {
        protected readonly INotificador _notificador;

        public DecoradorNotificador(INotificador notificador)
        {
            _notificador = notificador;
        }

        public virtual void Enviar(string mensaje)
        {
            _notificador.Enviar(mensaje);
        }
    }
}
