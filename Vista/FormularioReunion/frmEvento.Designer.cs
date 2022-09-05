namespace EstudioColmenaTrabajoPractico.Vista.FormularioReunion
{
    partial class frmEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAsesor = new System.Windows.Forms.ComboBox();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUDLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUDLogin = new EstudioColmenaTrabajoPractico.dsCRUDLogin();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUD = new EstudioColmenaTrabajoPractico.dsCRUD();
            this.cboHour = new System.Windows.Forms.ComboBox();
            this.proyectoTableAdapter = new EstudioColmenaTrabajoPractico.dsCRUDTableAdapters.ProyectoTableAdapter();
            this.loginTableAdapter = new EstudioColmenaTrabajoPractico.dsCRUDLoginTableAdapters.LoginTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(197, 27);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(276, 20);
            this.txtDate.TabIndex = 0;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(79, 54);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(394, 82);
            this.txtEvent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asesor";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(24, 168);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(49, 13);
            this.lblProyecto.TabIndex = 7;
            this.lblProyecto.Text = "Proyecto";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(294, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora";
            // 
            // cboAsesor
            // 
            this.cboAsesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsesor.FormattingEnabled = true;
            this.cboAsesor.Location = new System.Drawing.Point(79, 142);
            this.cboAsesor.Name = "cboAsesor";
            this.cboAsesor.Size = new System.Drawing.Size(394, 21);
            this.cboAsesor.TabIndex = 12;
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "Login";
            this.loginBindingSource1.DataSource = this.dsCRUDLoginBindingSource;
            // 
            // dsCRUDLoginBindingSource
            // 
            this.dsCRUDLoginBindingSource.DataSource = this.dsCRUDLogin;
            this.dsCRUDLoginBindingSource.Position = 0;
            // 
            // dsCRUDLogin
            // 
            this.dsCRUDLogin.DataSetName = "dsCRUDLogin";
            this.dsCRUDLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.dsCRUDLoginBindingSource;
            // 
            // cboProject
            // 
            this.cboProject.DataSource = this.proyectoBindingSource;
            this.cboProject.DisplayMember = "Descripcion";
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(79, 165);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(394, 21);
            this.cboProject.TabIndex = 13;
            this.cboProject.ValueMember = "Descripcion";
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.dsCRUD;
            // 
            // dsCRUD
            // 
            this.dsCRUD.DataSetName = "dsCRUD";
            this.dsCRUD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboHour
            // 
            this.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHour.FormatString = "t";
            this.cboHour.FormattingEnabled = true;
            this.cboHour.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cboHour.Location = new System.Drawing.Point(79, 27);
            this.cboHour.Name = "cboHour";
            this.cboHour.Size = new System.Drawing.Size(61, 21);
            this.cboHour.TabIndex = 11;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 14;
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 221);
            this.ControlBox = false;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.cboAsesor);
            this.Controls.Add(this.cboHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmEvento";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.formularioEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.ComboBox cboHour;
        private dsCRUD dsCRUD;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private dsCRUDTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
        public System.Windows.Forms.ComboBox cboAsesor;
        private System.Windows.Forms.BindingSource dsCRUDLoginBindingSource;
        private dsCRUDLogin dsCRUDLogin;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private dsCRUDLoginTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private System.Windows.Forms.Label lblNombre;
    }
}