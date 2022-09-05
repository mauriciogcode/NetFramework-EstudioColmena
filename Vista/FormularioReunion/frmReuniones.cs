using System;
using System.Globalization;
using System.Windows.Forms;


namespace EstudioColmenaTrabajoPractico.Vista.FormularioReunion
{
    public partial class frmReuniones : Form



    {



        private int month, year;
        // Variables staticas para month y year
        public static int static_month, static_year;

        public frmReuniones()
        {
            InitializeComponent();
        }


        private void frmreuniones_Load(object sender, EventArgs e)
        {
            displayDays();

        }


        private void displayDays()
        {

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            //obtenemos el nombre del month
            string nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            //mostramos el month en lblmes pasando al español 

            CultureInfo cult = new CultureInfo("es-ES", false);

            lblmes.Text = nombremes + " " + year;

            // month y year estatico
            static_month = month;
            static_year = year;
            // Primer dia del month
            DateTime startofthemonth = new DateTime(year, month, 1);
            // Contar los dias del month
            int days = DateTime.DaysInMonth(year, month);
            //  convertir el primer del month a int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // Crear control de usuario
            for (int i = 1; i < dayoftheweek; i++)
            {

                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //  Crear control de usuarios por dia 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.dias(i);
                daycontainer.Controls.Add(ucdays);

            }
        }



        private void btnControl_Click_1(object sender, EventArgs e)
        {
            frmControl frmControl = new frmControl();
            frmControl.ShowDialog();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            //limpiamos contenedores
            daycontainer.Controls.Clear();


            //pasamos al month anterior
            month--;

            //si el numero de month supera 12 pasamos al year siguiente y seteamos enero
            if (month < 1)
            {
                year--;
                month = 12;
            }
            // month y year estatico
            static_month = month;
            static_year = year;

            //obtenemos el nombre del month
            string nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            //mostramos el month en lblmes pasando al español 

            CultureInfo cult = new CultureInfo("es-ES", false);

            lblmes.Text = nombremes + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            // Contar los dias del month
            int days = DateTime.DaysInMonth(year, month);
            //  convertir el primer del month a int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // Crear control de usuario
            for (int i = 1; i < dayoftheweek; i++)
            {

                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //  Crear control de usuarios por dia 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.dias(i);
                daycontainer.Controls.Add(ucdays);

            }

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {


            //limpiamos contenedores
            daycontainer.Controls.Clear();


            //incrementamos el month al siguiente
            month++;

            //si el numero de month supera 12 pasamos al year siguiente y seteamos enero
            if (month > 12)
            {
                year++;
                month = 1;
            }
            //obtenemos el nombre del month
            string nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            //mostramos el month en lblmes pasando al español 

            CultureInfo cult = new CultureInfo("es-ES", false);

            lblmes.Text = nombremes + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            // Contar los dias del month
            int days = DateTime.DaysInMonth(year, month);
            //  convertir el primer del month a int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // Crear control de usuario
            for (int i = 1; i < dayoftheweek; i++)
            {

                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //  Crear control de usuarios por dia 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.dias(i);
                daycontainer.Controls.Add(ucdays);

            }

        }
    }
}
