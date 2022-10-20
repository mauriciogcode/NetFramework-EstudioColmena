using System;
using System.Data;

namespace Colmena.Entidades
{
    public class Reunion
    {
        public int IdReunion { get; set; }
        public DateTime FechaReunion { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public int Hora { get; set; }

        public string Estado { get; set; }
        public string IdAsesor { get; set; }
        public string IdProyecto { get; set; }

        public Reunion()
        {

        }



        public Reunion(DataRow row)
        {
            this.FechaReunion = (DateTime)row["FechaReunion"];
            this.Hora = (int)row["Hora"];

            this.Estado = row["Estado"].ToString();
            this.IdAsesor = row["IdAsesor"].ToString();
            this.IdProyecto = row["IdProyecto"].ToString();

        }
    }
}
