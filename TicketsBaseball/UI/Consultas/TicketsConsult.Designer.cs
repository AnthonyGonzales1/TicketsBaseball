namespace TicketsDeportivos.UI.Consultas
{
    partial class TicketsConsult
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
            this.components = new System.ComponentModel.Container();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.TicketsdataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Imprimirbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimirbutton.Location = new System.Drawing.Point(424, 273);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 46);
            this.Imprimirbutton.TabIndex = 45;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.BackColor = System.Drawing.Color.Transparent;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(132, 16);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(197, 23);
            this.Titulolabel.TabIndex = 44;
            this.Titulolabel.Text = "Consulta de Tickets";
            // 
            // Cantlabel
            // 
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.BackColor = System.Drawing.Color.Transparent;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(12, 296);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(188, 14);
            this.Cantlabel.TabIndex = 37;
            this.Cantlabel.Text = "Cantidad actual de registros: ";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(206, 296);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.ReadOnly = true;
            this.CantidadtextBox.Size = new System.Drawing.Size(212, 20);
            this.CantidadtextBox.TabIndex = 38;
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.BackColor = System.Drawing.Color.Transparent;
            this.Filtrolabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrolabel.Location = new System.Drawing.Point(12, 65);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(42, 14);
            this.Filtrolabel.TabIndex = 39;
            this.Filtrolabel.Text = "Filtro:";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Tickets",
            "Descripcion",
            "Precio"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(62, 63);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 40;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(189, 63);
            this.CriteriotextBox.MaxLength = 14;
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(229, 20);
            this.CriteriotextBox.TabIndex = 42;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Consultarbutton.Location = new System.Drawing.Point(424, 63);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(75, 41);
            this.Consultarbutton.TabIndex = 43;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // TicketsdataGridView
            // 
            this.TicketsdataGridView.AllowUserToAddRows = false;
            this.TicketsdataGridView.AllowUserToDeleteRows = false;
            this.TicketsdataGridView.AllowUserToOrderColumns = true;
            this.TicketsdataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TicketsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsdataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TicketsdataGridView.Location = new System.Drawing.Point(15, 110);
            this.TicketsdataGridView.Name = "TicketsdataGridView";
            this.TicketsdataGridView.ReadOnly = true;
            this.TicketsdataGridView.RowHeadersVisible = false;
            this.TicketsdataGridView.Size = new System.Drawing.Size(484, 157);
            this.TicketsdataGridView.TabIndex = 41;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TicketsConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketsDeportivos.Properties.Resources._1378144182;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 333);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.TicketsdataGridView);
            this.Name = "TicketsConsult";
            this.Text = "TicketsConsult";
            ((System.ComponentModel.ISupportInitialize)(this.TicketsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.DataGridView TicketsdataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}