using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EstudioColmenaTrabajoPractico.Vista.FormularioReunion
{
    public partial class UserControlDays : UserControl
    {
        //crear otra variable statica para dia
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();

        }

        public void dias(int numday)
        {
            lbldays.Text = numday + "";

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbldays.Text;
            timer1.Start();

            frmEvento formularioEvento = new frmEvento();
            formularioEvento.ShowDialog();
            displayEvent();

        }

        private void displayEvent()
        {


            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=EstudioColmena;Integrated Security=True");
            conn.Open();
            String sql = " SELECT * FROM Reunion WHERE FechaReunion = @Param1";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Param1", frmReuniones.static_year + "-" + frmReuniones.static_month + "-" + lbldays.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblEvent.Text = reader["Estado"].ToString();
                lblHora.Text = reader["Hora"].ToString();
                lblAsesor.Text = reader["IdAsesor"].ToString();
                lblProyecto.Text = reader["IdProyecto"].ToString();

            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            displayEvent();
        }

        private void lblEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
