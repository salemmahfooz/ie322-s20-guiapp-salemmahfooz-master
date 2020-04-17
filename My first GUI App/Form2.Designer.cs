namespace My_first_GUI_App
{
    partial class frmRadio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoYellow = new System.Windows.Forms.RadioButton();
            this.RdoBlue = new System.Windows.Forms.RadioButton();
            this.RdoGreen = new System.Windows.Forms.RadioButton();
            this.RdoRed = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.RdoRed1 = new System.Windows.Forms.RadioButton();
            this.RdoGreen1 = new System.Windows.Forms.RadioButton();
            this.RdoBlue1 = new System.Windows.Forms.RadioButton();
            this.RdoYellow1 = new System.Windows.Forms.RadioButton();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoYellow);
            this.groupBox1.Controls.Add(this.RdoBlue);
            this.groupBox1.Controls.Add(this.RdoGreen);
            this.groupBox1.Controls.Add(this.RdoRed);
            this.groupBox1.Location = new System.Drawing.Point(367, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            // 
            // RdoYellow
            // 
            this.RdoYellow.AutoSize = true;
            this.RdoYellow.Location = new System.Drawing.Point(32, 105);
            this.RdoYellow.Name = "RdoYellow";
            this.RdoYellow.Size = new System.Drawing.Size(69, 21);
            this.RdoYellow.TabIndex = 3;
            this.RdoYellow.TabStop = true;
            this.RdoYellow.Text = "Yellow";
            this.RdoYellow.UseVisualStyleBackColor = true;
            this.RdoYellow.CheckedChanged += new System.EventHandler(this.RdoYellow_CheckedChanged);
            // 
            // RdoBlue
            // 
            this.RdoBlue.AutoSize = true;
            this.RdoBlue.Location = new System.Drawing.Point(32, 78);
            this.RdoBlue.Name = "RdoBlue";
            this.RdoBlue.Size = new System.Drawing.Size(57, 21);
            this.RdoBlue.TabIndex = 2;
            this.RdoBlue.TabStop = true;
            this.RdoBlue.Text = "Blue";
            this.RdoBlue.UseVisualStyleBackColor = true;
            this.RdoBlue.CheckedChanged += new System.EventHandler(this.RdoBlue_CheckedChanged);
            // 
            // RdoGreen
            // 
            this.RdoGreen.AutoSize = true;
            this.RdoGreen.Location = new System.Drawing.Point(32, 49);
            this.RdoGreen.Name = "RdoGreen";
            this.RdoGreen.Size = new System.Drawing.Size(69, 21);
            this.RdoGreen.TabIndex = 1;
            this.RdoGreen.TabStop = true;
            this.RdoGreen.Text = "Green";
            this.RdoGreen.UseVisualStyleBackColor = true;
            this.RdoGreen.CheckedChanged += new System.EventHandler(this.RdoGreen_CheckedChanged);
            // 
            // RdoRed
            // 
            this.RdoRed.AutoSize = true;
            this.RdoRed.Location = new System.Drawing.Point(32, 22);
            this.RdoRed.Name = "RdoRed";
            this.RdoRed.Size = new System.Drawing.Size(55, 21);
            this.RdoRed.TabIndex = 0;
            this.RdoRed.TabStop = true;
            this.RdoRed.Text = "Red";
            this.RdoRed.UseVisualStyleBackColor = true;
            this.RdoRed.CheckedChanged += new System.EventHandler(this.RdoRed_CheckedChanged);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(335, 43);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // RdoRed1
            // 
            this.RdoRed1.AutoSize = true;
            this.RdoRed1.Location = new System.Drawing.Point(160, 142);
            this.RdoRed1.Name = "RdoRed1";
            this.RdoRed1.Size = new System.Drawing.Size(63, 21);
            this.RdoRed1.TabIndex = 3;
            this.RdoRed1.TabStop = true;
            this.RdoRed1.Text = "Red1";
            this.RdoRed1.UseVisualStyleBackColor = true;
            this.RdoRed1.CheckedChanged += new System.EventHandler(this.RdoRed1_CheckedChanged);
            // 
            // RdoGreen1
            // 
            this.RdoGreen1.AutoSize = true;
            this.RdoGreen1.Location = new System.Drawing.Point(160, 169);
            this.RdoGreen1.Name = "RdoGreen1";
            this.RdoGreen1.Size = new System.Drawing.Size(77, 21);
            this.RdoGreen1.TabIndex = 4;
            this.RdoGreen1.TabStop = true;
            this.RdoGreen1.Text = "Green1";
            this.RdoGreen1.UseVisualStyleBackColor = true;
            this.RdoGreen1.CheckedChanged += new System.EventHandler(this.RdoGreen1_CheckedChanged);
            // 
            // RdoBlue1
            // 
            this.RdoBlue1.AutoSize = true;
            this.RdoBlue1.Location = new System.Drawing.Point(160, 198);
            this.RdoBlue1.Name = "RdoBlue1";
            this.RdoBlue1.Size = new System.Drawing.Size(65, 21);
            this.RdoBlue1.TabIndex = 5;
            this.RdoBlue1.TabStop = true;
            this.RdoBlue1.Text = "Blue1";
            this.RdoBlue1.UseVisualStyleBackColor = true;
            this.RdoBlue1.CheckedChanged += new System.EventHandler(this.RdoBlue1_CheckedChanged);
            // 
            // RdoYellow1
            // 
            this.RdoYellow1.AutoSize = true;
            this.RdoYellow1.Location = new System.Drawing.Point(160, 225);
            this.RdoYellow1.Name = "RdoYellow1";
            this.RdoYellow1.Size = new System.Drawing.Size(77, 21);
            this.RdoYellow1.TabIndex = 6;
            this.RdoYellow1.TabStop = true;
            this.RdoYellow1.Text = "Yellow1";
            this.RdoYellow1.UseVisualStyleBackColor = true;
            this.RdoYellow1.CheckedChanged += new System.EventHandler(this.RdoYellow1_CheckedChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(696, 400);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.RdoYellow1);
            this.Controls.Add(this.RdoBlue1);
            this.Controls.Add(this.RdoGreen1);
            this.Controls.Add(this.RdoRed1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRadio";
            this.Text = "Radio Form";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoYellow;
        private System.Windows.Forms.RadioButton RdoBlue;
        private System.Windows.Forms.RadioButton RdoGreen;
        private System.Windows.Forms.RadioButton RdoRed;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.RadioButton RdoRed1;
        private System.Windows.Forms.RadioButton RdoGreen1;
        private System.Windows.Forms.RadioButton RdoBlue1;
        private System.Windows.Forms.RadioButton RdoYellow1;
        private System.Windows.Forms.Button BtnBack;
    }
}