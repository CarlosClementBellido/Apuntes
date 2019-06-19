using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tareas
{
    class Program
    {
        static void Main()
        {
            using (Task<char> t = EscribeAleatorio())
            {
                for (int i = 0; !t.IsCompleted; i++)
                    Console.WriteLine(i);
                Console.WriteLine($"La última letra ha sido: {t.Result}");
            }
        }

        static async Task<char> EscribeAleatorio()
        {
            return await Task.Factory.StartNew(() =>
            {
                char ultimaVocal = '\0';
                using (StreamWriter sw = File.AppendText(Environment.CurrentDirectory + "\\letrasAleatorias.txt"))
                {
                    Random rnd = new Random();

                    var contador = System.Diagnostics.Stopwatch.StartNew();
                    while (contador.ElapsedMilliseconds < 3000)
                    {
                        ultimaVocal = (char)rnd.Next('A', 'Z');
                        sw.Write(ultimaVocal);
                    }
                }

                return ultimaVocal;
            });
        }
    }
}
