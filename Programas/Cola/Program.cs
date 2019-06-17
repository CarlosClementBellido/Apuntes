using System;
using System.Collections.Generic;

namespace Programas
{
    class Program
    {
        static void Main()
        {
            Queue<string> cola = new Queue<string>
                (
                    new string[] { "Sandra", "Ismael", "Susana" }
                );

            cola.Enqueue("Sergio");

            Console.WriteLine(cola.Dequeue());
            Console.WriteLine(cola.Peek());
        }
    }
}

