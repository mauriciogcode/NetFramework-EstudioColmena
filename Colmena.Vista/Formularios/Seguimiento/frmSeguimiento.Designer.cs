namespace Colmena.Vista.Formularios.Seguimiento
{
    partial class frmSeguimiento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbComputo = new System.Windows.Forms.CheckBox();
            this.cbLegajo = new System.Windows.Forms.CheckBox();
            this.cbMunicipal = new System.Windows.Forms.CheckBox();
            this.cbVistas = new System.Windows.Forms.CheckBox();
            this.cbImplantacion = new System.Windows.Forms.CheckBox();
            this.cbFactibilidad = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDeProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSeguimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factibilidad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateFactibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Implantacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateImplantacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vistas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateVistas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateMunicipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Computo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateComputo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProyecto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblproject = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbComputo);
            this.groupBox1.Controls.Add(this.cbLegajo);
            this.groupBox1.Controls.Add(this.cbMunicipal);
            this.groupBox1.Controls.Add(this.cbVistas);
            this.groupBox1.Controls.Add(this.cbImplantacion);
            this.groupBox1.Controls.Add(this.cbFactibilidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de Proyecto";
            // 
            // cbComputo
            // 
            this.cbComputo.AutoSize = true;
            this.cbComputo.Location = new System.Drawing.Point(368, 42);
            this.cbComputo.Name = "cbComputo";
            this.cbComputo.Size = new System.Drawing.Size(184, 17);
            this.cbComputo.TabIndex = 7;
            this.cbComputo.Text = "Cómputo y cálculo de Estructuras";
            this.cbComputo.UseVisualStyleBackColor = true;
            // 
            // cbLegajo
            // 
            this.cbLegajo.AutoSize = true;
            this.cbLegajo.Location = new System.Drawing.Point(368, 19);
            this.cbLegajo.Name = "cbLegajo";
            this.cbLegajo.Size = new System.Drawing.Size(100, 17);
            this.cbLegajo.TabIndex = 6;
            this.cbLegajo.Text = "Legajo Técnico";
            this.cbLegajo.UseVisualStyleBackColor = true;
            // 
            // cbMunicipal
            // 
            this.cbMunicipal.AutoSize = true;
            this.cbMunicipal.Location = new System.Drawing.Point(210, 42);
            this.cbMunicipal.Name = "cbMunicipal";
            this.cbMunicipal.Size = new System.Drawing.Size(101, 17);
            this.cbMunicipal.TabIndex = 5;
            this.cbMunicipal.Text = "Plano Municipal";
            this.cbMunicipal.UseVisualStyleBackColor = true;
            // 
            // cbVistas
            // 
            this.cbVistas.AutoSize = true;
            this.cbVistas.Location = new System.Drawing.Point(210, 19);
            this.cbVistas.Name = "cbVistas";
            this.cbVistas.Size = new System.Drawing.Size(128, 17);
            this.cbVistas.TabIndex = 4;
            this.cbVistas.Text = "Planos, Vistas, Cortes";
            this.cbVistas.UseVisualStyleBackColor = true;
            // 
            // cbImplantacion
            // 
            this.cbImplantacion.AutoSize = true;
            this.cbImplantacion.Location = new System.Drawing.Point(4, 42);
            this.cbImplantacion.Name = "cbImplantacion";
            this.cbImplantacion.Size = new System.Drawing.Size(146, 17);
            this.cbImplantacion.TabIndex = 3;
            this.cbImplantacion.Text = "Implantacion y Volumetria";
            this.cbImplantacion.UseVisualStyleBackColor = true;
            // 
            // cbFactibilidad
            // 
            this.cbFactibilidad.AutoSize = true;
            this.cbFactibilidad.Location = new System.Drawing.Point(4, 19);
            this.cbFactibilidad.Name = "cbFactibilidad";
            this.cbFactibilidad.Size = new System.Drawing.Size(131, 17);
            this.cbFactibilidad.TabIndex = 2;
            this.cbFactibilidad.Text = "Factibilidad Tipologica";
            this.cbFactibilidad.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(248, 539);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProyecto,
            this.Descripcion,
            this.NombreDeProyecto,
            this.IdSeguimiento,
            this.Factibilidad,
            this.DateFactibilidad,
            this.Implantacion,
            this.DateImplantacion,
            this.Vistas,
            this.DateVistas,
            this.Municipal,
            this.DateMunicipal,
            this.Legajo,
            this.DateLegajo,
            this.Computo,
            this.DateComputo,
            this.IdProyecto1,
            this.Comentario});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(659, 227);
            this.dgv.TabIndex = 2;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // IdProyecto
            // 
            this.IdProyecto.DataPropertyName = "IdProyecto";
            this.IdProyecto.HeaderText = "IdProyecto";
            this.IdProyecto.Name = "IdProyecto";
            this.IdProyecto.ReadOnly = true;
            this.IdProyecto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // NombreDeProyecto
            // 
            this.NombreDeProyecto.DataPropertyName = "NombreDeProyecto";
            this.NombreDeProyecto.HeaderText = "NombreDeProyecto";
            this.NombreDeProyecto.Name = "NombreDeProyecto";
            this.NombreDeProyecto.ReadOnly = true;
            // 
            // IdSeguimiento
            // 
            this.IdSeguimiento.DataPropertyName = "IdSeguimiento";
            this.IdSeguimiento.HeaderText = "IdSeguimiento";
            this.IdSeguimiento.Name = "IdSeguimiento";
            this.IdSeguimiento.ReadOnly = true;
            this.IdSeguimiento.Visible = false;
            // 
            // Factibilidad
            // 
            this.Factibilidad.DataPropertyName = "Factibilidad";
            this.Factibilidad.HeaderText = "Factibilidad Tipologica";
            this.Factibilidad.Name = "Factibilidad";
            this.Factibilidad.ReadOnly = true;
            this.Factibilidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Factibilidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Factibilidad.Width = 70;
            // 
            // DateFactibilidad
            // 
            this.DateFactibilidad.DataPropertyName = "DateFactibilidad";
            this.DateFactibilidad.HeaderText = "Fecha Factibilidad";
            this.DateFactibilidad.Name = "DateFactibilidad";
            this.DateFactibilidad.ReadOnly = true;
            this.DateFactibilidad.Visible = false;
            // 
            // Implantacion
            // 
            this.Implantacion.DataPropertyName = "Implantacion";
            this.Implantacion.HeaderText = "Implantacion y Volumetria";
            this.Implantacion.Name = "Implantacion";
            this.Implantacion.ReadOnly = true;
            this.Implantacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Implantacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Implantacion.Width = 70;
            // 
            // DateImplantacion
            // 
            this.DateImplantacion.DataPropertyName = "DateImplantacion";
            this.DateImplantacion.HeaderText = "Fecha Implantacion";
            this.DateImplantacion.Name = "DateImplantacion";
            this.DateImplantacion.ReadOnly = true;
            this.DateImplantacion.Visible = false;
            // 
            // Vistas
            // 
            this.Vistas.DataPropertyName = "Vistas";
            this.Vistas.HeaderText = "Vistas";
            this.Vistas.Name = "Vistas";
            this.Vistas.ReadOnly = true;
            this.Vistas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vistas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Vistas.Width = 70;
            // 
            // DateVistas
            // 
            this.DateVistas.DataPropertyName = "DateVistas";
            this.DateVistas.HeaderText = "Fechas Vistas";
            this.DateVistas.Name = "DateVistas";
            this.DateVistas.ReadOnly = true;
            this.DateVistas.Visible = false;
            // 
            // Municipal
            // 
            this.Municipal.DataPropertyName = "Municipal";
            this.Municipal.HeaderText = "Plano Municipal";
            this.Municipal.Name = "Municipal";
            this.Municipal.ReadOnly = true;
            this.Municipal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Municipal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Municipal.Width = 70;
            // 
            // DateMunicipal
            // 
            this.DateMunicipal.DataPropertyName = "DateMunicipal";
            this.DateMunicipal.HeaderText = "Fecha Municipal";
            this.DateMunicipal.Name = "DateMunicipal";
            this.DateMunicipal.ReadOnly = true;
            this.DateMunicipal.Visible = false;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo Tecnico";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Legajo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Legajo.Width = 70;
            // 
            // DateLegajo
            // 
            this.DateLegajo.DataPropertyName = "DateLegajo";
            this.DateLegajo.HeaderText = "Date Tecnico";
            this.DateLegajo.Name = "DateLegajo";
            this.DateLegajo.ReadOnly = true;
            this.DateLegajo.Visible = false;
            // 
            // Computo
            // 
            this.Computo.DataPropertyName = "Computo";
            this.Computo.HeaderText = "Computo y Calculo";
            this.Computo.Name = "Computo";
            this.Computo.ReadOnly = true;
            this.Computo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Computo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Computo.Width = 70;
            // 
            // DateComputo
            // 
            this.DateComputo.DataPropertyName = "DateComputo";
            this.DateComputo.HeaderText = "DateComputo";
            this.DateComputo.Name = "DateComputo";
            this.DateComputo.ReadOnly = true;
            this.DateComputo.Visible = false;
            // 
            // IdProyecto1
            // 
            this.IdProyecto1.DataPropertyName = "IdProyecto1";
            this.IdProyecto1.HeaderText = "IdProyecto1";
            this.IdProyecto1.Name = "IdProyecto1";
            this.IdProyecto1.ReadOnly = true;
            this.IdProyecto1.Visible = false;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 246);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seguimiento de Proyecto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTitulo);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 86);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selección del Proyecto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "label2";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(78, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(74, 13);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "txtDescripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(6, 19);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(641, 69);
            this.txtComentario.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtComentario);
            this.groupBox4.Location = new System.Drawing.Point(15, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comentarios";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(1, 563);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(6, 2);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "label2";
            // 
            // lblproject
            // 
            this.lblproject.AutoSize = true;
            this.lblproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproject.Location = new System.Drawing.Point(1, 565);
            this.lblproject.Name = "lblproject";
            this.lblproject.Size = new System.Drawing.Size(6, 2);
            this.lblproject.TabIndex = 10;
            this.lblproject.Text = "label2";
            // 
            // frmSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 574);
            this.Controls.Add(this.lblproject);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSeguimiento";
            this.Text = "Seguimiento de Proyecto";
            this.Load += new System.EventHandler(this.frmSeguimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox cbMunicipal;
        private System.Windows.Forms.CheckBox cbVistas;
        private System.Windows.Forms.CheckBox cbImplantacion;
        private System.Windows.Forms.CheckBox cbFactibilidad;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbComputo;
        private System.Windows.Forms.CheckBox cbLegajo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeguimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Factibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFactibilidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Implantacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateImplantacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVistas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Municipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateMunicipal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLegajo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Computo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateComputo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblproject;
    }
}