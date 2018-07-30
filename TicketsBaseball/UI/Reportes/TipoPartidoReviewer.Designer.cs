namespace TicketsDeportivos.UI.Reportes
{
    partial class TipoPartidoReviewer
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
            this.TipoPartidoCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TipoPartidoCrystalReportViewer
            // 
            this.TipoPartidoCrystalReportViewer.ActiveViewIndex = -1;
            this.TipoPartidoCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipoPartidoCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TipoPartidoCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoPartidoCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TipoPartidoCrystalReportViewer.Name = "TipoPartidoCrystalReportViewer";
            this.TipoPartidoCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.TipoPartidoCrystalReportViewer.TabIndex = 0;
            this.TipoPartidoCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // TipoPartidoReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipoPartidoCrystalReportViewer);
            this.Name = "TipoPartidoReviewer";
            this.Text = "TipoPartidoReviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TipoPartidoCrystalReportViewer;
    }
}