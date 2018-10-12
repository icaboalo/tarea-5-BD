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
            this.dgCarrera = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dtServicios = new System.Windows.Forms.DataGridView();
            this.dgInstituciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtServicios)).BeginInit();
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
            // dgCarrera
            // 
            this.dgCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrera.Location = new System.Drawing.Point(13, 40);
            this.dgCarrera.Name = "dgCarrera";
            this.dgCarrera.Size = new System.Drawing.Size(158, 101);
            this.dgCarrera.TabIndex = 2;
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
            // dtServicios
            // 
            this.dtServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtServicios.Location = new System.Drawing.Point(195, 40);
            this.dtServicios.Name = "dtServicios";
            this.dtServicios.Size = new System.Drawing.Size(158, 101);
            this.dtServicios.TabIndex = 4;
            // 
            // dgInstituciones
            // 
            this.dgInstituciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstituciones.Location = new System.Drawing.Point(13, 148);
            this.dgInstituciones.Name = "dgInstituciones";
            this.dgInstituciones.Size = new System.Drawing.Size(340, 101);
            this.dgInstituciones.TabIndex = 5;
            // 
            // FrmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 261);
            this.Controls.Add(this.dgInstituciones);
            this.Controls.Add(this.dtServicios);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dgCarrera);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cbCarrera);
            this.Name = "FrmCarreras";
            this.Text = "FrmCarreras";
            this.Load += new System.EventHandler(this.FrmCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstituciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.DataGridView dgCarrera;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dtServicios;
        private System.Windows.Forms.DataGridView dgInstituciones;
    }
}