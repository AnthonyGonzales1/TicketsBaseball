namespace TicketsDeportivos.UI.Registros
{
    partial class TicketForm
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
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.IdTipoPartidolabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TipoPartidocomboBox = new System.Windows.Forms.ComboBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(86, 77);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.IdnumericUpDown.TabIndex = 22;
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.BackColor = System.Drawing.Color.Transparent;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Titulolabel.Location = new System.Drawing.Point(73, 18);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(155, 23);
            this.Titulolabel.TabIndex = 21;
            this.Titulolabel.Text = "Registro Ticket";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(202, 251);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 45);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Guardarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(109, 251);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 45);
            this.Guardarbutton.TabIndex = 20;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nuevobutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(17, 251);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 45);
            this.Nuevobutton.TabIndex = 15;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(203, 54);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(65, 43);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(100, 197);
            this.DescripciontextBox.MaxLength = 30;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(177, 20);
            this.DescripciontextBox.TabIndex = 19;
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.BackColor = System.Drawing.Color.Transparent;
            this.Descripcionlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(14, 197);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(80, 14);
            this.Descripcionlabel.TabIndex = 17;
            this.Descripcionlabel.Text = "Descripcion:";
            // 
            // IdTipoPartidolabel
            // 
            this.IdTipoPartidolabel.AutoSize = true;
            this.IdTipoPartidolabel.BackColor = System.Drawing.Color.Transparent;
            this.IdTipoPartidolabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTipoPartidolabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IdTipoPartidolabel.Location = new System.Drawing.Point(15, 78);
            this.IdTipoPartidolabel.Name = "IdTipoPartidolabel";
            this.IdTipoPartidolabel.Size = new System.Drawing.Size(65, 14);
            this.IdTipoPartidolabel.TabIndex = 18;
            this.IdTipoPartidolabel.Text = "Ticket ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Precio Ticket:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo Partido:";
            // 
            // TipoPartidocomboBox
            // 
            this.TipoPartidocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPartidocomboBox.FormattingEnabled = true;
            this.TipoPartidocomboBox.Location = new System.Drawing.Point(107, 155);
            this.TipoPartidocomboBox.Name = "TipoPartidocomboBox";
            this.TipoPartidocomboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoPartidocomboBox.TabIndex = 38;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(109, 118);
            this.PreciotextBox.MaxLength = 30;
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(119, 20);
            this.PreciotextBox.TabIndex = 39;
            //this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketsDeportivos.Properties.Resources._1378144182;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(295, 308);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.TipoPartidocomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.IdTipoPartidolabel);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label IdTipoPartidolabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoPartidocomboBox;
        private System.Windows.Forms.TextBox PreciotextBox;
    }
}