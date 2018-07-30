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
    public partial class VentasForm : Form
    {
        Venta venta = new Venta();
        public VentasForm()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            Repositorio<Partido> partido = new Repositorio<Partido>(new Contexto());
            PartidocomboBox.DataSource = partido.GetList(c => true);
            PartidocomboBox.DisplayMember = "NombrePartido";
            PartidocomboBox.ValueMember = "PartidoId";

            FechadateTimePicker.Enabled = false;
            Eliminarbutton.Enabled = false;

            Repositorio<PartidoDetalle> partidoDetalle = new Repositorio<PartidoDetalle>(new Contexto());
            TicketcomboBox.DataSource = partidoDetalle.GetList(c => true);
            TicketcomboBox.DisplayMember = "Descripcion";
            TicketcomboBox.ValueMember = "Precio";
            
            Repositorio<Usuario> usuario = new Repositorio<Usuario>(new Contexto());
            UsuarioscomboBox.DataSource = usuario.GetList(c => true);
            UsuarioscomboBox.DisplayMember = "NombreUsuario";
            UsuarioscomboBox.ValueMember = "UsuarioId";
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Limpiar()
        {
            UsuarioscomboBox.ResetText();
            PartidocomboBox.ResetText();
            TotaltextBox.Clear();
            CantidadtextBox.Clear();
            DescripcionrichTextBox.Clear();
            VentadataGridView.Rows.Clear();
        }

        private Venta LlenaClase()
        {
            Venta venta = new Venta();

            venta.VentaId = Convert.ToInt32(IdnumericUpDown.Value);
            venta.UsuarioId = Convert.ToInt32(UsuarioscomboBox.Text);
            venta.Fecha = FechadateTimePicker.Value;
            venta.Ticket = Convert.ToInt32(TicketcomboBox.Text);
            venta.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            venta.Descripcion = DescripcionrichTextBox.Text;
            venta.Total = Convert.ToInt32(TotaltextBox.Text);
           
            return venta;
        }

        private bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                errorProvider.SetError(IdnumericUpDown, "Llenar Venta Id");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(UsuarioscomboBox.Text))
            {
                errorProvider.SetError(UsuarioscomboBox,
                   "Debes seleccionar un Usuario");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(FechadateTimePicker.Text))
            {
                errorProvider.SetError(FechadateTimePicker,
                   "Debes ingresar una Fecha");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(TicketcomboBox.Text))
            {
                errorProvider.SetError(TicketcomboBox,
                   "Debes seleccionar un Ticket");
                paso = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                errorProvider.SetError(CantidadtextBox,
                    "Debes ingresar una Cantidad");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripcionrichTextBox.Text))
            {
                errorProvider.SetError(DescripcionrichTextBox,
                    "Debes ingresar una Descripcion");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(TotaltextBox.Text))
            {
                errorProvider.SetError(TotaltextBox,
                    "Debes ingresar un Total");
                paso = true;
            }
            if (VentadataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in VentadataGridView.Rows)
                {
                    venta.AgregarVenta((int)item.Cells["PartidoId"].Value);
                }
            }
            else
            {
                MensajeError("Error al guardar debido a que no agrego un evento!!!");
                paso = true;
            }

            return paso;
        }

        private void LlenarCampos()
        {
            UsuarioscomboBox.Text = venta.UsuarioId.ToString();
            FechadateTimePicker.Text = venta.Fecha.ToString();
            TicketcomboBox.Text = venta.Ticket.ToString();
            CantidadtextBox.Text = venta.Cantidad.ToString();
            DescripcionrichTextBox.Text = venta.Descripcion.ToString();
            TotaltextBox.Text = venta.Total.ToString();
            foreach (var item in venta.Ventapartido)
            {
                VentadataGridView.Rows.Add(item.PartidoId);
            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Eliminarbutton.Enabled = false;
            Limpiar();
            Guardarbutton.Text = "Guardar";
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            int precio = 0;
            int cantidad = 0;
            int.TryParse(TicketcomboBox.SelectedValue.ToString(), out precio);
            int.TryParse(CantidadtextBox.Text, out cantidad);
            if (CantidadtextBox.Text.Length > 0)
            {
                VentadataGridView.Rows.Add(PartidocomboBox.SelectedValue, PartidocomboBox.Text);
                TotaltextBox.Text = (precio * cantidad).ToString();
            }
            else
            {
                MensajeError("Por favor ingrese una cantidad");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de llenar la casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                if (BLL.VentasBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de llenar casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Venta venta = BLL.VentasBLL.Buscar(id);

                if (venta != null)
                {
                    IdnumericUpDown.Value = venta.VentaId;
                    UsuarioscomboBox.Text = venta.UsuarioId.ToString();
                    FechadateTimePicker.Text = venta.Fecha.ToString();
                    TicketcomboBox.Text = venta.Ticket.ToString();
                    CantidadtextBox.Text = venta.Cantidad.ToString();
                    DescripcionrichTextBox.Text = venta.Descripcion.ToString();
                    TotaltextBox.Text = venta.Total.ToString();
                    
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Venta venta = LlenaClase();
            
            if (Validar(2))
            {
                MessageBox.Show("Favor de llenar las Casillas");
            }
            else
            {
                if (IdnumericUpDown.Value == 0)
                {
                    paso = BLL.VentasBLL.Guardar(venta);
                }
                else
                {
                    var usuarios = BLL.VentasBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));

                    if (usuarios != null)
                    {
                        paso = BLL.VentasBLL.Modificar(venta);
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
        
        private void Imprimirbutton_Click_1(object sender, EventArgs e)
        {
            Consultas.VentasConsult ven = new Consultas.VentasConsult();
            ven.Show();
        }

        private void CantidadtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(CantidadtextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
        }

        private void DescripcionrichTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 46) || (e.KeyChar == 44) || (e.KeyChar == 32))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(DescripcionrichTextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
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
