using FactoryPatternConsole.Notificadores;
using System;

namespace FactoryPatternConsole
{
    public static class NotificadorFactory
    {
        public static INotificador Crear(NotificadorTipo tipo)
        {
            return tipo switch
            {
                NotificadorTipo.Email => new EmailNotificador(),
                NotificadorTipo.SMS => new SmsNotificador(),
                NotificadorTipo.Teams => new TeamsNotificador(),
                _ => throw new ArgumentOutOfRangeException($"El notificador {nameof(tipo)} no está soportado!")
            };
        }
    }

    public enum NotificadorTipo
    {
        Email,
        SMS,
        Teams
    }
}
