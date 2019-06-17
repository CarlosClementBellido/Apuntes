using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            diccionario.Add("Carlos Sainz", 26);
            diccionario.Add("Colin McRae", 25);
            diccionario.Add("Dani Sordo", 0);

            diccionario["Dani Sordo"] = 17;
        }
    }
}
