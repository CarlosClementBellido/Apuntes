using System;
using System.Collections.Generic;

namespace Programas
{
    class Program
    {
        static void Main()
        {
            Stack<string> pila = new Stack<string>
                (
                    new string[] { "Sandra", "Ismael", "Susana" }
                );

            pila.Push("Sergio");

            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Peek());
        }
    }
}