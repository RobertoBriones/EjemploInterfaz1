

namespace Ejemplo1Interfaz
{
    public struct EnviadorMensaje
    {
        public EnviadorMensaje(IMensaje enviadormensaje)
        {
            _enviadormensaje = enviadormensaje;
        }

        private IMensaje _enviadormensaje;

        public void EnviarMensaje(string mensaje)
        {
            _enviadormensaje.EnviarMensaje(mensaje);
        }
    }
}
