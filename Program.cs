using System;
using System.Windows.Forms;

namespace EstudioColmenaTrabajoPractico
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Vista.frmCliente());
            //Application.Run(new Vista.Formularios_cliente.Agregacliente());
            //Application.Run(new LOGIN());
            //Application.Run(new Vista.FormularioReunion.frmreuniones());
            //Application.Run(new Vista.FormularioTipologiasProyecto.frmTipologia());
            //Application.Run(new Vista.FormularioPrecio.frmCambiarHonorarios());
            //Application.Run(new Vista.FormularioPresupuesto.Presupuesto());
            Application.Run(new Vista.FormularioProyecto.frmProyecto());
        }

    }
}
