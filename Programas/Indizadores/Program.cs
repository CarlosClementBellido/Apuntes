using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indizadores
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, Rally.Equipo> historicoAfrica = new Dictionary<int, Rally.Equipo>
            {
                [2013] = new Rally.Equipo("Jassy Singh", "Subaru"),
                [2014] = new Rally.Equipo("Gary Chaynes", "Mitsubishi"),
                [2015] = new Rally.Equipo("Jaspreet Singh Chatthe", "Mitsubishi"),
                [2016] = new Rally.Equipo("Don Smith", "Subaru"),
                [2017] = new Rally.Equipo("Manvir Baryan", "Škoda"),
            };

            Dictionary<int, Rally.Equipo> historicoAsia = new Dictionary<int, Rally.Equipo>
            {
                [2013] = new Rally.Equipo("Gaurav Gill", "Škoda"),
                [2014] = new Rally.Equipo("Jan Kopecký", "Škoda"),
                [2015] = new Rally.Equipo("Pontus Tidemand", "Škoda"),
                [2016] = new Rally.Equipo("Gaurav Gill", "Škoda"),
                [2017] = new Rally.Equipo("Gaurav Gill", "Škoda"),
                [2018] = new Rally.Equipo("Yuya Sumiyama", "Škoda"),
            };

            Dictionary<int, Rally.Equipo> historicoEuropa = new Dictionary<int, Rally.Equipo>
            {
                [2013] = new Rally.Equipo("Jan Kopecký", "Škoda"),
                [2014] = new Rally.Equipo("Esapekka Lappi", "Škoda"),
                [2015] = new Rally.Equipo("Kajetan Kajetanowicz", "Ford"),
                [2016] = new Rally.Equipo("Kajetan Kajetanowicz", "Ford"),
                [2017] = new Rally.Equipo("Kajetan Kajetanowicz", "Ford"),
                [2018] = new Rally.Equipo("Alexey Lukyanuk", "Ford"),
            };

            List<Rally> rallyes = new List<Rally>()
            {
                new Rally(  "Campeonato de África de Rally",
                            "África",
                            historicoAfrica),
                new Rally(  "Campeonato Asia Pacífico de Rallyes",
                            "Asia",
                            historicoAsia),
                new Rally(  "Campeonato de Europa de Rally",
                            "Europa",
                            historicoEuropa)
            };

            Console.WriteLine(  $"Ganador del rally en el año 2015:\n" +
                                    $"\tPiloto: {rallyes[0][2015].Piloto}\n" +
                                    $"\tEscudería: {rallyes[0][2015].Escuderia}");
        }
    }
}
