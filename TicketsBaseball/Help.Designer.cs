namespace TicketsDeportivos
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.HelprichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HelprichTextBox
            // 
            this.HelprichTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelprichTextBox.Location = new System.Drawing.Point(12, 12);
            this.HelprichTextBox.Name = "HelprichTextBox";
            this.HelprichTextBox.ReadOnly = true;
            this.HelprichTextBox.Size = new System.Drawing.Size(260, 202);
            this.HelprichTextBox.TabIndex = 1;
            this.HelprichTextBox.Text = resources.GetString("HelprichTextBox.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 239);
            this.Controls.Add(this.HelprichTextBox);
            this.Name = "Help";
            this.Text = "Ayuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HelprichTextBox;
    }
}