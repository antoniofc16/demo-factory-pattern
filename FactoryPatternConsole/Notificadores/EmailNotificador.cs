using System;

namespace FactoryPatternConsole.Notificadores
{
    public class EmailNotificador : INotificador
    {
        public void Enviar(string destino, string mensaje)
        {
            Console.WriteLine($"Enviando notificación por correo electrónico a {destino}: {mensaje}");
        }
    }
}
