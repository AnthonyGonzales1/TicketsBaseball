namespace TicketsDeportivos.UI.Reportes
{
    partial class PartidoReviewer
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
            this.PartidoCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PartidoCrystalReportViewer
            // 
            this.PartidoCrystalReportViewer.ActiveViewIndex = -1;
            this.PartidoCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartidoCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PartidoCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartidoCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PartidoCrystalReportViewer.Name = "PartidoCrystalReportViewer";
            this.PartidoCrystalReportViewer.Size = new System.Drawing.Size(712, 450);
            this.PartidoCrystalReportViewer.TabIndex = 0;
            this.PartidoCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // PartidoReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.PartidoCrystalReportViewer);
            this.Name = "PartidoReviewer";
            this.Text = "PartidoReviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PartidoCrystalReportViewer;
    }
}