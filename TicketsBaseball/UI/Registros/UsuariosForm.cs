using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketsDeportivos.BLL;
using TicketsDeportivos.DAL;
using TicketsDeportivos.Entidades;

namespace TicketsDeportivos.UI.Registros
{
    public partial class UsuariosForm : Form
    {
        Usuario usuario = new Usuario();
        public UsuariosForm()
        {
            InitializeComponent();
        }
        private Usuario Llenaclase()
        {
            Usuario usuario = new Usuario();
            if (IdnumericUpDown.Value == 0)
            {
                usuario.UsuarioId = 0;
            }
            else
            {
                usuario.UsuarioId = Convert.ToInt32(IdnumericUpDown.Value);
            }
            usuario.Nombres = NombrestextBox.Text;
            usuario.Apellidos = ApellidostextBox.Text;
            usuario.Telefono = TelefonomaskedTextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.Direccion = DirecciontextBox.Text;
            usuario.NombreUsuario = NombreUsuariotextBox.Text;
            usuario.Contrasena = ContrasenatextBox.Text;
            usuario.ConfirmarContrasena = ConfirmarContrasenatextBox.Text;
            if (usuario.Activo == 1)
            {
                ActivocheckBox.Checked = true;
            }
            else
            {
                ActivocheckBox.Checked = false;
            }
            usuario.Foto = FotopictureBox.ImageLocation;

            return usuario;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            TelefonomaskedTextBox.Clear();
            EmailtextBox.Clear();
            DirecciontextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContrasenatextBox.Clear();
            ConfirmarContrasenatextBox.Clear();
            ActivocheckBox.Checked = false;
            FotopictureBox.ImageLocation = null;
        }
        
        public bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                errorProvider.SetError(IdnumericUpDown, "Llenar Usuario Id");
                paso = true;
            }
            if (error == 2 && NombrestextBox.Text == string.Empty)
            {
                errorProvider.SetError(NombrestextBox,
                   "Debes ingresar un Nombre");
                paso = true;
            }
            if (error == 2 && ApellidostextBox.Text == string.Empty)
            {
                errorProvider.SetError(ApellidostextBox,
                   "Debes ingresar un Apellido");
                paso = true;
            }
            if (error == 2 && TelefonomaskedTextBox.Text == string.Empty)
            {
                errorProvider.SetError(TelefonomaskedTextBox,
                   "Debes ingresar un Numero de Telefono");
                paso = true;
            }

            if (error == 2 && EmailtextBox.Text == string.Empty)
            {
                errorProvider.SetError(EmailtextBox,
                    "Debes ingresar un Email");
                paso = true;
            }

