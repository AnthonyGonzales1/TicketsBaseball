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

namespace TicketsDeportivos.UI.Registros
{
    public partial class VentasForm : Form
    {
        Expression<Func<Venta, bool>> filtrar = x => true;
        public int RowSelected { get; set; }
        List<VentaDetalle> Detalle = new List<VentaDetalle>();
        Venta venta = new Venta();
        public VentasForm()
        {
            InitializeComponent();
            LlenarComboBox();
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
            IdnumericUpDown.Value = 0;
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
            if (IdnumericUpDown.Value == 0)
            {
                venta.VentaId = 0;
            }
            else
            {
                venta.VentaId = Convert.ToInt32(IdnumericUpDown.Value);
            }
            venta.UsuarioId = Convert.ToString(UsuarioscomboBox.Text);
            venta.Fecha = FechadateTimePicker.Value;
            venta.CantidadDisponible = Convert.ToInt32(CantidadcomboBox.Text);
            venta.Descripcion = DescripcionrichTextBox.Text;
            venta.PartidoId = Convert.ToString(PartidocomboBox.Text);
            venta.Ticket = Convert.ToInt32(TicketcomboBox.Text);
            venta.Total = Convert.ToInt32(TotaltextBox.CanSelect);
            int precio = 0;
            int cantidad = 0;
            int.TryParse(TicketcomboBox.SelectedValue.ToString(), out precio);
            int.TryParse(CantidadcomboBox.Text, out cantidad);
            if (CantidadcomboBox.Text.Length > 0)
            {
                TotaltextBox.Text = (precio * cantidad).ToString();
                List<VentaDetalle> ventaDetalles = new List<VentaDetalle>();
            }

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

            if (error == 2 && PartidocomboBox.Text == string.Empty)
            {
                errorProvider.SetError(PartidocomboBox,
                   "Debes seleccionar un Partido");
                paso = true;
            }
            if (error == 2 && TicketcomboBox.Text == string.Empty)
            {
                errorProvider.SetError(TicketcomboBox,
                   "Debes seleccionar un Ticket");
                paso = true;
            }

            if (error == 2 && CantidadcomboBox.Text == string.Empty)
            {
                errorProvider.SetError(CantidadcomboBox,
                    "Debes ingresar una Cantidad");
                paso = true;
            }

            if (error == 2 && DescripcionrichTextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripcionrichTextBox,
                    "Debes ingresar una Descripcion");
                paso = true;
            }

            return paso;
        }

