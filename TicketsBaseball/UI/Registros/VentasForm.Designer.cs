namespace TicketsDeportivos.UI.Registros
{
    partial class VentasForm
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
            this.Titulolabel = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Ticketlabel = new System.Windows.Forms.Label();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.VendidoPorlabel = new System.Windows.Forms.Label();
            this.Eventolabel = new System.Windows.Forms.Label();
            this.VentaIdlabel = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UsuarioscomboBox = new System.Windows.Forms.ComboBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.TicketcomboBox = new System.Windows.Forms.ComboBox();
            this.PartidocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(193, 23);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(191, 23);
            this.Titulolabel.TabIndex = 35;
            this.Titulolabel.Text = "Registro de Ventas";
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.Location = new System.Drawing.Point(15, 277);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(42, 14);
            this.Totallabel.TabIndex = 34;
            this.Totallabel.Text = "Total:";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(309, 169);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(75, 13);
            this.Descripcionlabel.TabIndex = 33;
            this.Descripcionlabel.Text = "Descripcion:";
            // 
            // Ticketlabel
            // 
            this.Ticketlabel.AutoSize = true;
            this.Ticketlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticketlabel.Location = new System.Drawing.Point(339, 76);
            this.Ticketlabel.Name = "Ticketlabel";
            this.Ticketlabel.Size = new System.Drawing.Size(45, 13);
            this.Ticketlabel.TabIndex = 32;
            this.Ticketlabel.Text = "Ticket:";
            // 
            // Cantlabel
            // 
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(324, 120);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(60, 13);
            this.Cantlabel.TabIndex = 31;
            this.Cantlabel.Text = "Cantidad:";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.Location = new System.Drawing.Point(51, 229);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(43, 13);
            this.Fechalabel.TabIndex = 36;
            this.Fechalabel.Text = "Fecha:";
            // 
            // VendidoPorlabel
            // 
            this.VendidoPorlabel.AutoSize = true;
            this.VendidoPorlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendidoPorlabel.Location = new System.Drawing.Point(17, 186);
            this.VendidoPorlabel.Name = "VendidoPorlabel";
            this.VendidoPorlabel.Size = new System.Drawing.Size(77, 13);
            this.VendidoPorlabel.TabIndex = 29;
            this.VendidoPorlabel.Text = "Vendido Por:";
            // 
            // Eventolabel
            // 
            this.Eventolabel.AutoSize = true;
            this.Eventolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eventolabel.Location = new System.Drawing.Point(45, 139);
            this.Eventolabel.Name = "Eventolabel";
            this.Eventolabel.Size = new System.Drawing.Size(49, 13);
            this.Eventolabel.TabIndex = 28;
            this.Eventolabel.Text = "Evento:";
            // 
            // VentaIdlabel
            // 
            this.VentaIdlabel.AutoSize = true;
            this.VentaIdlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentaIdlabel.Location = new System.Drawing.Point(36, 81);
            this.VentaIdlabel.Name = "VentaIdlabel";
            this.VentaIdlabel.Size = new System.Drawing.Size(58, 13);
            this.VentaIdlabel.TabIndex = 27;
            this.VentaIdlabel.Text = "Venta Id:";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Imprimirbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimirbutton.Location = new System.Drawing.Point(497, 310);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 46);
            this.Imprimirbutton.TabIndex = 46;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click_1);
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(387, 166);
            this.DescripcionrichTextBox.MaxLength = 59;
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(184, 84);
            this.DescripcionrichTextBox.TabIndex = 42;
            this.DescripcionrichTextBox.Text = "";
            this.DescripcionrichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionrichTextBox_KeyPress);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(96, 229);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.FechadateTimePicker.TabIndex = 39;
            // 
            // UsuarioscomboBox
            // 
            this.UsuarioscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuarioscomboBox.FormattingEnabled = true;
            this.UsuarioscomboBox.Location = new System.Drawing.Point(96, 183);
            this.UsuarioscomboBox.Name = "UsuarioscomboBox";
            this.UsuarioscomboBox.Size = new System.Drawing.Size(172, 21);
            this.UsuarioscomboBox.TabIndex = 38;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(63, 274);
            this.TotaltextBox.MaxLength = 12;
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(227, 20);
            this.TotaltextBox.TabIndex = 44;
            this.TotaltextBox.TextChanged += new System.EventHandler(this.TotaltextBox_TextChanged);
            // 
            // TicketcomboBox
            // 
            this.TicketcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketcomboBox.FormattingEnabled = true;
            this.TicketcomboBox.Location = new System.Drawing.Point(390, 73);
            this.TicketcomboBox.Name = "TicketcomboBox";
            this.TicketcomboBox.Size = new System.Drawing.Size(116, 21);
            this.TicketcomboBox.TabIndex = 40;
            // 
            // PartidocomboBox
            // 
            this.PartidocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartidocomboBox.FormattingEnabled = true;
            this.PartidocomboBox.Location = new System.Drawing.Point(96, 136);
            this.PartidocomboBox.Name = "PartidocomboBox";
            this.PartidocomboBox.Size = new System.Drawing.Size(172, 21);
            this.PartidocomboBox.TabIndex = 37;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Buscarbutton.Location = new System.Drawing.Point(206, 74);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 45);
            this.Buscarbutton.TabIndex = 25;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nuevobutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nuevobutton.Location = new System.Drawing.Point(14, 311);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 45);
            this.Nuevobutton.TabIndex = 24;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Guardarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Guardarbutton.Location = new System.Drawing.Point(116, 311);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 46);
            this.Guardarbutton.TabIndex = 45;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eliminarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Eliminarbutton.Location = new System.Drawing.Point(215, 311);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 46);
            this.Eliminarbutton.TabIndex = 26;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(100, 79);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.IdnumericUpDown.TabIndex = 48;
            this.IdnumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdnumericUpDown_KeyPress);
            // 
            // CantidadcomboBox
            // 
            this.CantidadcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CantidadcomboBox.FormattingEnabled = true;
            this.CantidadcomboBox.Location = new System.Drawing.Point(390, 117);
            this.CantidadcomboBox.Name = "CantidadcomboBox";
            this.CantidadcomboBox.Size = new System.Drawing.Size(116, 21);
            this.CantidadcomboBox.TabIndex = 53;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.CantidadcomboBox);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.Ticketlabel);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.VendidoPorlabel);
            this.Controls.Add(this.Eventolabel);
            this.Controls.Add(this.VentaIdlabel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.DescripcionrichTextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.UsuarioscomboBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.TicketcomboBox);
            this.Controls.Add(this.PartidocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Name = "VentasForm";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Ticketlabel;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label VendidoPorlabel;
        private System.Windows.Forms.Label Eventolabel;
        private System.Windows.Forms.Label VentaIdlabel;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox UsuarioscomboBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.ComboBox TicketcomboBox;
        private System.Windows.Forms.ComboBox PartidocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.ComboBox CantidadcomboBox;
    }
}