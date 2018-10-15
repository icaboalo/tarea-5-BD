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
            this.button1.Location = new System.Drawing.Point(378, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmProgramasAlm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCampus);
            this.Controls.Add(this.cbInst);
            this.Name = "FrmProgramasAlm";
            this.Text = "FrmProgramasAlum";
            this.Load += new System.EventHandler(this.FrmProgramasAlm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInst;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}