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
        public int RowSelected { get; set; }
        List<Venta> Ventapartido = new List<Venta>();
        Venta venta = new Venta();
        public VentasForm()
        {
            InitializeComponent();
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
            UsuarioscomboBox.Text = string.Empty;
            PartidocomboBox.Text = string.Empty;
            TotaltextBox.Clear();
            CantidadcomboBox.Text = string.Empty;
            DescripcionrichTextBox.Clear();
            TicketcomboBox.Text = string.Empty;
            CantidadcomboBox.Text = string.Empty;
        }

        private Venta LlenaClase()
        {
            Venta venta = new Venta();
            if (venta.VentaId == 0)
            {
                venta.VentaId = 0;
            }
            else
            {
                venta.VentaId = Convert.ToInt32(venta.VentaId);
            }
            
            venta.UsuarioId = Convert.ToInt32(UsuarioscomboBox.SelectedValue);
            venta.Fecha = FechadateTimePicker.Value;
            venta.Ticket = Convert.ToInt32(TicketcomboBox.SelectedValue);
            venta.Cantidad = Convert.ToInt32(CantidadcomboBox.Text);
            venta.Descripcion = DescripcionrichTextBox.Text;
           
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
            if (error == 2 && UsuarioscomboBox.Text == string.Empty)
            {
                errorProvider.SetError(UsuarioscomboBox,
                   "Debes seleccionar un Usuario");
                paso = true;
            }
            if (error == 2 && TicketcomboBox.Text == string.Empty)
            {
                errorProvider.SetError(TicketcomboBox,
                   "Debes seleccionar un Ticket");
                paso = true;
            }

            if (error == 3 && CantidadcomboBox.Text == string.Empty)
            {
                errorProvider.SetError(CantidadcomboBox,
                    "Debes ingresar una Cantidad");
                paso = true;
            }

            if (error == 4 && DescripcionrichTextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripcionrichTextBox,
                    "Debes ingresar una Descripcion");
                paso = true;
            }
            if (error == 4 && TotaltextBox.Text == string.Empty)
            {
                errorProvider.SetError(TotaltextBox,
                    "Debes ingresar un Total");
                paso = true;
            }

            return paso;
        }

        private void LlenarCampos()
        {
            UsuarioscomboBox.Text = venta.UsuarioId.ToString();
            FechadateTimePicker.Text = venta.Fecha.ToString();
            TicketcomboBox.Text = venta.Ticket.ToString();
            CantidadcomboBox.Text = venta.Cantidad.ToString();
            DescripcionrichTextBox.Text = venta.Descripcion.ToString();
            TotaltextBox.Text = venta.Total.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
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
                    UsuarioscomboBox.SelectedValue = venta.UsuarioId;
                    FechadateTimePicker.Value = venta.Fecha;
                    TicketcomboBox.Text = venta.Ticket.ToString();
                    CantidadcomboBox.Text = venta.Cantidad.ToString();
                    DescripcionrichTextBox.Text = venta.Descripcion.ToString();
                    TotaltextBox.Text = venta.Total.ToString();
                    
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
                int precio = 0;
                int cantidad = 0;
                int.TryParse(TicketcomboBox.SelectedValue.ToString(), out precio);
                int.TryParse(CantidadcomboBox.Text, out cantidad);
                if (CantidadcomboBox.Text.Length > 0)
                {
                    TotaltextBox.Text = (precio * cantidad).ToString();
                }
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
                    var result = MessageBox.Show("Seguro de Modificar?", "+Ventas",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (BLL.VentasBLL.Modificar(LlenaClase()))
                        {
                            MessageBox.Show("Modificado!!");
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
        private void Imprimirbutton_Click_1(object sender, EventArgs e)
        {
            Consultas.VentasConsult ven = new Consultas.VentasConsult();
            ven.Show();
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
        

        private void VentasForm_Load(object sender, EventArgs e)
        {
            Repositorio<Partido> partido = new Repositorio<Partido>(new Contexto());
            PartidocomboBox.DataSource = partido.GetList(c => true);
            PartidocomboBox.DisplayMember = "NombrePartido";
            PartidocomboBox.ValueMember = "PartidoId";

            FechadateTimePicker.Enabled = false;
            TicketcomboBox.DataSource = partido.GetList(c => true);
            TicketcomboBox.DisplayMember = "PrecioTicket";
            TicketcomboBox.ValueMember = "PrecioTicket";

            Repositorio<Usuario> usuario = new Repositorio<Usuario>(new Contexto());
            UsuarioscomboBox.DataSource = usuario.GetList(c => true);
            UsuarioscomboBox.DisplayMember = "NombreUsuario";
            UsuarioscomboBox.ValueMember = "UsuarioId";
            
            CantidadcomboBox.Items.Clear();
            foreach (var item in BLL.PartidosBLL.GetList(x => true))
            {
                CantidadcomboBox.Items.Add(item.CantidadDisponible);
            }
        }

        private void TotaltextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
