
namespace Colmena.Entidades.Vista.FormularioReunion
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(3, 0);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(26, 18);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "00";
            // 
            // lblEvent
            // 
            this.lblEvent.Location = new System.Drawing.Point(27, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(146, 45);
            this.lblEvent.TabIndex = 1;
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEvent.Click += new System.EventHandler(this.lblEvent_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(4, 32);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 2;
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Location = new System.Drawing.Point(4, 107);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(0, 13);
            this.lblAsesor.TabIndex = 6;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(4, 78);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(0, 13);
            this.lblProyecto.TabIndex = 5;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAsesor);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lbldays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(176, 120);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.Label lblProyecto;
    }
}
