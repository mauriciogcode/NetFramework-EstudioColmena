
namespace Colmena.Entidades.Vista.FormularioProyecto
{
	partial class frmProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyecto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNProyecto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNiveles = new System.Windows.Forms.TextBox();
            this.TxtHabitaciones = new System.Windows.Forms.TextBox();
            this.TxtSuperficie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBaño = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRecursos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEstilo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTerreno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cliente1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dsCRUDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUD = new Colmena.Entidades.dsCRUD();
            this.proyectoTableAdapter = new Colmena.Entidades.dsCRUDTableAdapters.ProyectoTableAdapter();
            this.cliente1TableAdapter = new Colmena.Entidades.dsCRUDTableAdapters.Cliente1TableAdapter();
            this.dgvProyecto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.lblProyecto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 76);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(978, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(38, 50);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1014, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 50);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(939, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 50);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.ForeColor = System.Drawing.Color.White;
            this.lblProyecto.Location = new System.Drawing.Point(519, 17);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(179, 33);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "PROYECTO";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSalir.Location = new System.Drawing.Point(934, 657);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 32);
            this.btnSalir.TabIndex = 93;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEliminar.Location = new System.Drawing.Point(814, 657);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 32);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnModificar.Location = new System.Drawing.Point(688, 657);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 32);
            this.btnModificar.TabIndex = 91;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAgregar.Location = new System.Drawing.Point(560, 657);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 32);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNProyecto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TxtDescripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(362, 208);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proyecto";
            this.groupBox1.UseWaitCursor = true;
            // 
            // TxtNProyecto
            // 
            this.TxtNProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtNProyecto.Location = new System.Drawing.Point(127, 54);
            this.TxtNProyecto.Name = "TxtNProyecto";
            this.TxtNProyecto.Size = new System.Drawing.Size(222, 29);
            this.TxtNProyecto.TabIndex = 0;
            this.TxtNProyecto.UseWaitCursor = true;
            this.TxtNProyecto.TextChanged += new System.EventHandler(this.TxtNProyecto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "Nombre";
            this.label3.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 24);
            this.label15.TabIndex = 44;
            this.label15.Text = "Descripcion";
            this.label15.UseWaitCursor = true;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtDescripcion.Location = new System.Drawing.Point(127, 88);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(222, 115);
            this.TxtDescripcion.TabIndex = 1;
            this.TxtDescripcion.UseWaitCursor = true;
            // 
            // TxtNiveles
            // 
            this.TxtNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtNiveles.Location = new System.Drawing.Point(141, 444);
            this.TxtNiveles.Name = "TxtNiveles";
            this.TxtNiveles.Size = new System.Drawing.Size(221, 29);
            this.TxtNiveles.TabIndex = 6;
            // 
            // TxtHabitaciones
            // 
            this.TxtHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtHabitaciones.Location = new System.Drawing.Point(141, 489);
            this.TxtHabitaciones.Name = "TxtHabitaciones";
            this.TxtHabitaciones.Size = new System.Drawing.Size(221, 29);
            this.TxtHabitaciones.TabIndex = 7;
            // 
            // TxtSuperficie
            // 
            this.TxtSuperficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtSuperficie.Location = new System.Drawing.Point(141, 402);
            this.TxtSuperficie.Name = "TxtSuperficie";
            this.TxtSuperficie.Size = new System.Drawing.Size(221, 29);
            this.TxtSuperficie.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 95;
            this.label6.Text = "Baño";
            // 
            // TxtBaño
            // 
            this.TxtBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtBaño.Location = new System.Drawing.Point(141, 532);
            this.TxtBaño.Name = "TxtBaño";
            this.TxtBaño.Size = new System.Drawing.Size(221, 29);
            this.TxtBaño.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 98;
            this.label8.Text = "Habitaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 97;
            this.label9.Text = "Superficie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 96;
            this.label5.Text = "Niveles";
            // 
            // TxtRecursos
            // 
            this.TxtRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtRecursos.Location = new System.Drawing.Point(140, 618);
            this.TxtRecursos.Name = "TxtRecursos";
            this.TxtRecursos.Size = new System.Drawing.Size(222, 29);
            this.TxtRecursos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 142;
            this.label1.Text = "Recursos";
            // 
            // TxtEstilo
            // 
            this.TxtEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtEstilo.Location = new System.Drawing.Point(141, 576);
            this.TxtEstilo.Name = "TxtEstilo";
            this.TxtEstilo.Size = new System.Drawing.Size(222, 29);
            this.TxtEstilo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 138;
            this.label4.Text = "Terreno";
            // 
            // TxtTerreno
            // 
            this.TxtTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtTerreno.Location = new System.Drawing.Point(141, 363);
            this.TxtTerreno.Name = "TxtTerreno";
            this.TxtTerreno.Size = new System.Drawing.Size(221, 29);
            this.TxtTerreno.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 139;
            this.label7.Text = "Estilo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 144;
            this.label2.Text = "Cliente";
            // 
            // cliente1BindingSource
            // 
            this.cliente1BindingSource.DataMember = "Cliente1";
            this.cliente1BindingSource.DataSource = this.dsCRUDBindingSource;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.dsCRUDBindingSource;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCliente.Location = new System.Drawing.Point(140, 316);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(221, 29);
            this.txtCliente.TabIndex = 145;
            // 
            // dsCRUDBindingSource
            // 
            this.dsCRUDBindingSource.DataSource = this.dsCRUD;
            this.dsCRUDBindingSource.Position = 0;
            // 
            // dsCRUD
            // 
            this.dsCRUD.DataSetName = "dsCRUD";
            this.dsCRUD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // cliente1TableAdapter
            // 
            this.cliente1TableAdapter.ClearBeforeFill = true;
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Location = new System.Drawing.Point(381, 103);
            this.dgvProyecto.MultiSelect = false;
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.ReadOnly = true;
            this.dgvProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyecto.Size = new System.Drawing.Size(659, 542);
            this.dgvProyecto.TabIndex = 146;
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 701);
            this.Controls.Add(this.dgvProyecto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRecursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEstilo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTerreno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNiveles);
            this.Controls.Add(this.TxtHabitaciones);
            this.Controls.Add(this.TxtSuperficie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBaño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProyecto";
            this.Text = "frmProyecto";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblProyecto;
		private System.Windows.Forms.Button btnMinimizar;
		private System.Windows.Forms.Button btnMaximizar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox TxtDescripcion;
		private System.Windows.Forms.TextBox TxtNiveles;
		private System.Windows.Forms.TextBox TxtHabitaciones;
		private System.Windows.Forms.TextBox TxtSuperficie;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtBaño;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtRecursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEstilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTerreno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNProyecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dsCRUDBindingSource;
        private dsCRUD dsCRUD;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private dsCRUDTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
        private System.Windows.Forms.BindingSource cliente1BindingSource;
        private dsCRUDTableAdapters.Cliente1TableAdapter cliente1TableAdapter;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvProyecto;
    }
}