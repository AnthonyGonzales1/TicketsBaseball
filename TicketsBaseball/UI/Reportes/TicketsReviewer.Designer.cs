namespace TicketsDeportivos.UI.Reportes
{
    partial class TicketsReviewer
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
            this.TicketsCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TicketsCrystalReportViewer
            // 
            this.TicketsCrystalReportViewer.ActiveViewIndex = -1;
            this.TicketsCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketsCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TicketsCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketsCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TicketsCrystalReportViewer.Name = "TicketsCrystalReportViewer";
            this.TicketsCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.TicketsCrystalReportViewer.TabIndex = 1;
            this.TicketsCrystalReportViewer.Load += new System.EventHandler(this.PartidoCrystalReportViewer_Load);
            // 
            // TicketsReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TicketsCrystalReportViewer);
            this.Name = "TicketsReviewer";
            this.Text = "TicketsReviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TicketsCrystalReportViewer;
    }
}