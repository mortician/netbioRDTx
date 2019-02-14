namespace netbioRDTx
{
    partial class Frm_Dlg_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dlg_About));
            this.PIC_LOGO = new System.Windows.Forms.PictureBox();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.LBL_VERSION = new System.Windows.Forms.Label();
            this.LBL_AUTHOR = new System.Windows.Forms.Label();
            this.LBL_INFO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // PIC_LOGO
            // 
            this.PIC_LOGO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PIC_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("PIC_LOGO.Image")));
            this.PIC_LOGO.Location = new System.Drawing.Point(4, 3);
            this.PIC_LOGO.Name = "PIC_LOGO";
            this.PIC_LOGO.Size = new System.Drawing.Size(378, 176);
            this.PIC_LOGO.TabIndex = 0;
            this.PIC_LOGO.TabStop = false;
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.Location = new System.Drawing.Point(4, 258);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(378, 32);
            this.BTN_CLOSE.TabIndex = 1;
            this.BTN_CLOSE.Text = "Close";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // LBL_VERSION
            // 
            this.LBL_VERSION.AutoSize = true;
            this.LBL_VERSION.BackColor = System.Drawing.Color.Black;
            this.LBL_VERSION.ForeColor = System.Drawing.Color.White;
            this.LBL_VERSION.Location = new System.Drawing.Point(12, 157);
            this.LBL_VERSION.Name = "LBL_VERSION";
            this.LBL_VERSION.Size = new System.Drawing.Size(35, 14);
            this.LBL_VERSION.TabIndex = 2;
            this.LBL_VERSION.Text = "0.01";
            // 
            // LBL_AUTHOR
            // 
            this.LBL_AUTHOR.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_AUTHOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBL_AUTHOR.ForeColor = System.Drawing.Color.Black;
            this.LBL_AUTHOR.Location = new System.Drawing.Point(4, 182);
            this.LBL_AUTHOR.Name = "LBL_AUTHOR";
            this.LBL_AUTHOR.Size = new System.Drawing.Size(378, 19);
            this.LBL_AUTHOR.TabIndex = 3;
            this.LBL_AUTHOR.Text = "© 2014, mortician - the_mortician@hotmail.com";
            this.LBL_AUTHOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_INFO
            // 
            this.LBL_INFO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBL_INFO.Location = new System.Drawing.Point(4, 205);
            this.LBL_INFO.Name = "LBL_INFO";
            this.LBL_INFO.Size = new System.Drawing.Size(378, 50);
            this.LBL_INFO.TabIndex = 4;
            this.LBL_INFO.Text = "This is an extractor and at the same time a repacker for the BIOHAZARD / RESIDENT" +
    " EVIL Outbreak games. ";
            this.LBL_INFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Dlg_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 293);
            this.Controls.Add(this.LBL_INFO);
            this.Controls.Add(this.LBL_AUTHOR);
            this.Controls.Add(this.LBL_VERSION);
            this.Controls.Add(this.BTN_CLOSE);
            this.Controls.Add(this.PIC_LOGO);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Dlg_About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About...";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Frm_Dlg_About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC_LOGO;
        private System.Windows.Forms.Button BTN_CLOSE;
        private System.Windows.Forms.Label LBL_VERSION;
        private System.Windows.Forms.Label LBL_AUTHOR;
        private System.Windows.Forms.Label LBL_INFO;
    }
}