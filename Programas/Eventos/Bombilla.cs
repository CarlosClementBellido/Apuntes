using System;

namespace Eventos
{
    class Bombilla
    {
        public delegate void Interruptor(Bombilla bombilla);
        public event Interruptor interruptorPresionado;

        public bool activo = false;

        public void ComenzarAEscuchar()
        {
            while (true)
            {
                Console.WriteLine(activo ? "Encendida" : "Apagada");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.R:
                        interruptorPresionado?.Invoke(this);
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
