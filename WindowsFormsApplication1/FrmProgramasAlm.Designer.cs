namespace WindowsFormsApplication1
{
    partial class FrmProgramasAlm
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
            this.cbInst = new System.Windows.Forms.ComboBox();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbinst1 = new System.Windows.Forms.ComboBox();
            this.cbCampus1 = new System.Windows.Forms.ComboBox();
            this.cbCampus2 = new System.Windows.Forms.ComboBox();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbInst
            // 
            this.cbInst.FormattingEnabled = true;
            this.cbInst.Location = new System.Drawing.Point(40, 68);
            this.cbInst.Name = "cbInst";
            this.cbInst.Size = new System.Drawing.Size(121, 21);
            this.cbInst.TabIndex = 0;
            this.cbInst.SelectedIndexChanged += new System.EventHandler(this.cbInst_SelectedIndexChanged);
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Location = new System.Drawing.Point(198, 68);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(121, 21);
            this.cbCampus.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cantidad de servicios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Campus con más profesores del grado seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de institución:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de campus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de institución:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de campus 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre de campus 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Grado:";
            // 
            // cbinst1
            // 
            this.cbinst1.FormattingEnabled = true;
            this.cbinst1.Location = new System.Drawing.Point(31, 285);
            this.cbinst1.Name = "cbinst1";
            this.cbinst1.Size = new System.Drawing.Size(171, 21);
            this.cbinst1.TabIndex = 10;
            this.cbinst1.SelectedIndexChanged += new System.EventHandler(this.cbinst1_SelectedIndexChanged);
            // 
            // cbCampus1
            // 
            this.cbCampus1.FormattingEnabled = true;
            this.cbCampus1.Location = new System.Drawing.Point(245, 285);
            this.cbCampus1.Name = "cbCampus1";
            this.cbCampus1.Size = new System.Drawing.Size(121, 21);
            this.cbCampus1.TabIndex = 11;
            // 
            // cbCampus2
            // 
            this.cbCampus2.FormattingEnabled = true;
            this.cbCampus2.Location = new System.Drawing.Point(425, 285);
            this.cbCampus2.Name = "cbCampus2";
            this.cbCampus2.Size = new System.Drawing.Size(121, 21);
            this.cbCampus2.TabIndex = 12;
            // 
            // cbGrado
            // 
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Items.AddRange(new object[] {
            "doctor",
            "licenciado",
            "maestria"});
            this.cbGrado.Location = new System.Drawing.Point(574, 285);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(121, 21);
            this.cbGrado.TabIndex = 13;
            // 
            // FrmProgramasAlm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 458);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.cbCampus2);
            this.Controls.Add(this.cbCampus1);
            this.Controls.Add(this.cbinst1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCampus);
            this.Controls.Add(this.cbInst);
            this.Name = "FrmProgramasAlm";
            this.Text = "Funciones y procedimientos";
            this.Load += new System.EventHandler(this.FrmProgramasAlm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInst;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbinst1;
        private System.Windows.Forms.ComboBox cbCampus1;
        private System.Windows.Forms.ComboBox cbCampus2;
        private System.Windows.Forms.ComboBox cbGrado;
    }
}