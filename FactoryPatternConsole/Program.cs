using System;
using FactoryPatternConsole;

Console.WriteLine("Demostracion de entregable: Factory Method");
Console.WriteLine("==============================================================================================");
Console.WriteLine(string.Empty);

var notificadorEmail = NotificadorFactory.Crear(NotificadorTipo.Email);
notificadorEmail.Enviar("jlopez@nttdata.com", "Hola desde Factory Method");
Console.WriteLine(string.Empty);

var notificadorSms = NotificadorFactory.Crear(NotificadorTipo.SMS);
notificadorSms.Enviar("+34123456789", "Mensaje SMS de prueba de Factory Method");
Console.WriteLine(string.Empty);

var notificadorTeams = NotificadorFactory.Crear(NotificadorTipo.Teams);
notificadorTeams.Enviar("jlopez@nttdata.com", "Mensaje en Teams desde Factory Method");
Console.WriteLine(string.Empty);
