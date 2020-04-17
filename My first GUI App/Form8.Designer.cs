namespace My_first_GUI_App
{
    partial class frmclasses
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
            this.btncaroff = new System.Windows.Forms.Button();
            this.btnaccelerate = new System.Windows.Forms.Button();
            this.btncaron = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncaroff
            // 
            this.btncaroff.Location = new System.Drawing.Point(353, 149);
            this.btncaroff.Name = "btncaroff";
            this.btncaroff.Size = new System.Drawing.Size(75, 23);
            this.btncaroff.TabIndex = 0;
            this.btncaroff.Text = "car off";
            this.btncaroff.UseVisualStyleBackColor = true;
            // 
            // btnaccelerate
            // 
            this.btnaccelerate.Location = new System.Drawing.Point(492, 149);
            this.btnaccelerate.Name = "btnaccelerate";
            this.btnaccelerate.Size = new System.Drawing.Size(88, 23);
            this.btnaccelerate.TabIndex = 1;
            this.btnaccelerate.Text = "accelerate";
            this.btnaccelerate.UseVisualStyleBackColor = true;
            // 
            // btncaron
            // 
            this.btncaron.Location = new System.Drawing.Point(207, 149);
            this.btncaron.Name = "btncaron";
            this.btncaron.Size = new System.Drawing.Size(75, 23);
            this.btncaron.TabIndex = 2;
            this.btncaron.Text = "car on";
            this.btncaron.UseVisualStyleBackColor = true;
            // 
            // frmclasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncaron);
            this.Controls.Add(this.btnaccelerate);
            this.Controls.Add(this.btncaroff);
            this.Name = "frmclasses";
            this.Text = "classes";
            this.Load += new System.EventHandler(this.frmclasses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncaroff;
        private System.Windows.Forms.Button btnaccelerate;
        private System.Windows.Forms.Button btncaron;
    }
}