namespace My_first_GUI_App
{
    partial class frmImage
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
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.LoadFromSource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.Location = new System.Drawing.Point(69, 71);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(88, 42);
            this.BtnLoadImage.TabIndex = 0;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.UseVisualStyleBackColor = true;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(245, 50);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(250, 307);
            this.picTry.TabIndex = 1;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.picTry_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(362, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(517, 50);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(245, 307);
            this.picTry2.TabIndex = 3;
            this.picTry2.TabStop = false;
            // 
            // LoadFromSource
            // 
            this.LoadFromSource.Location = new System.Drawing.Point(38, 164);
            this.LoadFromSource.Name = "LoadFromSource";
            this.LoadFromSource.Size = new System.Drawing.Size(119, 77);
            this.LoadFromSource.TabIndex = 4;
            this.LoadFromSource.Text = "Load From Source";
            this.LoadFromSource.UseVisualStyleBackColor = true;
            this.LoadFromSource.Click += new System.EventHandler(this.LoadFromSource_Click);
            // 
            // frmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadFromSource);
            this.Controls.Add(this.picTry2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.picTry);
            this.Controls.Add(this.BtnLoadImage);
            this.Name = "frmImage";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.frmImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.Button LoadFromSource;
    }
}