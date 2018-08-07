namespace TicketsDeportivos.UI.Reportes
{
    partial class VentasReciboReviewer
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
            this.VentasReciboCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VentasReciboCrystalReportViewer
            // 
            this.VentasReciboCrystalReportViewer.ActiveViewIndex = -1;
            this.VentasReciboCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VentasReciboCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VentasReciboCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentasReciboCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VentasReciboCrystalReportViewer.Name = "VentasReciboCrystalReportViewer";
            this.VentasReciboCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.VentasReciboCrystalReportViewer.TabIndex = 0;
            this.VentasReciboCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // VentasReciboReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VentasReciboCrystalReportViewer);
            this.Name = "VentasReciboReviewer";
            this.Text = "VentasReviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VentasReciboCrystalReportViewer;
    }
}