namespace My_first_GUI_App
{
    partial class FrmCombo
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
            this.BtnShowSelectedMethod1 = new System.Windows.Forms.Button();
            this.BtnShowSelectedMethod2 = new System.Windows.Forms.Button();
            this.BtnRemovelastitem = new System.Windows.Forms.Button();
            this.BtnRemove2ndlastitem = new System.Windows.Forms.Button();
            this.BtnRemovebyindex = new System.Windows.Forms.Button();
            this.BtnRemovebyname = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnDays = new System.Windows.Forms.Button();
            this.BtnShowSelectedMethod3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelectedMethod1
            // 
            this.BtnShowSelectedMethod1.Location = new System.Drawing.Point(57, 27);
            this.BtnShowSelectedMethod1.Name = "BtnShowSelectedMethod1";
            this.BtnShowSelectedMethod1.Size = new System.Drawing.Size(149, 53);
            this.BtnShowSelectedMethod1.TabIndex = 0;
            this.BtnShowSelectedMethod1.Text = "Show Selected Method1";
            this.BtnShowSelectedMethod1.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod1.Click += new System.EventHandler(this.BtnShowSelectedMethod1_Click);
            // 
            // BtnShowSelectedMethod2
            // 
            this.BtnShowSelectedMethod2.Location = new System.Drawing.Point(204, 27);
            this.BtnShowSelectedMethod2.Name = "BtnShowSelectedMethod2";
            this.BtnShowSelectedMethod2.Size = new System.Drawing.Size(144, 53);
            this.BtnShowSelectedMethod2.TabIndex = 1;
            this.BtnShowSelectedMethod2.Text = "Show Selected Method2";
            this.BtnShowSelectedMethod2.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod2.Click += new System.EventHandler(this.BtnShowSelectedMethod2_Click);
            // 
            // BtnRemovelastitem
            // 
            this.BtnRemovelastitem.Location = new System.Drawing.Point(678, 69);
            this.BtnRemovelastitem.Name = "BtnRemovelastitem";
            this.BtnRemovelastitem.Size = new System.Drawing.Size(110, 76);
            this.BtnRemovelastitem.TabIndex = 2;
            this.BtnRemovelastitem.Text = "Remove last item";
            this.BtnRemovelastitem.UseVisualStyleBackColor = true;
            this.BtnRemovelastitem.Click += new System.EventHandler(this.BtnRemovelastitem_Click);
            // 
            // BtnRemove2ndlastitem
            // 
            this.BtnRemove2ndlastitem.Location = new System.Drawing.Point(678, 161);
            this.BtnRemove2ndlastitem.Name = "BtnRemove2ndlastitem";
            this.BtnRemove2ndlastitem.Size = new System.Drawing.Size(110, 80);
            this.BtnRemove2ndlastitem.TabIndex = 3;
            this.BtnRemove2ndlastitem.Text = "Remove 2nd last item";
            this.BtnRemove2ndlastitem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndlastitem.Click += new System.EventHandler(this.BtnRemove2ndlastitem_Click);
            // 
            // BtnRemovebyindex
            // 
            this.BtnRemovebyindex.Location = new System.Drawing.Point(57, 346);
            this.BtnRemovebyindex.Name = "BtnRemovebyindex";
            this.BtnRemovebyindex.Size = new System.Drawing.Size(134, 51);
            this.BtnRemovebyindex.TabIndex = 4;
            this.BtnRemovebyindex.Text = "Remove by index";
            this.BtnRemovebyindex.UseVisualStyleBackColor = true;
            this.BtnRemovebyindex.Click += new System.EventHandler(this.BtnRemovebyindex_Click);
            // 
            // BtnRemovebyname
            // 
            this.BtnRemovebyname.Location = new System.Drawing.Point(236, 346);
            this.BtnRemovebyname.Name = "BtnRemovebyname";
            this.BtnRemovebyname.Size = new System.Drawing.Size(142, 50);
            this.BtnRemovebyname.TabIndex = 5;
            this.BtnRemovebyname.Text = "Remove by name";
            this.BtnRemovebyname.UseVisualStyleBackColor = true;
            this.BtnRemovebyname.Click += new System.EventHandler(this.BtnRemovebyname_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(646, 415);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(108, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(157, 121);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(154, 24);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // BtnDays
            // 
            this.BtnDays.Location = new System.Drawing.Point(57, 121);
            this.BtnDays.Name = "BtnDays";
            this.BtnDays.Size = new System.Drawing.Size(75, 23);
            this.BtnDays.TabIndex = 8;
            this.BtnDays.Text = "Days";
            this.BtnDays.UseVisualStyleBackColor = true;
            // 
            // BtnShowSelectedMethod3
            // 
            this.BtnShowSelectedMethod3.Location = new System.Drawing.Point(393, 27);
            this.BtnShowSelectedMethod3.Name = "BtnShowSelectedMethod3";
            this.BtnShowSelectedMethod3.Size = new System.Drawing.Size(133, 53);
            this.BtnShowSelectedMethod3.TabIndex = 9;
            this.BtnShowSelectedMethod3.Text = "Show Selected Method3";
            this.BtnShowSelectedMethod3.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod3.Click += new System.EventHandler(this.BtnShowSelectedMethod3_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShowSelectedMethod3);
            this.Controls.Add(this.BtnDays);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemovebyname);
            this.Controls.Add(this.BtnRemovebyindex);
            this.Controls.Add(this.BtnRemove2ndlastitem);
            this.Controls.Add(this.BtnRemovelastitem);
            this.Controls.Add(this.BtnShowSelectedMethod2);
            this.Controls.Add(this.BtnShowSelectedMethod1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelectedMethod1;
        private System.Windows.Forms.Button BtnShowSelectedMethod2;
        private System.Windows.Forms.Button BtnRemovelastitem;
        private System.Windows.Forms.Button BtnRemove2ndlastitem;
        private System.Windows.Forms.Button BtnRemovebyindex;
        private System.Windows.Forms.Button BtnRemovebyname;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnDays;
        private System.Windows.Forms.Button BtnShowSelectedMethod3;
    }
}