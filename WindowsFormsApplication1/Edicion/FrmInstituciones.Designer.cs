namespace WindowsFormsApplication1.Edicion
{
    partial class FrmInstituciones
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
            this.dsInstitucion = new WindowsFormsApplication1.dsInstitucion();
            this.iNSTITUCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTITUCIONTableAdapter = new WindowsFormsApplication1.dsInstitucionTableAdapters.INSTITUCIONTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.dsInstitucionTableAdapters.TableAdapterManager();
            this.iDINSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMINSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIGLASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualiza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstitucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTITUCIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDINSTDataGridViewTextBoxColumn,
            this.nOMINSDataGridViewTextBoxColumn,
            this.sIGLASDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNSTITUCIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsInstitucion
            // 
            this.dsInstitucion.DataSetName = "dsInstitucion";
            this.dsInstitucion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSTITUCIONBindingSource
            // 
            this.iNSTITUCIONBindingSource.DataMember = "INSTITUCION";
            this.iNSTITUCIONBindingSource.DataSource = this.dsInstitucion;
            // 
            // iNSTITUCIONTableAdapter
            // 
            this.iNSTITUCIONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.INSTITUCIONTableAdapter = this.iNSTITUCIONTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.dsInstitucionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDINSTDataGridViewTextBoxColumn
            // 
            this.iDINSTDataGridViewTextBoxColumn.DataPropertyName = "IDINST";
            this.iDINSTDataGridViewTextBoxColumn.HeaderText = "IDINST";
            this.iDINSTDataGridViewTextBoxColumn.Name = "iDINSTDataGridViewTextBoxColumn";
            // 
            // nOMINSDataGridViewTextBoxColumn
            // 
            this.nOMINSDataGridViewTextBoxColumn.DataPropertyName = "NOMINS";
            this.nOMINSDataGridViewTextBoxColumn.HeaderText = "NOMINS";
            this.nOMINSDataGridViewTextBoxColumn.Name = "nOMINSDataGridViewTextBoxColumn";
            // 
            // sIGLASDataGridViewTextBoxColumn
            // 
            this.sIGLASDataGridViewTextBoxColumn.DataPropertyName = "SIGLAS";
            this.sIGLASDataGridViewTextBoxColumn.HeaderText = "SIGLAS";
            this.sIGLASDataGridViewTextBoxColumn.Name = "sIGLASDataGridViewTextBoxColumn";
            // 
            // btnActualiza
            // 
            this.btnActualiza.Location = new System.Drawing.Point(549, 219);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(103, 39);
            this.btnActualiza.TabIndex = 1;
            this.btnActualiza.Text = "Actualiza";
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInstituciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 313);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInstituciones";
            this.Text = "Editar Instituciones";
            this.Load += new System.EventHandler(this.FrmInstituciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstitucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTITUCIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dsInstitucion dsInstitucion;
        private System.Windows.Forms.BindingSource iNSTITUCIONBindingSource;
        private dsInstitucionTableAdapters.INSTITUCIONTableAdapter iNSTITUCIONTableAdapter;
        private dsInstitucionTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDINSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMINSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIGLASDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualiza;
    }
}