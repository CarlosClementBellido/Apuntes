using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main()
        {
            List<Rally> rallyes = new List<Rally>()
            {
                new Rally(  "Campeonato de África de Rally",
                            "África",
                            "Manvir Baryan",
                            "Subaru")
            };

            Rally rallyAsia = new Rally("Campeonato Asia Pacífico de Rallyes",
                                        "Asia",
                                        "Jan Kopecký",
                                        "Škoda");
            rallyes.Add(rallyAsia);

            rallyes.Add(new Rally(  "Campeonato de Europa de Rally",
                                    "Europa",
                                    "Alexey Lukyanuk",
                                    "ADAC Opel Rallye Junior Team"));
        }
    }
}
