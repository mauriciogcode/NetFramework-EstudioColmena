﻿
namespace Colmena.Entidades.Vista.FormularioTipologiasProyecto
{
    partial class frmTipologia
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCaracteristicas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(779, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAgregar.Location = new System.Drawing.Point(343, 437);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipologias de Proyecto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 351);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtTipo.Location = new System.Drawing.Point(79, 86);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(224, 29);
            this.txtTipo.TabIndex = 5;
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCaracteristicas.Location = new System.Drawing.Point(17, 156);
            this.txtCaracteristicas.Multiline = true;
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            this.txtCaracteristicas.Size = new System.Drawing.Size(320, 253);
            this.txtCaracteristicas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Caracteristicas";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnModificar.Location = new System.Drawing.Point(492, 437);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 34);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEliminar.Location = new System.Drawing.Point(639, 437);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmTipologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 483);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaracteristicas);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipologia";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmTipologia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCaracteristicas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}