using System.Collections.Generic;

namespace Indizadores
{
    class Rally
    {
        public struct Equipo
        {
            public string Piloto;
            public string Escuderia;

            public Equipo(string piloto, string escuderia)
            {
                Piloto = piloto;
                Escuderia = escuderia;
            }
        }

        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public Dictionary<int, Equipo> historico { get; set; }

        public Rally(string nombre, string ubicacion, Dictionary<int, Equipo> historico)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.historico = historico;
        }

        public Equipo this[int año]
        {
            get { return historico[año]; }
        }
    }
}