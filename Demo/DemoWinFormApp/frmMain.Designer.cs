namespace DemoWinFormApp
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
            this.licInfo = new QLicense.Windows.Controls.LicenseInfoControl();
            this.SuspendLayout();
            // 
            // licInfo
            // 
            this.licInfo.DateFormat = null;
            this.licInfo.DateTimeFormat = null;
            this.licInfo.Location = new System.Drawing.Point(14, 11);
            this.licInfo.Name = "licInfo";
            this.licInfo.Size = new System.Drawing.Size(350, 277);
            this.licInfo.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 305);
            this.Controls.Add(this.licInfo);
            this.Name = "frmMain";
            this.Text = "DemoWinFormApp";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private QLicense.Windows.Controls.LicenseInfoControl licInfo;
    }
}

