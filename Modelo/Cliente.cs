﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioColmenaTrabajoPractico.Modelo
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Documento { get; set; }

        public string Ocupacion { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Piso { get; set; }
        public string Barrio { get; set; }
        public string Depto { get; set; }
        public string Email { get; set; }

        public int IdProvincia { get; set; }


        public Cliente()
        {

        }
    }
}