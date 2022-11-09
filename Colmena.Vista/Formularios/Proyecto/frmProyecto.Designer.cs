
namespace Colmena.Vista.Formularios.Proyecto
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
            this.dgvProyecto = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTerreno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.txtNiveles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecursos = new System.Windows.Forms.TextBox();
            this.lblRecursos = new System.Windows.Forms.Label();
            this.txtEstilo = new System.Windows.Forms.TextBox();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.txtBaño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Location = new System.Drawing.Point(318, 12);
            this.dgvProyecto.MultiSelect = false;
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.ReadOnly = true;
            this.dgvProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyecto.Size = new System.Drawing.Size(625, 500);
            this.dgvProyecto.TabIndex = 0;
            this.dgvProyecto.SelectionChanged += new System.EventHandler(this.dgvProyecto_SelectionChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(868, 537);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(787, 537);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(10, 537);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(102, 537);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(198, 537);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(12, 93);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 115);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(9, 73);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 17);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion:*";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre.Location = new System.Drawing.Point(12, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 23);
            this.txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(9, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(150, 17);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre del Proyecto:*";
            // 
            // txtTerreno
            // 
            this.txtTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTerreno.Location = new System.Drawing.Point(91, 259);
            this.txtTerreno.Name = "txtTerreno";
            this.txtTerreno.Size = new System.Drawing.Size(191, 23);
            this.txtTerreno.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Terreno";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCliente.Location = new System.Drawing.Point(92, 221);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(190, 23);
            this.txtCliente.TabIndex = 15;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCliente.Location = new System.Drawing.Point(9, 224);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 17);
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "Cliente*";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSuperficie.Location = new System.Drawing.Point(91, 297);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(191, 23);
            this.txtSuperficie.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Superficie";
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHabitaciones.Location = new System.Drawing.Point(239, 351);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(45, 23);
            this.txtHabitaciones.TabIndex = 25;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHabitaciones.Location = new System.Drawing.Point(140, 351);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(90, 17);
            this.lblHabitaciones.TabIndex = 24;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // txtNiveles
            // 
            this.txtNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNiveles.Location = new System.Drawing.Point(69, 348);
            this.txtNiveles.Name = "txtNiveles";
            this.txtNiveles.Size = new System.Drawing.Size(65, 23);
            this.txtNiveles.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(9, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Niveles";
            // 
            // txtRecursos
            // 
            this.txtRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRecursos.Location = new System.Drawing.Point(92, 492);
            this.txtRecursos.Name = "txtRecursos";
            this.txtRecursos.Size = new System.Drawing.Size(192, 23);
            this.txtRecursos.TabIndex = 29;
            // 
            // lblRecursos
            // 
            this.lblRecursos.AutoSize = true;
            this.lblRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecursos.Location = new System.Drawing.Point(12, 495);
            this.lblRecursos.Name = "lblRecursos";
            this.lblRecursos.Size = new System.Drawing.Size(68, 17);
            this.lblRecursos.TabIndex = 28;
            this.lblRecursos.Text = "Recursos";
            // 
            // txtEstilo
            // 
            this.txtEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEstilo.Location = new System.Drawing.Point(91, 443);
            this.txtEstilo.Name = "txtEstilo";
            this.txtEstilo.Size = new System.Drawing.Size(191, 23);
            this.txtEstilo.TabIndex = 27;
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstilo.Location = new System.Drawing.Point(12, 443);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(42, 17);
            this.lblEstilo.TabIndex = 26;
            this.lblEstilo.Text = "Estilo";
            // 
            // txtBaño
            // 
            this.txtBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBaño.Location = new System.Drawing.Point(91, 398);
            this.txtBaño.Name = "txtBaño";
            this.txtBaño.Size = new System.Drawing.Size(191, 23);
            this.txtBaño.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Baño";
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 585);
            this.Controls.Add(this.txtBaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecursos);
            this.Controls.Add(this.lblRecursos);
            this.Controls.Add(this.txtEstilo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.txtNiveles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTerreno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvProyecto);
            this.Name = "frmProyecto";
            this.Text = "frmProyecto";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProyecto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTerreno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.TextBox txtNiveles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecursos;
        private System.Windows.Forms.Label lblRecursos;
        private System.Windows.Forms.TextBox txtEstilo;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.TextBox txtBaño;
        private System.Windows.Forms.Label label2;
    }
}