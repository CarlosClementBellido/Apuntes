namespace POO
{
    class Rally
    {
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public string pilotoCampeon { get; set; }
        public string escuderiaCampeona { get; set; }

        public Rally(   string nombre, string ubicacion, 
                        string pilotoCampeon, string escuderiaCampeona)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.pilotoCampeon = pilotoCampeon;
            this.escuderiaCampeona = escuderiaCampeona;
        }
    }
}