            if (error == 2 && DirecciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DirecciontextBox,
                    "Debes ingresar una Direccion");
                paso = true;
            }
            if (error == 2 && NombreUsuariotextBox.Text == string.Empty)
            {
                errorProvider.SetError(NombreUsuariotextBox,
                    "Debes ingresar un Nombre de Usuario");
                paso = true;
            }
            if (error == 2 && ContrasenatextBox.Text == string.Empty)
            {
                errorProvider.SetError(ContrasenatextBox,
                    "Debes ingresar una Contrasena");
                paso = true;
            }
            if (error == 2 && ConfirmarContrasenatextBox.Text == string.Empty)
            {
                errorProvider.SetError(ConfirmarContrasenatextBox,
                    "Las Contrasenas deben ser identicas");
                paso = true;
            }
            if (ConfirmarContrasenatextBox.Text.Length > 0)
            {
                usuario.ConfirmarContrasena = ConfirmarContrasenatextBox.Text;
            }
            if (ActivocheckBox.Checked)
            {
                usuario.Activo = 1;
            }
            else
            {
                usuario.Activo.ToString();
            }

            if (FotopictureBox.ImageLocation != null)
            {
                usuario.Foto = FotopictureBox.ImageLocation.ToString();
            }
            else
            {
                errorProvider.SetError(FotopictureBox, "Debe ingresar una foto");
                paso = false;
            }
            
            return paso;
        }

        public void LlenarCampos()
        {
            NombrestextBox.Text = usuario.Nombres.ToString();
            ApellidostextBox.Text = usuario.Apellidos.ToString();
            TelefonomaskedTextBox.Text = usuario.Telefono.ToString();
            EmailtextBox.Text = usuario.Email.ToString();
            DirecciontextBox.Text = usuario.Direccion.ToString();
            NombreUsuariotextBox.Text = usuario.NombreUsuario.ToString();
            ContrasenatextBox.Text = usuario.Contrasena.ToString();
            ConfirmarContrasenatextBox.Text = usuario.ConfirmarContrasena.ToString();
            if (usuario.Activo == 1)
            {
                ActivocheckBox.Checked = true;
            }
            else
            {
                ActivocheckBox.Checked = false;
            }
            FotopictureBox.ImageLocation = usuario.Foto;
        }

        

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("Llenar los Campos vacios");
                errorProvider.Clear();
                return;
            }
            else
            {
                Usuario usuario = Llenaclase();
                if (IdnumericUpDown.Value == 0)
                {
                    if (BLL.UsuarioBLL.Guardar(usuario))
                    {
                        MessageBox.Show("Guardado!!");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar!!");
                    }
                }
                else
                {
                    var result = MessageBox.Show("Seguro de Modificar?", "+Usuarios",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (BLL.UsuarioBLL.Modificar(Llenaclase()))
                        {
                            MessageBox.Show("Modificado!!");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar!!");
                        }
                    }
                }
            }
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            var result = MessageBox.Show("Seguro de  Eliminar?", "+Usuarios",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (BLL.UsuarioBLL.Eliminar(Convert.ToInt32(IdnumericUpDown.Value)))
                {
                    MessageBox.Show("Eliminado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Fotobutton_Click_1(object sender, EventArgs e)
        {
            FotoopenFileDialog.Filter = "Image Files|*.jpg; *.jpeg";
            FotoopenFileDialog.ShowDialog();
            if (FotoopenFileDialog.FileName != null)
            {
                FotopictureBox.ImageLocation = FotoopenFileDialog.FileName;
            }
        }

        private void DirecciontextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 35) || (e.KeyChar == 44) || (e.KeyChar == 46) || (e.KeyChar == 47) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(DirecciontextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                NombreUsuariotextBox.Focus();
            }
        }

        private void EmailtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 64) || (e.KeyChar == 46) || (e.KeyChar == 95) || (e.KeyChar == 45) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(EmailtextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                DirecciontextBox.Focus();
            }
        }

        private void TelefonomaskedTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(TelefonomaskedTextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                EmailtextBox.Focus();
            }
        }

        private void ApellidostextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(ApellidostextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                TelefonomaskedTextBox.Focus();
            }
        }

        private void NombrestextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(NombrestextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                ApellidostextBox.Focus();
            }

        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de llenar la casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Usuario usuario = BLL.UsuarioBLL.Buscar(id);

                if (usuario != null)
                {
                    IdnumericUpDown.Value = usuario.UsuarioId;
                    NombrestextBox.Text = usuario.Nombres.ToString();
                    ApellidostextBox.Text = usuario.Apellidos.ToString();
                    TelefonomaskedTextBox.Text = usuario.Telefono.ToString();
                    EmailtextBox.Text = usuario.Email.ToString();
                    DirecciontextBox.Text = usuario.Direccion.ToString();
                    NombreUsuariotextBox.Text = usuario.NombreUsuario.ToString();
                    ContrasenatextBox.Text = usuario.Contrasena.ToString();
                    ConfirmarContrasenatextBox.Text = usuario.ConfirmarContrasena.ToString();
                    if (usuario.Activo == 1)
                    {
                        ActivocheckBox.Checked = true;
                    }
                    else
                    {
                        ActivocheckBox.Checked = false;
                    }
                    FotopictureBox.ImageLocation = usuario.Foto;

                }
                else
                {
                    MessageBox.Show("No fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }
        
        private void ConfirmarContrasenatextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(ConfirmarContrasenatextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Fotobutton.Focus();
            }
        }

        private void ContrasenatextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(ContrasenatextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                ConfirmarContrasenatextBox.Focus();
            }
        }

        private void NombreUsuariotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 95) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(NombreUsuariotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                ContrasenatextBox.Focus();
            }
        }
    }
}
