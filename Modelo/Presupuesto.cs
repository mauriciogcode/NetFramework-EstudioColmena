using System;

namespace EstudioColmenaTrabajoPractico.Modelo
{
    class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public int IdPrecio { get; set; }
        public int IdReunion { get; set; }
        public int IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public int IdTipologia { get; set; }
        public decimal TotalNeto { get; set; }
        public DateTime FechaDeCreacion { get; set; }
    }
}
