﻿using Colmena.Entidades;
using Colmena.Vista.Formularios.Proyecto;
using Colmena.Vista.Formularios.Tipologia;
using Colmena.Vista.Formularios.Reunion;
using Colmena.Vista.Vista.FormularioCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmena.Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTipologia());
        }
    }
}