        private void LlenarCampos()
        {
            UsuarioscomboBox.Text = venta.UsuarioId.ToString();
            FechadateTimePicker.Text = venta.Fecha.ToString();
            PartidocomboBox.Text = venta.PartidoId.ToString();
            TicketcomboBox.Text = venta.Ticket.ToString();
            CantidadcomboBox.Text = venta.CantidadDisponible.ToString();
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
                errorProvider.Clear();
            }
            var result = MessageBox.Show("Seguro de  Eliminar?", "+Ventas",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (BLL.VentasBLL.Eliminar(Convert.ToInt32(IdnumericUpDown.Value)))
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
                    FechadateTimePicker.Value = venta.Fecha;
                    PartidocomboBox.Text = venta.PartidoId.ToString();
                    TicketcomboBox.Text = venta.Ticket.ToString();
                    CantidadcomboBox.Text = venta.CantidadDisponible.ToString();
                    DescripcionrichTextBox.Text = venta.Descripcion.ToString();
                    TotaltextBox.Text = venta.Total.ToString();
                    int precio = 0;
                    int cantidad = 0;
                    int.TryParse(TicketcomboBox.SelectedValue.ToString(), out precio);
                    int.TryParse(CantidadcomboBox.Text, out cantidad);
                    if (CantidadcomboBox.Text.Length > 0)
                    {
                        TotaltextBox.Text = (precio * cantidad).ToString();
                        List<VentaDetalle> ventaDetalles = new List<VentaDetalle>();
                    }
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("Llenar Campos vacios");
                errorProvider.Clear();
                return;
            }
            else
            {
                venta = LlenaClase();
                if (IdnumericUpDown.Value == 0)
                {
                    int precio = 0;
                    int cantidad = 0;
                    int.TryParse(TicketcomboBox.SelectedValue.ToString(), out precio);
                    int.TryParse(CantidadcomboBox.Text, out cantidad);
                    if (CantidadcomboBox.Text.Length > 0)
                    {
                        TotaltextBox.Text = (precio * cantidad).ToString();
                        List<VentaDetalle> ventaDetalles = new List<VentaDetalle>();
                    }
                    if (BLL.VentasBLL.Guardar(venta))
                    {
                        MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar!!");
                    }
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
                            Limpiar();
                        }
                    }
                }
            }
        }
        private void Imprimirbutton_Click_1(object sender, EventArgs e)
        {
            Reportes.VentasReciboReviewer ven = new Reportes.VentasReciboReviewer(BLL.VentasBLL.GetList(filtrar));
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


        private void LlenarComboBox()
        {
            Repositorio<Partido> partido = new Repositorio<Partido>(new Contexto());
            PartidocomboBox.DataSource = partido.GetList(c => true);
            PartidocomboBox.ValueMember = "PartidoId";
            PartidocomboBox.DisplayMember = "NombrePartido";
            CantidadcomboBox.DataSource = partido.GetList(c => true);
            CantidadcomboBox.ValueMember = "CantidadDisponible";
            CantidadcomboBox.DisplayMember = "CantidadDisponible";

            Repositorio<Ticket> ticket = new Repositorio<Ticket>(new Contexto());
            TicketcomboBox.DataSource = ticket.GetList(c => true);
            TicketcomboBox.ValueMember = "PrecioTicket";
            TicketcomboBox.DisplayMember = "PrecioTicket";

            Repositorio<Usuario> usuario = new Repositorio<Usuario>(new Contexto());
            UsuarioscomboBox.DataSource = usuario.GetList(c => true);
            UsuarioscomboBox.ValueMember = "UsuarioId";
            UsuarioscomboBox.DisplayMember = "NombreUsuario";
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Eliminar el detalle seleccionado?", "+Partidos",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (RowSelected >= 0)
                {
                    VentaDetalle ventaDetalle = venta.Detalle.ElementAt(RowSelected);
                    Detalle.Add(new VentaDetalle(venta.UsuarioId, venta.PartidoId, venta.Ticket, venta.Total, venta.Fecha));
                    venta.Detalle.RemoveAt(RowSelected);
                    VentadataGridView.DataSource = null;
                    VentadataGridView.DataSource = venta.Detalle;
                    RowSelected = -1;
                    MessageBox.Show("Eliminado!");
                }
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            int precio = 0;
            int cantidad = 0;
            int.TryParse(TicketcomboBox.SelectedValue.ToString(), out precio);
            int.TryParse(CantidadcomboBox.Text, out cantidad);
            if (CantidadcomboBox.Text.Length > 0)
            {
                TotaltextBox.Text = (precio * cantidad).ToString();
                List<VentaDetalle> ventaDetalles = new List<VentaDetalle>();
            }
            if (Validar(2))
            {
                MessageBox.Show("Llene los Campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }/*
            if (UsuarioscomboBox.Text == string.Empty || TicketcomboBox.Text == string.Empty || PartidocomboBox.Text == string.Empty || TotaltextBox.Text == string.Empty)
            {
                venta.Detalle.Add(new VentaDetalle
                        (Convert.ToString(UsuarioscomboBox.Text),
                        Convert.ToString(PartidocomboBox.Text),
                        Convert.ToInt32(TicketcomboBox.Text),
                        Convert.ToInt32(TotaltextBox.Text),
                        Convert.ToDateTime(FechadateTimePicker.Text)
                    ));
            }*/
            else
            {
                venta.Detalle.Add(new VentaDetalle
                        (Convert.ToString(UsuarioscomboBox.Text),
                        Convert.ToString(PartidocomboBox.Text),
                        Convert.ToInt32(TicketcomboBox.Text),
                        Convert.ToInt32(TotaltextBox.Text),
                        Convert.ToDateTime(FechadateTimePicker.Text)
                    ));

                //Cargar el detalle al Grid
                VentadataGridView.DataSource = null;
                VentadataGridView.DataSource = venta.Detalle;
            }
        }
    }
}
