namespace WindowsFormsApplication1.Edicion
{
    partial class FrmServicios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsServicios = new WindowsFormsApplication1.dsServicios();
            this.sERVICIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICIOSTableAdapter = new WindowsFormsApplication1.dsServiciosTableAdapters.SERVICIOSTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.dsServiciosTableAdapters.TableAdapterManager();
            this.iDSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMSERVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUGARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTOEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualiza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSERDataGridViewTextBoxColumn,
            this.nOMSERVDataGridViewTextBoxColumn,
            this.lUGARDataGridViewTextBoxColumn,
            this.cOSTOEXTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sERVICIOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsServicios
            // 
            this.dsServicios.DataSetName = "dsServicios";
            this.dsServicios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICIOSBindingSource
            // 
            this.sERVICIOSBindingSource.DataMember = "SERVICIOS";
            this.sERVICIOSBindingSource.DataSource = this.dsServicios;
            // 
            // sERVICIOSTableAdapter
            // 
            this.sERVICIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SERVICIOSTableAdapter = this.sERVICIOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.dsServiciosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDSERDataGridViewTextBoxColumn
            // 
            this.iDSERDataGridViewTextBoxColumn.DataPropertyName = "IDSER";
            this.iDSERDataGridViewTextBoxColumn.HeaderText = "IDSER";
            this.iDSERDataGridViewTextBoxColumn.Name = "iDSERDataGridViewTextBoxColumn";
            // 
            // nOMSERVDataGridViewTextBoxColumn
            // 
            this.nOMSERVDataGridViewTextBoxColumn.DataPropertyName = "NOMSERV";
            this.nOMSERVDataGridViewTextBoxColumn.HeaderText = "NOMSERV";
            this.nOMSERVDataGridViewTextBoxColumn.Name = "nOMSERVDataGridViewTextBoxColumn";
            // 
            // lUGARDataGridViewTextBoxColumn
            // 
            this.lUGARDataGridViewTextBoxColumn.DataPropertyName = "LUGAR";
            this.lUGARDataGridViewTextBoxColumn.HeaderText = "LUGAR";
            this.lUGARDataGridViewTextBoxColumn.Name = "lUGARDataGridViewTextBoxColumn";
            // 
            // cOSTOEXTDataGridViewTextBoxColumn
            // 
            this.cOSTOEXTDataGridViewTextBoxColumn.DataPropertyName = "COSTOEXT";
            this.cOSTOEXTDataGridViewTextBoxColumn.HeaderText = "COSTOEXT";
            this.cOSTOEXTDataGridViewTextBoxColumn.Name = "cOSTOEXTDataGridViewTextBoxColumn";
            // 
            // btnActualiza
            // 
            this.btnActualiza.Location = new System.Drawing.Point(415, 278);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(93, 37);
            this.btnActualiza.TabIndex = 1;
            this.btnActualiza.Text = "Actualiza";
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 342);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmServicios";
            this.Text = "Editar Servicios";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dsServicios dsServicios;
        private System.Windows.Forms.BindingSource sERVICIOSBindingSource;
        private dsServiciosTableAdapters.SERVICIOSTableAdapter sERVICIOSTableAdapter;
        private dsServiciosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMSERVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUGARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTOEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualiza;
    }
}