namespace My_first_GUI_App
{
    partial class FrmRandomCombo
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.BtnGenerate1 = new System.Windows.Forms.Button();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.RdoLessthan500 = new System.Windows.Forms.RadioButton();
            this.RdoGreaterthan500 = new System.Windows.Forms.RadioButton();
            this.RdoLessthan50 = new System.Windows.Forms.RadioButton();
            this.RdoGreaterthan50 = new System.Windows.Forms.RadioButton();
            this.cmbrandom1 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(170, 99);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(170, 241);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(21, 99);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(121, 24);
            this.cmbRandom.TabIndex = 2;
            this.cmbRandom.SelectedIndexChanged += new System.EventHandler(this.cmbRandom_SelectedIndexChanged);
            // 
            // BtnGenerate1
            // 
            this.BtnGenerate1.Location = new System.Drawing.Point(671, 99);
            this.BtnGenerate1.Name = "BtnGenerate1";
            this.BtnGenerate1.Size = new System.Drawing.Size(75, 24);
            this.BtnGenerate1.TabIndex = 3;
            this.BtnGenerate1.Text = "Generate";
            this.BtnGenerate1.UseVisualStyleBackColor = true;
            this.BtnGenerate1.Click += new System.EventHandler(this.BtnGenerate1_Click);
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(671, 241);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(84, 23);
            this.BtnReset1.TabIndex = 4;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            this.BtnReset1.Click += new System.EventHandler(this.BtnReset1_Click);
            // 
            // RdoLessthan500
            // 
            this.RdoLessthan500.AutoSize = true;
            this.RdoLessthan500.Location = new System.Drawing.Point(180, 150);
            this.RdoLessthan500.Name = "RdoLessthan500";
            this.RdoLessthan500.Size = new System.Drawing.Size(119, 21);
            this.RdoLessthan500.TabIndex = 5;
            this.RdoLessthan500.TabStop = true;
            this.RdoLessthan500.Text = "Less than 500";
            this.RdoLessthan500.UseVisualStyleBackColor = true;
            // 
            // RdoGreaterthan500
            // 
            this.RdoGreaterthan500.AutoSize = true;
            this.RdoGreaterthan500.Location = new System.Drawing.Point(180, 191);
            this.RdoGreaterthan500.Name = "RdoGreaterthan500";
            this.RdoGreaterthan500.Size = new System.Drawing.Size(138, 21);
            this.RdoGreaterthan500.TabIndex = 6;
            this.RdoGreaterthan500.TabStop = true;
            this.RdoGreaterthan500.Text = "Greater than 500";
            this.RdoGreaterthan500.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan50
            // 
            this.RdoLessthan50.AutoSize = true;
            this.RdoLessthan50.Location = new System.Drawing.Point(678, 150);
            this.RdoLessthan50.Name = "RdoLessthan50";
            this.RdoLessthan50.Size = new System.Drawing.Size(111, 21);
            this.RdoLessthan50.TabIndex = 7;
            this.RdoLessthan50.TabStop = true;
            this.RdoLessthan50.Text = "Less than 50";
            this.RdoLessthan50.UseVisualStyleBackColor = true;
            // 
            // RdoGreaterthan50
            // 
            this.RdoGreaterthan50.AutoSize = true;
            this.RdoGreaterthan50.Location = new System.Drawing.Point(678, 191);
            this.RdoGreaterthan50.Name = "RdoGreaterthan50";
            this.RdoGreaterthan50.Size = new System.Drawing.Size(130, 21);
            this.RdoGreaterthan50.TabIndex = 8;
            this.RdoGreaterthan50.TabStop = true;
            this.RdoGreaterthan50.Text = "Greater than 50";
            this.RdoGreaterthan50.UseVisualStyleBackColor = true;
            // 
            // cmbrandom1
            // 
            this.cmbrandom1.FormattingEnabled = true;
            this.cmbrandom1.Location = new System.Drawing.Point(514, 100);
            this.cmbrandom1.Name = "cmbrandom1";
            this.cmbrandom1.Size = new System.Drawing.Size(121, 24);
            this.cmbrandom1.TabIndex = 9;
            this.cmbrandom1.SelectedIndexChanged += new System.EventHandler(this.cmbrandom1_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(705, 370);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Count:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.cmbrandom1);
            this.Controls.Add(this.RdoGreaterthan50);
            this.Controls.Add(this.RdoLessthan50);
            this.Controls.Add(this.RdoGreaterthan500);
            this.Controls.Add(this.RdoLessthan500);
            this.Controls.Add(this.BtnReset1);
            this.Controls.Add(this.BtnGenerate1);
            this.Controls.Add(this.cmbRandom);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.Load += new System.EventHandler(this.FrmRandomCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.Button BtnGenerate1;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.RadioButton RdoLessthan500;
        private System.Windows.Forms.RadioButton RdoGreaterthan500;
        private System.Windows.Forms.RadioButton RdoLessthan50;
        private System.Windows.Forms.RadioButton RdoGreaterthan50;
        private System.Windows.Forms.ComboBox cmbrandom1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
    }
}