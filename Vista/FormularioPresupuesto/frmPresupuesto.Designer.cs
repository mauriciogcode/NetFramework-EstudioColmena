
namespace Colmena.Entidades.Vista.FormularioPresupuesto
{
    partial class frmPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuesto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cliente1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUD = new Colmena.Entidades.dsCRUD();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUD1 = new Colmena.Entidades.dsCRUD();
            this.cboTipologia = new System.Windows.Forms.ComboBox();
            this.tipologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.txtCantidadConsulta = new System.Windows.Forms.TextBox();
            this.dsCRUDLogin = new Colmena.Entidades.dsCRUDLogin();
            this.dsCRUDLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupuestoTableAdapter = new Colmena.Entidades.dsCRUDTableAdapters.PresupuestoTableAdapter();
            this.cliente1TableAdapter = new Colmena.Entidades.dsCRUDTableAdapters.Cliente1TableAdapter();
            this.proyectoTableAdapter = new Colmena.Entidades.dsCRUDTableAdapters.ProyectoTableAdapter();
            this.tipologiaTableAdapter = new Colmena.Entidades.dsCRUDTableAdapters.TipologiaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipologiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presupuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(31, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(31, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de Consulta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(31, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Consutas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(31, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipologia del Proyecto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(31, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(318, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(432, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DataSource = this.cliente1BindingSource;
            this.cboCliente.DisplayMember = "Apellido";
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(171, 135);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(255, 32);
            this.cboCliente.TabIndex = 13;
            this.cboCliente.ValueMember = "Apellido";
            // 
            // cliente1BindingSource
            // 
            this.cliente1BindingSource.DataMember = "Cliente1";
            this.cliente1BindingSource.DataSource = this.dsCRUD;
            // 
            // dsCRUD
            // 
            this.dsCRUD.DataSetName = "dsCRUD";
            this.dsCRUD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboProyecto
            // 
            this.cboProyecto.DataSource = this.proyectoBindingSource;
            this.cboProyecto.DisplayMember = "Descripcion";
            this.cboProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(171, 189);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(255, 32);
            this.cboProyecto.TabIndex = 14;
            this.cboProyecto.ValueMember = "Descripcion";
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.dsCRUD1;
            // 
            // dsCRUD1
            // 
            this.dsCRUD1.DataSetName = "dsCRUD";
            this.dsCRUD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTipologia
            // 
            this.cboTipologia.DataSource = this.tipologiaBindingSource;
            this.cboTipologia.DisplayMember = "Tipo";
            this.cboTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboTipologia.FormattingEnabled = true;
            this.cboTipologia.Location = new System.Drawing.Point(235, 258);
            this.cboTipologia.Name = "cboTipologia";
            this.cboTipologia.Size = new System.Drawing.Size(191, 32);
            this.cboTipologia.TabIndex = 15;
            this.cboTipologia.ValueMember = "Tipo";
            // 
            // tipologiaBindingSource
            // 
            this.tipologiaBindingSource.DataMember = "Tipologia";
            this.tipologiaBindingSource.DataSource = this.dsCRUD1;
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPrecioConsulta.Location = new System.Drawing.Point(235, 345);
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.Size = new System.Drawing.Size(100, 29);
            this.txtPrecioConsulta.TabIndex = 16;
            // 
            // txtCantidadConsulta
            // 
            this.txtCantidadConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCantidadConsulta.Location = new System.Drawing.Point(235, 403);
            this.txtCantidadConsulta.Name = "txtCantidadConsulta";
            this.txtCantidadConsulta.Size = new System.Drawing.Size(100, 29);
            this.txtCantidadConsulta.TabIndex = 17;
            // 
            // dsCRUDLogin
            // 
            this.dsCRUDLogin.DataSetName = "dsCRUDLogin";
            this.dsCRUDLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCRUDLoginBindingSource
            // 
            this.dsCRUDLoginBindingSource.DataSource = this.dsCRUDLogin;
            this.dsCRUDLoginBindingSource.Position = 0;
            // 
            // presupuestoBindingSource
            // 
            this.presupuestoBindingSource.DataMember = "Presupuesto";
            this.presupuestoBindingSource.DataSource = this.dsCRUD;
            // 
            // presupuestoTableAdapter
            // 
            this.presupuestoTableAdapter.ClearBeforeFill = true;
            // 
            // cliente1TableAdapter
            // 
            this.cliente1TableAdapter.ClearBeforeFill = true;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // tipologiaTableAdapter
            // 
            this.tipologiaTableAdapter.ClearBeforeFill = true;
            // 
            // Presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(568, 539);
            this.Controls.Add(this.txtCantidadConsulta);
            this.Controls.Add(this.txtPrecioConsulta);
            this.Controls.Add(this.cboTipologia);
            this.Controls.Add(this.cboProyecto);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Presupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.Presupuesto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipologiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.ComboBox cboTipologia;
        private System.Windows.Forms.TextBox txtPrecioConsulta;
        private System.Windows.Forms.TextBox txtCantidadConsulta;
        private dsCRUDLogin dsCRUDLogin;
        private System.Windows.Forms.BindingSource dsCRUDLoginBindingSource;
        private dsCRUD dsCRUD;
        private System.Windows.Forms.BindingSource presupuestoBindingSource;
        private dsCRUDTableAdapters.PresupuestoTableAdapter presupuestoTableAdapter;
        private System.Windows.Forms.BindingSource cliente1BindingSource;
        private dsCRUDTableAdapters.Cliente1TableAdapter cliente1TableAdapter;
        private dsCRUD dsCRUD1;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private dsCRUDTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
        private System.Windows.Forms.BindingSource tipologiaBindingSource;
        private dsCRUDTableAdapters.TipologiaTableAdapter tipologiaTableAdapter;
    }
}