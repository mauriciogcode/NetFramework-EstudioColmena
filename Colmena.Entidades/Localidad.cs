﻿namespace Colmena.Entidades
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public bool Estado { get; set; }

        public int CodigoLocalidad { get; set; }

    }
}
