namespace WindowsFormsApplication1
{
    partial class FrmCarreras
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
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgInstituciones = new System.Windows.Forms.DataGridView();
            this.totalServicios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstituciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(12, 12);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbCarrera.TabIndex = 0;
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(140, 13);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cbCiudad.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(267, 12);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgInstituciones
            // 
            this.dgInstituciones.AllowUserToAddRows = false;
            this.dgInstituciones.AllowUserToDeleteRows = false;
            this.dgInstituciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstituciones.Location = new System.Drawing.Point(13, 41);
            this.dgInstituciones.Name = "dgInstituciones";
            this.dgInstituciones.ReadOnly = true;
            this.dgInstituciones.Size = new System.Drawing.Size(453, 208);
            this.dgInstituciones.TabIndex = 5;
            // 
            // totalServicios
            // 
            this.totalServicios.AutoSize = true;
            this.totalServicios.Location = new System.Drawing.Point(348, 17);
            this.totalServicios.Name = "totalServicios";
            this.totalServicios.Size = new System.Drawing.Size(0, 13);
            this.totalServicios.TabIndex = 6;
            // 
            // FrmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 261);
            this.Controls.Add(this.totalServicios);
            this.Controls.Add(this.dgInstituciones);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cbCarrera);
            this.Name = "FrmCarreras";
            this.Text = "FrmCarreras";
            this.Load += new System.EventHandler(this.FrmCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstituciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgInstituciones;
        private System.Windows.Forms.Label totalServicios;
    }
}