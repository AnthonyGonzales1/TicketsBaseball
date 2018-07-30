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
        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();
            
            usuario.UsuarioId = Convert.ToInt32(IdnumericUpDown.Value);
            usuario.Nombres = NombrestextBox.Text;
            usuario.Apellidos = ApellidostextBox.Text;
            usuario.Telefono = TelefonomaskedTextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.Direccion = DirecciontextBox.Text;
            usuario.NombreUsuario = NombreUsuariotextBox.Text;
            usuario.Contrasena = ContrasenatextBox.Text;
            usuario.ConfirmarContrasena = ConfirmarContrasenatextBox.Text;
            usuario.Activo = Convert.ToInt32(ActivocheckBox.Text);
            usuario.Foto = FotopictureBox.Text;
            
            return usuario;
        }

        private void Limpiar()
        {
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
            if (error == 2 && string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                errorProvider.SetError(NombrestextBox,
                   "Debes seleccionar un Nombre");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(ApellidostextBox.Text))
            {
                errorProvider.SetError(ApellidostextBox,
                   "Debes ingresar un Apellido");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
            {
                errorProvider.SetError(TelefonomaskedTextBox,
                   "Debes ingresar un Numero de Telefono");
                paso = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                errorProvider.SetError(EmailtextBox,
                    "Debes ingresar un Email");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                errorProvider.SetError(DirecciontextBox,
                    "Debes ingresar una Direccion");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(NombreUsuariotextBox.Text))
            {
                errorProvider.SetError(NombreUsuariotextBox,
                    "Debes ingresar un Nombre de Usuario");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(ContrasenatextBox.Text))
            {
                errorProvider.SetError(ContrasenatextBox,
                    "Debes ingresar una Contrasena");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(ConfirmarContrasenatextBox.Text))
            {
                errorProvider.SetError(ConfirmarContrasenatextBox,
                    "Las Contrasenas deben sr identicas");
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
                usuario.Activo = 0;
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
        
        private void NombreUsuariotextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if (e.KeyCode == keys.Enter)
            //{
            //    if (this.GetNextControl(ActiveControl, true) != null)
            //    {
            //        e.Handled = true;
            //        this.GetNextControl(ActiveControl, true).Focus();
            //    }
            //}
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            Usuario usuario = LlenaClase();

            if (ActivocheckBox.Checked == true)
            {
                usuario.Activo = 1;
            }
            else
            {
                usuario.Activo = 0;
            }
            if (ContrasenatextBox.Text.Trim() != ConfirmarContrasenatextBox.Text.Trim())
            {
                errorProvider.SetError(ContrasenatextBox, "Las contraseña no son identicas");
                errorProvider.SetError(ConfirmarContrasenatextBox, "Las contraseña no son identicas");
                ConfirmarContrasenatextBox.Clear();
            }
            else
            {
                if (Validar(2))
                {
                    MessageBox.Show("Favor de Llenar las Casillas");
                }
                else
                {
                    if (IdnumericUpDown.Value == 0)
                    {
                        paso = BLL.UsuarioBLL.Guardar(usuario);
                    }
                    else
                    {
                        var usuarios = BLL.UsuarioBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));

                        if (usuarios != null)
                        {
                            paso = BLL.UsuarioBLL.Modificar(usuario);
                        }
                    }
                    Limpiar();
                    errorProvider.Clear();
                    if (paso)
                    {
                        MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                if (BLL.UsuarioBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Eliminarbutton.Enabled = false;
            errorProvider.Clear();
            Limpiar();
            Guardarbutton.Text = "Guardar";
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
                    ActivocheckBox.Text = usuario.Activo.ToString();
                    FotopictureBox.Text = usuario.Foto.ToString();

                }
                else
                {
                    MessageBox.Show("No fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

        private void UsuariosForm_Load_1(object sender, EventArgs e)
        {
            Eliminarbutton.Enabled = false;
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

        private void IdnumericUpDown_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(IdnumericUpDown, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Buscarbutton.Focus();
            }
        }
    }
}
