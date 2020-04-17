namespace My_first_GUI_App
{
    partial class frmMain
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txtuser = new System.Windows.Forms.TextBox();
            this.LblPW = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.BtnPictureBox2 = new System.Windows.Forms.Button();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnManufacturingCell = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnABCAnalysis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Red;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(30, 196);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(90, 47);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(177, 196);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(97, 46);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txtuser);
            this.groupBox1.Controls.Add(this.LblPW);
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Location = new System.Drawing.Point(30, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // Txtuser
            // 
            this.Txtuser.Location = new System.Drawing.Point(112, 34);
            this.Txtuser.Name = "Txtuser";
            this.Txtuser.Size = new System.Drawing.Size(100, 22);
            this.Txtuser.TabIndex = 2;
            this.Txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblPW
            // 
            this.LblPW.AutoSize = true;
            this.LblPW.Location = new System.Drawing.Point(6, 78);
            this.LblPW.Name = "LblPW";
            this.LblPW.Size = new System.Drawing.Size(69, 17);
            this.LblPW.TabIndex = 1;
            this.LblPW.Text = "Password";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(7, 34);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(73, 17);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Username";
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(142, 131);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(100, 22);
            this.TxtPW.TabIndex = 3;
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.Color.Red;
            this.BtnRadio.ForeColor = System.Drawing.Color.White;
            this.BtnRadio.Location = new System.Drawing.Point(343, 73);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(96, 31);
            this.BtnRadio.TabIndex = 4;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.BackColor = System.Drawing.Color.Red;
            this.BtnCheckBox.ForeColor = System.Drawing.Color.White;
            this.BtnCheckBox.Location = new System.Drawing.Point(343, 111);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(96, 31);
            this.BtnCheckBox.TabIndex = 5;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseVisualStyleBackColor = false;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.Color.Red;
            this.BtnCombo.ForeColor = System.Drawing.Color.White;
            this.BtnCombo.Location = new System.Drawing.Point(343, 149);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(96, 33);
            this.BtnCombo.TabIndex = 6;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.BackColor = System.Drawing.Color.Red;
            this.BtnPictureBox.ForeColor = System.Drawing.Color.White;
            this.BtnPictureBox.Location = new System.Drawing.Point(460, 73);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(107, 31);
            this.BtnPictureBox.TabIndex = 7;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseVisualStyleBackColor = false;
            this.BtnPictureBox.Click += new System.EventHandler(this.BtnPictureBox_Click);
            // 
            // BtnPictureBox2
            // 
            this.BtnPictureBox2.BackColor = System.Drawing.Color.Red;
            this.BtnPictureBox2.ForeColor = System.Drawing.Color.White;
            this.BtnPictureBox2.Location = new System.Drawing.Point(460, 110);
            this.BtnPictureBox2.Name = "BtnPictureBox2";
            this.BtnPictureBox2.Size = new System.Drawing.Size(107, 31);
            this.BtnPictureBox2.TabIndex = 8;
            this.BtnPictureBox2.Text = "PictureBox2";
            this.BtnPictureBox2.UseVisualStyleBackColor = false;
            this.BtnPictureBox2.Click += new System.EventHandler(this.BtnPictureBox2_Click);
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.BackColor = System.Drawing.Color.Red;
            this.BtnSelfieApp.ForeColor = System.Drawing.Color.White;
            this.BtnSelfieApp.Location = new System.Drawing.Point(460, 149);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(107, 33);
            this.BtnSelfieApp.TabIndex = 9;
            this.BtnSelfieApp.Text = "SelfieApp";
            this.BtnSelfieApp.UseVisualStyleBackColor = false;
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.BackColor = System.Drawing.Color.Red;
            this.BtnGroupieApp.ForeColor = System.Drawing.Color.White;
            this.BtnGroupieApp.Location = new System.Drawing.Point(585, 73);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(111, 31);
            this.BtnGroupieApp.TabIndex = 10;
            this.BtnGroupieApp.Text = "GroupieApp";
            this.BtnGroupieApp.UseVisualStyleBackColor = false;
            // 
            // BtnProgress
            // 
            this.BtnProgress.BackColor = System.Drawing.Color.Red;
            this.BtnProgress.ForeColor = System.Drawing.Color.White;
            this.BtnProgress.Location = new System.Drawing.Point(585, 111);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(111, 31);
            this.BtnProgress.TabIndex = 11;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = false;
            this.BtnProgress.Click += new System.EventHandler(this.BtnProgress_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.Color.Red;
            this.BtnTimer.ForeColor = System.Drawing.Color.White;
            this.BtnTimer.Location = new System.Drawing.Point(585, 149);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(111, 33);
            this.BtnTimer.TabIndex = 12;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = false;
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.Red;
            this.BtnRandom.ForeColor = System.Drawing.Color.White;
            this.BtnRandom.Location = new System.Drawing.Point(716, 73);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(113, 31);
            this.BtnRandom.TabIndex = 13;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.BackColor = System.Drawing.Color.Red;
            this.BtnRandomCombo.ForeColor = System.Drawing.Color.White;
            this.BtnRandomCombo.Location = new System.Drawing.Point(716, 110);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(113, 32);
            this.BtnRandomCombo.TabIndex = 14;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseVisualStyleBackColor = false;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.Color.Red;
            this.BtnDraw.ForeColor = System.Drawing.Color.White;
            this.BtnDraw.Location = new System.Drawing.Point(716, 149);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(113, 33);
            this.BtnDraw.TabIndex = 15;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = false;
            // 
            // BtnTalk
            // 
            this.BtnTalk.BackColor = System.Drawing.Color.Red;
            this.BtnTalk.ForeColor = System.Drawing.Color.White;
            this.BtnTalk.Location = new System.Drawing.Point(851, 73);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(137, 31);
            this.BtnTalk.TabIndex = 16;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = false;
            // 
            // BtnManufacturingCell
            // 
            this.BtnManufacturingCell.BackColor = System.Drawing.Color.Red;
            this.BtnManufacturingCell.ForeColor = System.Drawing.Color.White;
            this.BtnManufacturingCell.Location = new System.Drawing.Point(851, 110);
            this.BtnManufacturingCell.Name = "BtnManufacturingCell";
            this.BtnManufacturingCell.Size = new System.Drawing.Size(137, 32);
            this.BtnManufacturingCell.TabIndex = 17;
            this.BtnManufacturingCell.Text = "ManufacturingCell";
            this.BtnManufacturingCell.UseVisualStyleBackColor = false;
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.BackColor = System.Drawing.Color.Red;
            this.BtnRoboticCell.ForeColor = System.Drawing.Color.White;
            this.BtnRoboticCell.Location = new System.Drawing.Point(851, 149);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(137, 33);
            this.BtnRoboticCell.TabIndex = 18;
            this.BtnRoboticCell.Text = "RoboticCell";
            this.BtnRoboticCell.UseVisualStyleBackColor = false;
            // 
            // BtnArduino
            // 
            this.BtnArduino.BackColor = System.Drawing.Color.Red;
            this.BtnArduino.ForeColor = System.Drawing.Color.White;
            this.BtnArduino.Location = new System.Drawing.Point(1031, 73);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(102, 31);
            this.BtnArduino.TabIndex = 19;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = false;
            // 
            // BtnJohari
            // 
            this.BtnJohari.BackColor = System.Drawing.Color.Red;
            this.BtnJohari.ForeColor = System.Drawing.Color.White;
            this.BtnJohari.Location = new System.Drawing.Point(1031, 110);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(102, 31);
            this.BtnJohari.TabIndex = 20;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = false;
            // 
            // BtnABCAnalysis
            // 
            this.BtnABCAnalysis.BackColor = System.Drawing.Color.Red;
            this.BtnABCAnalysis.ForeColor = System.Drawing.Color.White;
            this.BtnABCAnalysis.Location = new System.Drawing.Point(1031, 149);
            this.BtnABCAnalysis.Name = "BtnABCAnalysis";
            this.BtnABCAnalysis.Size = new System.Drawing.Size(102, 33);
            this.BtnABCAnalysis.TabIndex = 21;
            this.BtnABCAnalysis.Text = "ABCAnalysis";
            this.BtnABCAnalysis.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.BtnABCAnalysis);
            this.Controls.Add(this.BtnJohari);
            this.Controls.Add(this.BtnArduino);
            this.Controls.Add(this.BtnRoboticCell);
            this.Controls.Add(this.BtnManufacturingCell);
            this.Controls.Add(this.BtnTalk);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.BtnRandomCombo);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnTimer);
            this.Controls.Add(this.BtnProgress);
            this.Controls.Add(this.BtnGroupieApp);
            this.Controls.Add(this.BtnSelfieApp);
            this.Controls.Add(this.BtnPictureBox2);
            this.Controls.Add(this.BtnPictureBox);
            this.Controls.Add(this.BtnCombo);
            this.Controls.Add(this.BtnCheckBox);
            this.Controls.Add(this.BtnRadio);
            this.Controls.Add(this.TxtPW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox Txtuser;
        private System.Windows.Forms.Label LblPW;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.Button BtnPictureBox2;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnManufacturingCell;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnABCAnalysis;
    }
}

