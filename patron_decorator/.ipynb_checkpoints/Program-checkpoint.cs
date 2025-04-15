using patron_decorator.Decoradores;
using patron_decorator.Interfaces;
using patron_decorator.Notificadores;
using System;

namespace patron_decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMOSTRACIÓN DEL PATRÓN DECORATOR");
            Console.WriteLine("--------------------------------\n");

            // Crear notificador base (Email)
            INotificador notificador = new NotificadorEmail();
            Console.WriteLine("\nNotificación básica por email:");
            notificador.Enviar("Este es un mensaje normal");

            // Decorar con formato HTML
            notificador = new DecoradorHTML(notificador);
            Console.WriteLine("\nNotificación con formato HTML:");
            notificador.Enviar("Este mensaje tiene formato HTML");

            // Decorar con marca de urgente
            notificador = new DecoradorUrgente(notificador);
            Console.WriteLine("\nNotificación HTML + Urgente:");
            notificador.Enviar("Este mensaje es importante");

            // Crear una nueva cadena con SMS
            Console.WriteLine("\nNueva cadena de notificaciones con SMS:");
            INotificador notificadorSMS = new NotificadorSMS();
            notificadorSMS = new DecoradorUrgente(notificadorSMS);
            notificadorSMS.Enviar("Alerta por SMS");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
