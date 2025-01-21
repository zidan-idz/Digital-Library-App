namespace Digital_Library_Management
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new Digital_Library_Management.CrystalReport1();
            this.keluar = new System.Windows.Forms.Button();
            this.CrystalReport12 = new Digital_Library_Management.CrystalReport1();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "C:\\Users\\MyBook Hype AMD\\source\\repos\\Digital-Library-Management\\Digital-Library-" +
    "Management\\bin\\Debug\\CrystalReport1.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1262, 673);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // keluar
            // 
            this.keluar.BackColor = System.Drawing.Color.Maroon;
            this.keluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.keluar.Location = new System.Drawing.Point(92, 601);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(100, 34);
            this.keluar.TabIndex = 5;
            this.keluar.Text = "Keluar >";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.Button keluar;
        private CrystalReport1 CrystalReport12;
    }
}