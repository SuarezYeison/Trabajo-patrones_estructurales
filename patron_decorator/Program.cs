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

            // Crear una nueva cadena con Teams y encriptación
            Console.WriteLine("\nNueva cadena de notificaciones con Teams:");
            INotificador notificadorTeams = new NotificadorTeams();
            notificadorTeams = new DecoradorEncriptado(notificadorTeams);
            Console.WriteLine("\nNotificación Teams + Encriptado:");
            notificadorTeams.Enviar("Mensaje confidencial por Teams");

            // Ejemplo combinando todos los decoradores
            Console.WriteLine("\nEjemplo completo (Teams + HTML + Urgente + Encriptado):");
            INotificador notificadorCompleto = new NotificadorTeams();
            notificadorCompleto = new DecoradorHTML(notificadorCompleto);
            notificadorCompleto = new DecoradorUrgente(notificadorCompleto);
            notificadorCompleto = new DecoradorEncriptado(notificadorCompleto);
            notificadorCompleto.Enviar("Mensaje importante y confidencial");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
