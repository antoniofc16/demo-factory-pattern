using System;

namespace FactoryPatternConsole.Notificadores
{
    public interface INotificador
    {
        void Enviar(string destino, string mensaje);
    }
}
