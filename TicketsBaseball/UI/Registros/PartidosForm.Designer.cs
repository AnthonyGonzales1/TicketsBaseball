namespace TicketsDeportivos.UI.Registros
{
    partial class PartidosForm
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
            this.Preciolabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.PartidoIdlabel = new System.Windows.Forms.Label();
            this.LugarPartidotextBox = new System.Windows.Forms.TextBox();
            this.NombrePartidotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.TipoPartidocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LugarPartidolabel = new System.Windows.Forms.Label();
            this.FechaPartidolabel = new System.Windows.Forms.Label();
            this.NombrePartidolabel = new System.Windows.Forms.Label();
            this.TipoIdlabel = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PartidodataGridView = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartidodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(204, 13);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(225, 25);
            this.Titulolabel.TabIndex = 45;
            this.Titulolabel.Text = "Registro de Partidos";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preciolabel.Location = new System.Drawing.Point(370, 168);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(83, 13);
            this.Preciolabel.TabIndex = 34;
            this.Preciolabel.Text = "Precio Ticket:";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidadlabel.Location = new System.Drawing.Point(332, 118);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(121, 13);
            this.Cantidadlabel.TabIndex = 33;
            this.Cantidadlabel.Text = "Cantidad Disponible:";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(377, 73);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(75, 13);
            this.Descripcionlabel.TabIndex = 32;
            this.Descripcionlabel.Text = "Descripcion:";
            // 
            // PartidoIdlabel
            // 
            this.PartidoIdlabel.AutoSize = true;
            this.PartidoIdlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartidoIdlabel.Location = new System.Drawing.Point(44, 69);
            this.PartidoIdlabel.Name = "PartidoIdlabel";
            this.PartidoIdlabel.Size = new System.Drawing.Size(67, 13);
            this.PartidoIdlabel.TabIndex = 29;
            this.PartidoIdlabel.Text = "Partido ID:";
            // 
            // LugarPartidotextBox
            // 
            this.LugarPartidotextBox.Location = new System.Drawing.Point(113, 254);
            this.LugarPartidotextBox.MaxLength = 26;
            this.LugarPartidotextBox.Name = "LugarPartidotextBox";
            this.LugarPartidotextBox.Size = new System.Drawing.Size(154, 20);
            this.LugarPartidotextBox.TabIndex = 39;
            this.LugarPartidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LugarPartidotextBox_KeyPress);
            // 
            // NombrePartidotextBox
            // 
            this.NombrePartidotextBox.Location = new System.Drawing.Point(113, 161);
            this.NombrePartidotextBox.MaxLength = 26;
            this.NombrePartidotextBox.Name = "NombrePartidotextBox";
            this.NombrePartidotextBox.Size = new System.Drawing.Size(154, 20);
            this.NombrePartidotextBox.TabIndex = 37;
            this.NombrePartidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombrePartidotextBox_KeyPress);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(458, 73);
            this.DescripciontextBox.MaxLength = 12;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(163, 20);
            this.DescripciontextBox.TabIndex = 40;
            this.DescripciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripciontextBox_KeyPress);
            // 
            // TipoPartidocomboBox
            // 
            this.TipoPartidocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPartidocomboBox.FormattingEnabled = true;
            this.TipoPartidocomboBox.Location = new System.Drawing.Point(113, 118);
            this.TipoPartidocomboBox.Name = "TipoPartidocomboBox";
            this.TipoPartidocomboBox.Size = new System.Drawing.Size(154, 21);
            this.TipoPartidocomboBox.TabIndex = 36;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(193, 64);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 40);
            this.Buscarbutton.TabIndex = 27;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(113, 207);
            this.FechadateTimePicker.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.FechadateTimePicker.MinDate = new System.DateTime(2015, 12, 25, 0, 0, 0, 0);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.FechadateTimePicker.TabIndex = 38;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(209, 327);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 45);
            this.Eliminarbutton.TabIndex = 25;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(113, 327);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 45);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(20, 327);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 45);
            this.Nuevobutton.TabIndex = 26;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(546, 191);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 47);
            this.Agregarbutton.TabIndex = 43;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LugarPartidolabel
            // 
            this.LugarPartidolabel.AutoSize = true;
            this.LugarPartidolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LugarPartidolabel.Location = new System.Drawing.Point(25, 254);
            this.LugarPartidolabel.Name = "LugarPartidolabel";
            this.LugarPartidolabel.Size = new System.Drawing.Size(86, 13);
            this.LugarPartidolabel.TabIndex = 31;
            this.LugarPartidolabel.Text = "Lugar Partido:";
            // 
            // FechaPartidolabel
            // 
            this.FechaPartidolabel.AutoSize = true;
            this.FechaPartidolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPartidolabel.Location = new System.Drawing.Point(24, 207);
            this.FechaPartidolabel.Name = "FechaPartidolabel";
            this.FechaPartidolabel.Size = new System.Drawing.Size(87, 13);
            this.FechaPartidolabel.TabIndex = 30;
            this.FechaPartidolabel.Text = "Fecha Partido:";
            // 
            // NombrePartidolabel
            // 
            this.NombrePartidolabel.AutoSize = true;
            this.NombrePartidolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePartidolabel.Location = new System.Drawing.Point(15, 164);
            this.NombrePartidolabel.Name = "NombrePartidolabel";
            this.NombrePartidolabel.Size = new System.Drawing.Size(98, 13);
            this.NombrePartidolabel.TabIndex = 35;
            this.NombrePartidolabel.Text = "Nombre Partido:";
            // 
            // TipoIdlabel
            // 
            this.TipoIdlabel.AutoSize = true;
            this.TipoIdlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoIdlabel.Location = new System.Drawing.Point(17, 121);
            this.TipoIdlabel.Name = "TipoIdlabel";
            this.TipoIdlabel.Size = new System.Drawing.Size(94, 13);
            this.TipoIdlabel.TabIndex = 28;
            this.TipoIdlabel.Text = "Tipo Partido ID:";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(117, 64);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.IdnumericUpDown.TabIndex = 46;
            this.IdnumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdnumericUpDown_KeyPress);
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(459, 116);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(162, 20);
            this.CantidadnumericUpDown.TabIndex = 47;
            this.CantidadnumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadnumericUpDown_KeyPress);
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(458, 162);
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(162, 20);
            this.PrecionumericUpDown.TabIndex = 48;
            this.PrecionumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecionumericUpDown_KeyPress);
            // 
            // PartidodataGridView
            // 
            this.PartidodataGridView.AllowUserToAddRows = false;
            this.PartidodataGridView.AllowUserToOrderColumns = true;
            this.PartidodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartidodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.CantDisponible,
            this.PrecioTicket});
            this.PartidodataGridView.Location = new System.Drawing.Point(335, 247);
            this.PartidodataGridView.Name = "PartidodataGridView";
            this.PartidodataGridView.ReadOnly = true;
            this.PartidodataGridView.RowHeadersVisible = false;
            this.PartidodataGridView.Size = new System.Drawing.Size(298, 128);
            this.PartidodataGridView.TabIndex = 49;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // CantDisponible
            // 
            this.CantDisponible.HeaderText = "CantDisponible";
            this.CantDisponible.Name = "CantDisponible";
            this.CantDisponible.ReadOnly = true;
            // 
            // PrecioTicket
            // 
            this.PrecioTicket.HeaderText = "PrecioTicket";
            this.PrecioTicket.Name = "PrecioTicket";
            this.PrecioTicket.ReadOnly = true;
            // 
            // PartidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 387);
            this.Controls.Add(this.PartidodataGridView);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.LugarPartidolabel);
            this.Controls.Add(this.FechaPartidolabel);
            this.Controls.Add(this.NombrePartidolabel);
            this.Controls.Add(this.TipoIdlabel);
            this.Controls.Add(this.PartidoIdlabel);
            this.Controls.Add(this.LugarPartidotextBox);
            this.Controls.Add(this.NombrePartidotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.TipoPartidocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Agregarbutton);
            this.Name = "PartidosForm";
            this.Text = "PartidosForm";
            this.Load += new System.EventHandler(this.PartidosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartidodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label PartidoIdlabel;
        private System.Windows.Forms.TextBox LugarPartidotextBox;
        private System.Windows.Forms.TextBox NombrePartidotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.ComboBox TipoPartidocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label LugarPartidolabel;
        private System.Windows.Forms.Label FechaPartidolabel;
        private System.Windows.Forms.Label NombrePartidolabel;
        private System.Windows.Forms.Label TipoIdlabel;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.DataGridView PartidodataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTicket;
    }
}