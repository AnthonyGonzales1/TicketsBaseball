namespace TicketsDeportivos
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.Contrasenialabel = new System.Windows.Forms.Label();
            this.NombreUsuariolabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Entrarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.LoginpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(136, 147);
            this.ContrasenatextBox.MaxLength = 29;
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.Size = new System.Drawing.Size(159, 20);
            this.ContrasenatextBox.TabIndex = 9;
            this.ContrasenatextBox.UseSystemPasswordChar = true;
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(136, 77);
            this.NombreUsuariotextBox.MaxLength = 31;
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(159, 20);
            this.NombreUsuariotextBox.TabIndex = 8;
            // 
            // Contrasenialabel
            // 
            this.Contrasenialabel.AutoSize = true;
            this.Contrasenialabel.BackColor = System.Drawing.Color.Transparent;
            this.Contrasenialabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenialabel.Location = new System.Drawing.Point(49, 147);
            this.Contrasenialabel.Name = "Contrasenialabel";
            this.Contrasenialabel.Size = new System.Drawing.Size(81, 14);
            this.Contrasenialabel.TabIndex = 5;
            this.Contrasenialabel.Text = "Contraseña:";
            // 
            // NombreUsuariolabel
            // 
            this.NombreUsuariolabel.AutoSize = true;
            this.NombreUsuariolabel.BackColor = System.Drawing.Color.Transparent;
            this.NombreUsuariolabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuariolabel.Location = new System.Drawing.Point(27, 77);
            this.NombreUsuariolabel.Name = "NombreUsuariolabel";
            this.NombreUsuariolabel.Size = new System.Drawing.Size(107, 14);
            this.NombreUsuariolabel.TabIndex = 6;
            this.NombreUsuariolabel.Text = "Nombre Usuario:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Entrarbutton
            // 
            this.Entrarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Entrarbutton.BackgroundImage = global::TicketsDeportivos.Properties.Resources._1378144182;
            this.Entrarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Entrarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Entrarbutton.Location = new System.Drawing.Point(188, 197);
            this.Entrarbutton.Name = "Entrarbutton";
            this.Entrarbutton.Size = new System.Drawing.Size(76, 42);
            this.Entrarbutton.TabIndex = 10;
            this.Entrarbutton.Text = "Entrar";
            this.Entrarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Entrarbutton.UseVisualStyleBackColor = false;
            this.Entrarbutton.Click += new System.EventHandler(this.Entrarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.Color.Transparent;
            this.Nuevobutton.BackgroundImage = global::TicketsDeportivos.Properties.Resources._1378144182;
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nuevobutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(83, 197);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 42);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // LoginpictureBox
            // 
            this.LoginpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginpictureBox.BackgroundImage = global::TicketsDeportivos.Properties.Resources.Login_Berufsbildung_Logo_svg;
            this.LoginpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginpictureBox.Location = new System.Drawing.Point(93, 12);
            this.LoginpictureBox.Name = "LoginpictureBox";
            this.LoginpictureBox.Size = new System.Drawing.Size(128, 50);
            this.LoginpictureBox.TabIndex = 11;
            this.LoginpictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketsDeportivos.Properties.Resources.UltimateSportsTicket_Media_Twitter_1024x512;
            this.ClientSize = new System.Drawing.Size(326, 264);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.NombreUsuariotextBox);
            this.Controls.Add(this.Contrasenialabel);
            this.Controls.Add(this.NombreUsuariolabel);
            this.Controls.Add(this.LoginpictureBox);
            this.Controls.Add(this.Entrarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Name = "Login";
            this.Text = "Iniciar Seccion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.Label Contrasenialabel;
        private System.Windows.Forms.Label NombreUsuariolabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox LoginpictureBox;
        private System.Windows.Forms.Button Entrarbutton;
        private System.Windows.Forms.Button Nuevobutton;
    }
}

