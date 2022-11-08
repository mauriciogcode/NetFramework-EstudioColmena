using Colmena.Entidades;
using Colmena.Negocio;
using Colmena.Negocio.LogicaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colmena.Negocio.LogicaEntidades.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Colmena.Vista.Formularios.Reunion
{
    public partial class frmCalendar : Form

    {

        public frmCalendar()
        {
            InitializeComponent();
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = "Hoy es " + (DateTime.Now).ToString("M");
                dtpHour.Enabled = false;

                cboProject.Enabled = false;
                cboUser.Enabled = false;
                txtEvent.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnCancelar.Enabled = false;


                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void loadAll()
        {
            ReunionNegocio oReunionNegocio = new ReunionNegocio();
            DataTable dt = oReunionNegocio.GetAll();

            dgv.DataSource = dt;

            PopulateComboProjets();
        }


        #region Eventos



        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            txtIdReunion.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            DateTime tempDate = DateTime.Parse(dgv.CurrentRow.Cells[1].Value.ToString());
            txtDate.Text = tempDate.ToString("M");
            dtpHour.Text = tempDate.ToString("t");
            txtEvent.Text = dgv.CurrentRow.Cells[3].Value.ToString();

            dtpHour.Enabled = false;
            cboProject.Enabled = false;
            cboUser.Enabled = false;
            txtEvent.Enabled = false;
            btnSave.Enabled = false;

            //txtNombre.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            //txtDescripcion.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            //cboTipo.SelectedValue = dgv.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (calendar.SelectionRange.Start < DateTime.Now.AddDays(-1))
            {
                MessageBox.Show("No se puede elegir una fecha anterior a la actual", "Fecha Invalida",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtpHour.Enabled = true;
                cboProject.Enabled = true;
                cboUser.Enabled = true;
                txtEvent.Enabled = true;
                btnSave.Enabled = true;
                btnCancelar.Enabled = true;


                txtDate.Text = (calendar.SelectionRange.Start.ToString("M"));

                txtIdReunion.Text = "";
               // txtDate.Text = "";
                dtpHour.Text = "00:00";
                txtEvent.Text = "";
                txtIdReunion.Text = "0";


            }



        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dtpHour.Enabled = true;
            cboProject.Enabled = true;
            cboUser.Enabled = true;
            txtEvent.Enabled = true;
            btnSave.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;

            txtDate.Text = (calendar.SelectionRange.Start.ToString("M"));



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Colmena.Entidades.Reunion oReunion = new Colmena.Entidades.Reunion();
                oReunion.IdReunion = int.Parse(txtIdReunion.Text);

                ReunionNegocio oReunionNegocio = new ReunionNegocio();
                oReunionNegocio.Delete(oReunion);

                MessageBox.Show("Evento borrado exitosamente");

                txtIdReunion.Text = "0";

                loadAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdReunion.Text = "";
            txtDate.Text = "";
            dtpHour.Text = "";
            txtEvent.Text = "";
            txtIdReunion.Text = "0";

            cboProject.Enabled = false;
            cboUser.Enabled = false;
            txtEvent.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancelar.Enabled = false;


            ReunionNegocio oReunionNegocio = new ReunionNegocio();
            DataTable dt = oReunionNegocio.GetAll();

            //dgv.DataSource = null;
            dgv.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // insert
                if (txtIdReunion.Text == "0")
                {

                    DateTime dateSelected = calendar.SelectionRange.Start.AddHours(dtpHour.Value.Hour).AddMinutes(dtpHour.Value.Minute);

                    Colmena.Entidades.Reunion oReunion = new Colmena.Entidades.Reunion();
                    oReunion.FechaReunion = dateSelected;
                    oReunion.Estado = txtEvent.Text;
                    oReunion.IdAsesor = "1";
                    oReunion.IdProyecto = "1";

                    //oexampleBE.ExampleType = (int)cboTipo.SelectedValue;

                    Colmena.Negocio.ReunionNegocio oReunionNegocio = new Colmena.Negocio.ReunionNegocio();
                    oReunionNegocio.Insert(oReunion);


                    MessageBox.Show("Evento creado exitosamente");
                    loadAll();


                    // (step missed)  Load dgv
                }
                else //update
                {
                    DateTime dateSelected = calendar.SelectionRange.Start.AddHours(dtpHour.Value.Hour).AddMinutes(dtpHour.Value.Minute);

                    Colmena.Entidades.Reunion oReunion = new Colmena.Entidades.Reunion();
                    oReunion.FechaReunion = dateSelected;
                    oReunion.Estado = txtEvent.Text;
                    oReunion.IdAsesor = cboUser.SelectedValue.ToString();
                    oReunion.IdProyecto = cboProject.SelectedIndex.ToString();

                    //oexampleBE.ExampleType = (int)cboTipo.SelectedValue;

                    oReunion.IdReunion = Int32.Parse(txtIdReunion.Text);

                    Colmena.Negocio.ReunionNegocio oReunionNegocio = new Colmena.Negocio.ReunionNegocio();
                    oReunionNegocio.Update(oReunion);


                    MessageBox.Show("Evento modificado exitosamente");
                    txtIdReunion.Text = "0";

                    loadAll();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

            txtDate.Text = (calendar.SelectionRange.Start.ToString("M"));
            dtpHour.Text = (calendar.SelectionRange.Start.ToString("t"));


            dtpHour.Enabled = false;
            cboProject.Enabled = false;
            cboUser.Enabled = false;
            txtEvent.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancelar.Enabled = false;

            txtEvent.Text = "";

            Colmena.Entidades.Reunion oReunion = new Colmena.Entidades.Reunion();
            oReunion.FechaReunion = calendar.SelectionRange.Start;

            ReunionNegocio oReunionNegocio = new ReunionNegocio();
            DataTable dt = oReunionNegocio.GetByDate(oReunion);

            //dgv.DataSource = null;
            dgv.DataSource = dt;

        }


        #endregion

        public void PopulateComboProjets()
        {
            cboProject.Items.Clear();
            ComboNegocio oComboNegocio = new ComboNegocio();
             DataTable projects = oComboNegocio.GetProjects();

            foreach (DataRow project in projects.Rows)
            {

                string fullprojectnames = $"{project[1].ToString()}, {project[2].ToString()}";
                cboProject.DisplayMember = "Text";
                cboProject.ValueMember = "Value";
                cboProject.Items.Add(new { Text = fullprojectnames, Value = project[0].ToString() });

            }

            cboUser.Items.Clear();
            DataTable users = oComboNegocio.GetUsers();

            foreach (DataRow user in users.Rows)
            {
                string fullnames = $"{user[1].ToString()}, {user[2].ToString()}";
                cboUser.DisplayMember = "Text";
                cboUser.ValueMember = "Value";
                cboUser.Items.Add(new { Text = fullnames, Value = user[0].ToString() });
            }
        }




    }
}
