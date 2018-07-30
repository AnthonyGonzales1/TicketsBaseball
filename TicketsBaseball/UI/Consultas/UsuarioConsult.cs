using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.UI.Reportes;

namespace TicketsDeportivos.UI.Consultas
{
    public partial class UsuarioConsult : Form
    {
        Usuario usuario = new Usuario();
        Expression<Func<Usuario, bool>> filtrar = x => true;
        public UsuarioConsult()
        {
            InitializeComponent();
        }

        private void LimpiarError()
        {
            errorProvider.Clear();
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                errorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                errorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Expression<Func<Usuario, bool>> filtrar = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.UsuarioId == id;
                    break;
                //Descripcion
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Nombres.Contains(CriteriotextBox.Text);
                    break;

                //Cantidad
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Apellidos.Contains(CriteriotextBox.Text);
                    break;
                //precio
                case 3:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    filtrar = t => t.Telefono.Contains(CriteriotextBox.Text);
                    break;
                //idDepartamento
                case 4:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Email.Contains(CriteriotextBox.Text);
                    break;

                    case 5:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Direccion.Contains(CriteriotextBox.Text);
                    break;

                case 6:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.NombreUsuario.Contains(CriteriotextBox.Text);
                    break;

                //Listar Todo
                case 7:

                    filtrar = x => true;
                    break;
            }
            UsuariodataGridView.DataSource = BLL.UsuarioBLL.GetList(filtrar);
            CantidadtextBox.Text = UsuariodataGridView.RowCount.ToString();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            UsuarioReviewer usuarioReviewer = new UsuarioReviewer(BLL.UsuarioBLL.GetList(filtrar));
            {
                usuarioReviewer.Show();
            }
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriotextBox.ReadOnly = false;
        }

        private void CriteriotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 13) || (e.KeyChar == 127) || (e.KeyChar == 32))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(CriteriotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Consultarbutton.Focus();
            }

        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioConsult_Load(object sender, EventArgs e)
        {
            CriteriotextBox.ReadOnly = true;
        }
    }
}
