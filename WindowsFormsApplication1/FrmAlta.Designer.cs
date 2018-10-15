namespace WindowsFormsApplication1
{
    partial class FrmAlta
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbInst = new System.Windows.Forms.ComboBox();
            this.tbC1 = new System.Windows.Forms.TextBox();
            this.tbC2 = new System.Windows.Forms.TextBox();
            this.tbC3 = new System.Windows.Forms.TextBox();
            this.tbC4 = new System.Windows.Forms.TextBox();
            this.tbC5 = new System.Windows.Forms.TextBox();
            this.lbC1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCarr = new System.Windows.Forms.ComboBox();
            this.btAlta = new System.Windows.Forms.Button();
            this.lbS = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la institución en la cual se dará el alta del campus ";
            // 
            // cbInst
            // 
            this.cbInst.FormattingEnabled = true;
            this.cbInst.Location = new System.Drawing.Point(16, 39);
            this.cbInst.Name = "cbInst";
            this.cbInst.Size = new System.Drawing.Size(296, 21);
            this.cbInst.TabIndex = 1;
            this.cbInst.SelectedIndexChanged += new System.EventHandler(this.cbInst_SelectedIndexChanged);
            // 
            // tbC1
            // 
            this.tbC1.Location = new System.Drawing.Point(20, 91);
            this.tbC1.Name = "tbC1";
            this.tbC1.Size = new System.Drawing.Size(117, 20);
            this.tbC1.TabIndex = 2;
            this.tbC1.Text = "Nombre";
            this.tbC1.Visible = false;
            // 
            // tbC2
            // 
            this.tbC2.Location = new System.Drawing.Point(164, 92);
            this.tbC2.Name = "tbC2";
            this.tbC2.Size = new System.Drawing.Size(100, 20);
            this.tbC2.TabIndex = 3;
            this.tbC2.Text = "Domicilio";
            this.tbC2.Visible = false;
            // 
            // tbC3
            // 
            this.tbC3.Location = new System.Drawing.Point(318, 90);
            this.tbC3.Name = "tbC3";
            this.tbC3.Size = new System.Drawing.Size(100, 20);
            this.tbC3.TabIndex = 4;
            this.tbC3.Text = "55555555";
            this.tbC3.Visible = false;
            // 
            // tbC4
            // 
            this.tbC4.Location = new System.Drawing.Point(466, 93);
            this.tbC4.Name = "tbC4";
            this.tbC4.Size = new System.Drawing.Size(100, 20);
            this.tbC4.TabIndex = 5;
            this.tbC4.Text = "Ciudad";
            this.tbC4.Visible = false;
            // 
            // tbC5
            // 
            this.tbC5.Location = new System.Drawing.Point(619, 92);
            this.tbC5.Name = "tbC5";
            this.tbC5.Size = new System.Drawing.Size(100, 20);
            this.tbC5.TabIndex = 6;
            this.tbC5.Text = "Estado";
            this.tbC5.Visible = false;
            // 
            // lbC1
            // 
            this.lbC1.AutoSize = true;
            this.lbC1.Location = new System.Drawing.Point(17, 75);
            this.lbC1.Name = "lbC1";
            this.lbC1.Size = new System.Drawing.Size(169, 13);
            this.lbC1.TabIndex = 7;
            this.lbC1.Text = "Llena los datos del nuevo Campus";
            this.lbC1.Visible = false;
            // 
            // cb1
            // 
            this.cb1.Location = new System.Drawing.Point(738, 88);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(75, 23);
            this.cb1.TabIndex = 8;
            this.cb1.Text = "Listo";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.Visible = false;
            this.cb1.Click += new System.EventHandler(this.cb1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecciona la carrera que quieras dar de alta:";
            this.label2.Visible = false;
            // 
            // cbCarr
            // 
            this.cbCarr.FormattingEnabled = true;
            this.cbCarr.Location = new System.Drawing.Point(20, 166);
            this.cbCarr.Name = "cbCarr";
            this.cbCarr.Size = new System.Drawing.Size(186, 21);
            this.cbCarr.TabIndex = 10;
            this.cbCarr.Visible = false;
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(738, 162);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(75, 23);
            this.btAlta.TabIndex = 11;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Visible = false;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Location = new System.Drawing.Point(20, 217);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(175, 13);
            this.lbS.TabIndex = 12;
            this.lbS.Text = "Seleccione el servicio a dar de alta:";
            this.lbS.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Visible = false;
            // 
            // bS
            // 
            this.bS.Location = new System.Drawing.Point(738, 237);
            this.bS.Name = "bS";
            this.bS.Size = new System.Drawing.Size(75, 23);
            this.bS.TabIndex = 19;
            this.bS.Text = "Listo";
            this.bS.UseVisualStyleBackColor = true;
            this.bS.Visible = false;
            this.bS.Click += new System.EventHandler(this.bS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Duración:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(307, 164);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Créditos";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(529, 162);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 23;
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 499);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bS);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.cbCarr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lbC1);
            this.Controls.Add(this.tbC5);
            this.Controls.Add(this.tbC4);
            this.Controls.Add(this.tbC3);
            this.Controls.Add(this.tbC2);
            this.Controls.Add(this.tbC1);
            this.Controls.Add(this.cbInst);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlta";
            this.Text = "Alta Nuevo Campus";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInst;
        private System.Windows.Forms.TextBox tbC1;
        private System.Windows.Forms.TextBox tbC2;
        private System.Windows.Forms.TextBox tbC3;
        private System.Windows.Forms.TextBox tbC4;
        private System.Windows.Forms.TextBox tbC5;
        private System.Windows.Forms.Label lbC1;
        private System.Windows.Forms.Button cb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCarr;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}