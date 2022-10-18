namespace Colmena.Entidades.Vista.FormularioReunion
{
    partial class frmControl
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReunionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reunionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUD = new Colmena.Entidades.dsCRUD();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.reunionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reunionTableAdapter = new Colmena.Entidades.dsCRUDTableAdapters.ReunionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 47);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 47);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.fechaReunionDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.fechaDeCreacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reunionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(136, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdReunion";
            this.Column1.HeaderText = "Nro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // fechaReunionDataGridViewTextBoxColumn
            // 
            this.fechaReunionDataGridViewTextBoxColumn.DataPropertyName = "FechaReunion";
            this.fechaReunionDataGridViewTextBoxColumn.HeaderText = "Fecha de Reunion";
            this.fechaReunionDataGridViewTextBoxColumn.Name = "fechaReunionDataGridViewTextBoxColumn";
            this.fechaReunionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAsesor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Asesor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProyecto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Proyecto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fechaDeCreacionDataGridViewTextBoxColumn
            // 
            this.fechaDeCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaDeCreacion";
            this.fechaDeCreacionDataGridViewTextBoxColumn.HeaderText = "FechaDeCreacion";
            this.fechaDeCreacionDataGridViewTextBoxColumn.Name = "fechaDeCreacionDataGridViewTextBoxColumn";
            this.fechaDeCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reunionBindingSource
            // 
            this.reunionBindingSource.DataMember = "Reunion";
            this.reunionBindingSource.DataSource = this.dsCRUD;
            // 
            // dsCRUD
            // 
            this.dsCRUD.DataSetName = "dsCRUD";
            this.dsCRUD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 204);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 44);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // reunionBindingSource1
            // 
            this.reunionBindingSource1.DataMember = "Reunion";
            this.reunionBindingSource1.DataSource = this.dsCRUD;
            // 
            // reunionTableAdapter
            // 
            this.reunionTableAdapter.ClearBeforeFill = true;
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 260);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmControl";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.FormularioControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private dsCRUD dsCRUD;
        private System.Windows.Forms.BindingSource reunionBindingSource;
        private dsCRUDTableAdapters.ReunionTableAdapter reunionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reunionBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReunionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeCreacionDataGridViewTextBoxColumn;
    }
}