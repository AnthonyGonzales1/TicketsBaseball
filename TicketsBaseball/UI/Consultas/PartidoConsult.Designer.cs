namespace TicketsDeportivos.UI.Consultas
{
    partial class PartidoConsult
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.PartidodataGridView = new System.Windows.Forms.DataGridView();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.CanttextBox = new System.Windows.Forms.TextBox();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PartidodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Imprimirbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimirbutton.Location = new System.Drawing.Point(549, 345);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 45);
            this.Imprimirbutton.TabIndex = 40;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 39;
            this.label2.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 38;
            this.label1.Text = "Hasta:";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Enabled = false;
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(338, 64);
            this.HastadateTimePicker.MaxDate = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            this.HastadateTimePicker.MinDate = new System.DateTime(2016, 2, 4, 0, 0, 0, 0);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.HastadateTimePicker.TabIndex = 37;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Enabled = false;
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(139, 64);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.DesdedateTimePicker.TabIndex = 36;
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(210, 11);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(208, 23);
            this.Titulolabel.TabIndex = 28;
            this.Titulolabel.Text = "Consulta de Partidos";
            // 
            // PartidodataGridView
            // 
            this.PartidodataGridView.AllowUserToAddRows = false;
            this.PartidodataGridView.AllowUserToDeleteRows = false;
            this.PartidodataGridView.AllowUserToOrderColumns = true;
            this.PartidodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartidodataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.PartidodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartidodataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.PartidodataGridView.Location = new System.Drawing.Point(14, 126);
            this.PartidodataGridView.Name = "PartidodataGridView";
            this.PartidodataGridView.ReadOnly = true;
            this.PartidodataGridView.RowHeadersVisible = false;
            this.PartidodataGridView.Size = new System.Drawing.Size(610, 213);
            this.PartidodataGridView.TabIndex = 29;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Consultarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Consultarbutton.Location = new System.Drawing.Point(549, 64);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(75, 45);
            this.Consultarbutton.TabIndex = 35;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriteriotextBox.Location = new System.Drawing.Point(215, 90);
            this.CriteriotextBox.MaxLength = 18;
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(328, 20);
            this.CriteriotextBox.TabIndex = 34;
            this.CriteriotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CriteriotextBox_KeyPress);
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrolabel.Location = new System.Drawing.Point(14, 92);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(42, 14);
            this.Filtrolabel.TabIndex = 32;
            this.Filtrolabel.Text = "Filtro:";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "PartidoId",
            "NombrePartido"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(64, 89);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(145, 21);
            this.FiltrocomboBox.TabIndex = 33;
            this.FiltrocomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrocomboBox_SelectedIndexChanged);
            // 
            // CanttextBox
            // 
            this.CanttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanttextBox.Location = new System.Drawing.Point(197, 355);
            this.CanttextBox.Name = "CanttextBox";
            this.CanttextBox.ReadOnly = true;
            this.CanttextBox.Size = new System.Drawing.Size(271, 20);
            this.CanttextBox.TabIndex = 30;
            this.CanttextBox.TextChanged += new System.EventHandler(this.CanttextBox_TextChanged);
            // 
            // Cantlabel
            // 
            this.Cantlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(11, 355);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(184, 14);
            this.Cantlabel.TabIndex = 31;
            this.Cantlabel.Text = "Cantidad actual de registros:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Checked = true;
            this.FechacheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FechacheckBox.Location = new System.Drawing.Point(92, 41);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(107, 17);
            this.FechacheckBox.TabIndex = 41;
            this.FechacheckBox.Text = "Buscar por fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            // 
            // PartidoConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 400);
            this.Controls.Add(this.FechacheckBox);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.PartidodataGridView);
            this.Controls.Add(this.CanttextBox);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.FiltrocomboBox);
            this.Name = "PartidoConsult";
            this.Text = "PartidoConsult";
            ((System.ComponentModel.ISupportInitialize)(this.PartidodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.DataGridView PartidodataGridView;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox CanttextBox;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox FechacheckBox;
    }
}