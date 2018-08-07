using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using TicketsDeportivos.BLL;
using TicketsDeportivos.DAL;
using TicketsDeportivos.Entidades;

namespace TicketsDeportivos
{
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();

        public Login()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            NombreUsuariotextBox.Clear();
            ContrasenatextBox.Clear();
            errorProvider.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public bool Validar(int error)
        {
            bool paso = false;

            if (error == 2 && string.IsNullOrWhiteSpace(NombreUsuariotextBox.Text))
            {
                errorProvider.SetError(NombreUsuariotextBox,
                   "Debes infresar un Nombre de Usuario");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(ContrasenatextBox.Text))
            {
                errorProvider.SetError(ContrasenatextBox,
                   "Debes ingresar una Contrasena");
                paso = true;
            }

            return paso;
        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {


            int paso = 0;
            Expression<Func<Usuario, bool>> filtrar = x => true;
            List<Usuario> user = new List<Usuario>();

            if (NombreUsuariotextBox.Text == string.Empty)
            {
                paso = 1;
                errorProvider.SetError(NombreUsuariotextBox, "Incorrecto");

            }
            if (ContrasenatextBox.Text == string.Empty)
            {
                paso = 1;
                errorProvider.SetError(ContrasenatextBox, "Incorrecto");

            }
            if (paso == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            PrincipalForm principalForm = new PrincipalForm();
            principalForm.Show();
            
            filtrar = t => t.NombreUsuario.Equals(NombreUsuariotextBox.Text);
            user = BLL.UsuarioBLL.GetList(filtrar);
            /*
            if (user.Exists(x => x.NombreUsuario == NombreUsuariotextBox.Text) && user.Exists(x => x.Contrasena == ContrasenatextBox.Text))
            {
                foreach (var item in BLL.UsuarioBLL.GetList(x => x.NombreUsuario == NombreUsuariotextBox.Text))
                {
                    BLL.UsuarioBLL.LoginUsuario(item.Nombres, item.UsuarioId);
                }

            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                errorProvider.SetError(ContrasenatextBox, "Incorrecto");
                errorProvider.SetError(ContrasenatextBox, "Incorrecto");

            }*/
            ContrasenatextBox.MaxLength = 14;
        }
    }
}
