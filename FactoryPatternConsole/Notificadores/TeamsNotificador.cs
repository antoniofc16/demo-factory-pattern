using System;

namespace FactoryPatternConsole.Notificadores
{
    public class TeamsNotificador : INotificador
    {
        public void Enviar(string destino, string mensaje)
        {
            Console.WriteLine($"Enviando notificación por Teams a {destino}: {mensaje}");
        }
    }
}
