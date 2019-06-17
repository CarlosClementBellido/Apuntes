namespace Eventos
{
    class Program
    {
        static void Main()
        {
            Bombilla bombilla = new Bombilla();

            bombilla.interruptorPresionado += EncenderBombilla;

            bombilla.ComenzarAEscuchar();
        }

        static void EncenderBombilla(Bombilla bombilla)
        {
            bombilla.activo = true;
        }
    }
}
