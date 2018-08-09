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
            this.TipoPartidocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LugarPartidolabel = new System.Windows.Forms.Label();
            this.FechaPartidolabel = new System.Windows.Forms.Label();
            this.NombrePartidolabel = new System.Windows.Forms.Label();
            this.TipoIdlabel = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.IderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PartidodataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PreciocomboBox = new System.Windows.Forms.ComboBox();
            this.DescripcioncomboBox = new System.Windows.Forms.ComboBox();
            this.TicketcomboBox = new System.Windows.Forms.ComboBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartidodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.BackColor = System.Drawing.Color.Transparent;
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
            this.Preciolabel.BackColor = System.Drawing.Color.Transparent;
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
            this.Cantidadlabel.BackColor = System.Drawing.Color.Transparent;
            this.Cantidadlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidadlabel.Location = new System.Drawing.Point(332, 137);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(121, 13);
            this.Cantidadlabel.TabIndex = 33;
            this.Cantidadlabel.Text = "Cantidad Disponible:";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.BackColor = System.Drawing.Color.Transparent;
            this.Descripcionlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(378, 102);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(75, 13);
            this.Descripcionlabel.TabIndex = 32;
            this.Descripcionlabel.Text = "Descripcion:";
            // 
            // PartidoIdlabel
            // 
            this.PartidoIdlabel.AutoSize = true;
            this.PartidoIdlabel.BackColor = System.Drawing.Color.Transparent;
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
            // 
            // NombrePartidotextBox
            // 
            this.NombrePartidotextBox.Location = new System.Drawing.Point(113, 161);
            this.NombrePartidotextBox.MaxLength = 26;
            this.NombrePartidotextBox.Name = "NombrePartidotextBox";
            this.NombrePartidotextBox.Size = new System.Drawing.Size(154, 20);
            this.NombrePartidotextBox.TabIndex = 37;
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
            this.LugarPartidolabel.BackColor = System.Drawing.Color.Transparent;
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
            this.FechaPartidolabel.BackColor = System.Drawing.Color.Transparent;
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
            this.NombrePartidolabel.BackColor = System.Drawing.Color.Transparent;
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
            this.TipoIdlabel.BackColor = System.Drawing.Color.Transparent;
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
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(209, 327);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 45);
            this.Eliminarbutton.TabIndex = 50;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Borrarbutton.Location = new System.Drawing.Point(465, 191);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(75, 47);
            this.Borrarbutton.TabIndex = 51;
            this.Borrarbutton.Text = "Borrar";
            this.Borrarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Borrarbutton.UseVisualStyleBackColor = true;
            this.Borrarbutton.Click += new System.EventHandler(this.Borrarbutton_Click);
            // 
            // IderrorProvider
            // 
            this.IderrorProvider.ContainerControl = this;
            // 
            // PartidodataGridView
            // 
            this.PartidodataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.PartidodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartidodataGridView.Location = new System.Drawing.Point(290, 244);
            this.PartidodataGridView.Name = "PartidodataGridView";
            this.PartidodataGridView.Size = new System.Drawing.Size(340, 131);
            this.PartidodataGridView.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ticket ID:";
            // 
            // PreciocomboBox
            // 
            this.PreciocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreciocomboBox.FormattingEnabled = true;
            this.PreciocomboBox.Location = new System.Drawing.Point(459, 165);
            this.PreciocomboBox.Name = "PreciocomboBox";
            this.PreciocomboBox.Size = new System.Drawing.Size(121, 21);
            this.PreciocomboBox.TabIndex = 58;
            // 
            // DescripcioncomboBox
            // 
            this.DescripcioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescripcioncomboBox.FormattingEnabled = true;
            this.DescripcioncomboBox.Location = new System.Drawing.Point(459, 99);
            this.DescripcioncomboBox.Name = "DescripcioncomboBox";
            this.DescripcioncomboBox.Size = new System.Drawing.Size(121, 21);
            this.DescripcioncomboBox.TabIndex = 59;
            // 
            // TicketcomboBox
            // 
            this.TicketcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketcomboBox.FormattingEnabled = true;
            this.TicketcomboBox.Location = new System.Drawing.Point(459, 66);
            this.TicketcomboBox.Name = "TicketcomboBox";
            this.TicketcomboBox.Size = new System.Drawing.Size(121, 21);
            this.TicketcomboBox.TabIndex = 60;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(459, 134);
            this.CantidadtextBox.MaxLength = 26;
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(121, 20);
            this.CantidadtextBox.TabIndex = 61;
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // PartidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketsDeportivos.Properties.Resources._1378144182;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 387);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.TicketcomboBox);
            this.Controls.Add(this.DescripcioncomboBox);
            this.Controls.Add(this.PreciocomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartidodataGridView);
            this.Controls.Add(this.Borrarbutton);
            this.Controls.Add(this.Eliminarbutton);
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
            this.Controls.Add(this.TipoPartidocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Agregarbutton);
            this.Name = "PartidosForm";
            this.Text = "PartidosForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).EndInit();
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
        private System.Windows.Forms.ComboBox TipoPartidocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label LugarPartidolabel;
        private System.Windows.Forms.Label FechaPartidolabel;
        private System.Windows.Forms.Label NombrePartidolabel;
        private System.Windows.Forms.Label TipoIdlabel;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.ErrorProvider IderrorProvider;
        private System.Windows.Forms.DataGridView PartidodataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TicketcomboBox;
        private System.Windows.Forms.ComboBox DescripcioncomboBox;
        private System.Windows.Forms.ComboBox PreciocomboBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
    }
}