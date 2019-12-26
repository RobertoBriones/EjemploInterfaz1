using System;

namespace Ejemplo1Interfaz
{
    public struct EnviarSms : IMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Sms: mensaje enviado desde el telefono 55425456: {0}", mensaje);
        }
    }
}