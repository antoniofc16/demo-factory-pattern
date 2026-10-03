using System;

namespace FactoryPatternConsole.Notificadores
{
    public class SmsNotificador : INotificador
    {
        public void Enviar(string destino, string mensaje)
        {
            Console.WriteLine($"Enviando notificación por SMS a {destino}: {mensaje}");
        }
    }
}
