using System;

namespace Ejemplo1Interfaz
{
    class Program
    {
        static void Main(string[] args) 
        {
            var TipoMensaje1=new EnviarSms();
            var enviadormensaje1 = new EnviadorMensaje(TipoMensaje1);
            enviadormensaje1.EnviarMensaje("Te llame y no respondes el celular");

            var TipoMensaje2 = new EnviarCorreo();
            var enviadormensaje2 = new EnviadorMensaje(TipoMensaje2);
            enviadormensaje2.EnviarMensaje("Este es un email de prueba.");
            
            Console.Read();
        }

        
}

    
    
}
