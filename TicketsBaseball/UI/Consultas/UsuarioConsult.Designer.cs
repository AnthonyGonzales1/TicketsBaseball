namespace TicketsDeportivos.UI.Consultas
{
    partial class UsuarioConsult
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
            this.UsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Imprimirbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimirbutton.Location = new System.Drawing.Point(545, 353);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 45);
            this.Imprimirbutton.TabIndex = 40;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(209, 36);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(212, 23);
            this.Titulolabel.TabIndex = 28;
            this.Titulolabel.Text = "Consulta de Usuarios";
            // 
            // UsuariodataGridView
            // 
            this.UsuariodataGridView.AllowUserToAddRows = false;
            this.UsuariodataGridView.AllowUserToDeleteRows = false;
            this.UsuariodataGridView.AllowUserToOrderColumns = true;
            this.UsuariodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariodataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.UsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariodataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.UsuariodataGridView.Location = new System.Drawing.Point(13, 121);
            this.UsuariodataGridView.Name = "UsuariodataGridView";
            this.UsuariodataGridView.ReadOnly = true;
            this.UsuariodataGridView.RowHeadersVisible = false;
            this.UsuariodataGridView.Size = new System.Drawing.Size(607, 213);
            this.UsuariodataGridView.TabIndex = 29;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadtextBox.Location = new System.Drawing.Point(196, 353);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.ReadOnly = true;
            this.CantidadtextBox.Size = new System.Drawing.Size(275, 20);
            this.CantidadtextBox.TabIndex = 30;
            this.CantidadtextBox.TextChanged += new System.EventHandler(this.CantidadtextBox_TextChanged);
            // 
            // Cantlabel
            // 
            this.Cantlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(10, 353);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(184, 14);
            this.Cantlabel.TabIndex = 31;
            this.Cantlabel.Text = "Cantidad actual de registros:";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriteriotextBox.Location = new System.Drawing.Point(211, 75);
            this.CriteriotextBox.MaxLength = 18;
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(332, 20);
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
            this.Filtrolabel.Location = new System.Drawing.Point(10, 77);
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
            "EventoId",
            "NombreEvento"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(60, 74);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(149, 21);
            this.FiltrocomboBox.TabIndex = 33;
            this.FiltrocomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrocomboBox_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Consultarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Consultarbutton.Location = new System.Drawing.Point(545, 54);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(79, 0);
            this.Consultarbutton.TabIndex = 35;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(549, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 49);
            this.button1.TabIndex = 41;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UsuarioConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.UsuariodataGridView);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.FiltrocomboBox);
            this.Name = "UsuarioConsult";
            this.Text = "Consulta de Usuarios";
            this.Load += new System.EventHandler(this.UsuarioConsult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.DataGridView UsuariodataGridView;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Consultarbutton;
    }
}