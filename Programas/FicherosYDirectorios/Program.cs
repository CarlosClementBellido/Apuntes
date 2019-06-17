using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FicherosYDirectorios
{
    class Program
    {
        static void Main()
        {
            string ruta = Environment.CurrentDirectory + "\\Documentos";

            Directory.CreateDirectory(ruta + "\\Notas");
            Directory.CreateDirectory(ruta + "\\Historico");

            string[] misNotas = new string[]
            {
                "No cenar mucho",
                "Evitar alcoholes y azúcares",
                "Alejarse de bombones como yo",
                "Comer fibra"
            };
            using (StreamWriter sw = File.AppendText(ruta+ @"\Notas\MisNotas.txt"))
            {
                foreach (string linea in misNotas)
                    sw.WriteLine(linea);
            }

            Dictionary<DateTime, float> MisPesos = new Dictionary<DateTime, float>()
            {
                [new DateTime(2019, 06, 10)] = 65.20f,
                [new DateTime(2019, 06, 11)] = 65.10f,
                [new DateTime(2019, 06, 12)] = 65.30f,
                [new DateTime(2019, 06, 13)] = 65.10f,
                [new DateTime(2019, 06, 14)] = 64.90f,
                [new DateTime(2019, 06, 15)] = 65.00f,
                [new DateTime(2019, 06, 16)] = 64.90f,
                [new DateTime(2019, 06, 17)] = 64.90f,
                [new DateTime(2019, 06, 18)] = 64.80f
            };
            using (StreamWriter sw = File.AppendText(ruta + @"\Historico\MisPesos.csv"))
            {
                sw.WriteLine("Fecha;Peso");
                foreach (KeyValuePair<DateTime, float> FechaYPeso in MisPesos)
                    sw.WriteLine($"{FechaYPeso.Key.ToShortDateString()};{FechaYPeso.Value}");
            }

            string lineaActual = "";
            using (StreamReader sr = new StreamReader(ruta + @"MisNotas\MisNotas.txt"))
            {
                while ((lineaActual = sr.ReadLine()) != null)
                    Console.WriteLine(lineaActual);
            }
        }
    }
}
