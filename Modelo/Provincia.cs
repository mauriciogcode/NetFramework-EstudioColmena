namespace EstudioColmenaTrabajoPractico.Modelo
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public int IdLocalidad { get; set; }

        public int CodigoProvincia { get; set; }

        public int CodigoDepartamento { get; set; }
    }
}
