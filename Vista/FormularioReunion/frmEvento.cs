using Colmena.Entidades.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Colmena.Entidades.Vista.FormularioReunion
{



    public partial class frmEvento : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=EstudioColmena;Integrated Security=True");


        private int? Id;

        public frmEvento(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;


        }

        private void formularioEvento_Load(object sender, EventArgs e)
        {
            
            dsCRUDTableAdapters.ReunionTableAdapter ta = new dsCRUDTableAdapters.ReunionTableAdapter();

            if (Id == null)
            {
                Login login = new Login();

                lblNombre.Text = Login.Nombre + ", " + Login.Apellido;

                // TODO: esta línea de código carga datos en la tabla 'dsCRUDLogin.Login' Puede moverla o quitarla según sea necesario.
                this.loginTableAdapter.Fill(this.dsCRUDLogin.Login);
                // TODO: esta línea de código carga datos en la tabla 'dsCRUD.Proyecto' Puede moverla o quitarla según sea necesario.
                this.proyectoTableAdapter.Fill(this.dsCRUD.Proyecto);
                //llamaremos a las variables que declaramos

                txtDate.Text = UserControlDays.static_day + "/" + frmReuniones.static_month + "/" + frmReuniones.static_year;
            }
            else
            {
                DataSet res = Update(Id);
                foreach (DataRow row in res.Tables[0].Rows)
                {
                    Reunion oreunion = new Reunion(row);
                    txtDate.Text = oreunion.FechaDeCreacion.ToString();
                    cboHour.Text = oreunion.Hora.ToString();
                    txtEvent.Text = oreunion.Estado.ToString();
                    cboAsesor.Text = oreunion.IdAsesor.ToString();
                    cboProject.Text = oreunion.IdProyecto.ToString();
                }

            }



        }

        private DataSet Update(int? Id)
        {
            conn.Open();
            String sql = "select * from Reunion where IdReunion = " + Id;
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EstudioColmena;Integrated Security=True";
            SqlCommand sqlComm = new SqlCommand(sql, sqlCnn);
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlComm.ExecuteNonQuery();
            sqlCnn.Close();
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEvent();

            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {


            this.Close();

        }
        public void SaveEvent()
        {
            string selected_day = UserControlDays.static_day;
            string selected_month = frmReuniones.static_month.ToString();
            string selected_year = frmReuniones.static_year.ToString();
            string sSelectedDate = selected_year + "-" + selected_month + "-" + selected_day;
            DateTime datetimeSelectedDate = DateTime.Parse(sSelectedDate);
            DateTime nowDateTime = DateTime.Now;
            //int? int_cbo_Selected = int.Parse(cboHour.SelectedItem.ToString());
            //int? int_cbo_Asesor = int.Parse(cboAsesor.SelectedItem.ToString());
            //int? int_cbo_Project = int.Parse(cboProject.SelectedItem.ToString());

            //// Con table adapter //////////////////////////////////////////////

            //dsCRUDTableAdapters.ReunionTableAdapter ta = new dsCRUDTableAdapters.ReunionTableAdapter();

            //ta.InsertQuery(datetimeSelectedDate, nowDateTime, int_cbo_Selected, txtEvent.Text.Trim(), int_cbo_Asesor, int_cbo_Project);

            conn.Open();
            String sql = "INSERT INTO Reunion(FechaReunion,Estado,Hora,IdAsesor)values(@FechaReunion,@Estado,@Hora,@IdAsesor)";
            //String sql = "INSERT INTO Reunion(FechaReunion,Estado,Hora,IdAsesor,IdProyecto)values(@FechaReunion,@Estado,@Hora,@IdAsesor,@IdProyecto)";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@FechaReunion", sSelectedDate);
            cmd.Parameters.AddWithValue("@Estado", txtEvent.Text);
            cmd.Parameters.AddWithValue("@Hora", cboHour.Text.ToString());
            cmd.Parameters.AddWithValue("@IdAsesor", cboAsesor.Text.ToString());
            //cmd.Parameters.AddWithValue("@IdProyecto", cboProject.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();


        }
    }
}
