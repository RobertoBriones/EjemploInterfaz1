using System;

namespace Ejemplo1Interfaz
{
    public struct EnviarCorreo : IMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Correo:  enviado desde google@gmail.com: {0}", mensaje);
        }
    }



}
