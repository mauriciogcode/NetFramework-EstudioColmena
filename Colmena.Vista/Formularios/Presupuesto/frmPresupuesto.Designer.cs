
namespace Colmena.Vista.Formularios.Presupuesto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearPresupuesto = new System.Windows.Forms.Button();
            this.txtPrecioReunion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProyecto = new System.Windows.Forms.DataGridView();
            this.txtPrecioTipologia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadReuniones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.txtProyecto);
            this.groupBox2.Controls.Add(this.txtTipo);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proyecto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtDescripcion.Location = new System.Drawing.Point(81, 78);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(340, 88);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtProyecto
            // 
            this.txtProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtProyecto.Location = new System.Drawing.Point(81, 13);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(340, 20);
            this.txtProyecto.TabIndex = 13;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtTipo.Location = new System.Drawing.Point(81, 42);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(340, 20);
            this.txtTipo.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDescripcion.Location = new System.Drawing.Point(9, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblNombre.Location = new System.Drawing.Point(7, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Proyecto:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTipo.Location = new System.Drawing.Point(9, 44);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(252, 58);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(156, 20);
            this.TxtMail.TabIndex = 124;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDocumento.Location = new System.Drawing.Point(48, 58);
            this.TxtDocumento.MaxLength = 8;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(156, 20);
            this.TxtDocumento.TabIndex = 115;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(48, 19);
            this.txtCliente.MaxLength = 100;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(156, 20);
            this.txtCliente.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Domicilio";
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(264, 19);
            this.TxtCalle.MaxLength = 100;
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(156, 20);
            this.TxtCalle.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 119;
            this.label9.Text = "Cliente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TxtMail);
            this.groupBox4.Controls.Add(this.txtCliente);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TxtDocumento);
            this.groupBox4.Controls.Add(this.TxtCalle);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 118);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(48, 58);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Tel:";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(467, 13);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(333, 118);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.SelectionChanged += new System.EventHandler(this.dgvCliente_SelectionChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(713, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearPresupuesto
            // 
            this.btnCrearPresupuesto.Location = new System.Drawing.Point(632, 415);
            this.btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            this.btnCrearPresupuesto.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPresupuesto.TabIndex = 4;
            this.btnCrearPresupuesto.Text = "Crear";
            this.btnCrearPresupuesto.UseVisualStyleBackColor = true;
            this.btnCrearPresupuesto.Click += new System.EventHandler(this.btnCrearPresupuesto_Click);
            // 
            // txtPrecioReunion
            // 
            this.txtPrecioReunion.Enabled = false;
            this.txtPrecioReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrecioReunion.Location = new System.Drawing.Point(127, 327);
            this.txtPrecioReunion.MaxLength = 5;
            this.txtPrecioReunion.Name = "txtPrecioReunion";
            this.txtPrecioReunion.Size = new System.Drawing.Size(90, 23);
            this.txtPrecioReunion.TabIndex = 129;
            this.txtPrecioReunion.Text = "1500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(16, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 126;
            this.label8.Text = "Precio Reunion";
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Location = new System.Drawing.Point(467, 145);
            this.dgvProyecto.MultiSelect = false;
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.ReadOnly = true;
            this.dgvProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyecto.Size = new System.Drawing.Size(333, 195);
            this.dgvProyecto.TabIndex = 132;
            this.dgvProyecto.SelectionChanged += new System.EventHandler(this.dgvProyecto_SelectionChanged);
            // 
            // txtPrecioTipologia
            // 
            this.txtPrecioTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrecioTipologia.Location = new System.Drawing.Point(343, 327);
            this.txtPrecioTipologia.MaxLength = 10;
            this.txtPrecioTipologia.Name = "txtPrecioTipologia";
            this.txtPrecioTipologia.Size = new System.Drawing.Size(90, 23);
            this.txtPrecioTipologia.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(232, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 133;
            this.label1.Text = "Precio Tipologia*";
            // 
            // txtCantidadReuniones
            // 
            this.txtCantidadReuniones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCantidadReuniones.Location = new System.Drawing.Point(178, 370);
            this.txtCantidadReuniones.MaxLength = 5;
            this.txtCantidadReuniones.Name = "txtCantidadReuniones";
            this.txtCantidadReuniones.Size = new System.Drawing.Size(90, 23);
            this.txtCantidadReuniones.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "Cantidad de Reuniones*";
            // 
            // frmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.txtCantidadReuniones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioTipologia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProyecto);
            this.Controls.Add(this.btnCrearPresupuesto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtPrecioReunion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmPresupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.frmPresupuesto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearPresupuesto;
        private System.Windows.Forms.TextBox txtPrecioReunion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProyecto;
        private System.Windows.Forms.TextBox txtPrecioTipologia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadReuniones;
        private System.Windows.Forms.Label label3;
    }
}