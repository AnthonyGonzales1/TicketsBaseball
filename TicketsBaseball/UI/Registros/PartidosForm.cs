using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.BLL;
using TicketsDeportivos.DAL;

namespace TicketsDeportivos.UI.Registros
{
    public partial class PartidosForm : Form
    {
        public int RowSelected { get; set; }
        List<PartidoDetalle> Detalle = new List<PartidoDetalle>();
        Partido partido = new Partido();
        public PartidosForm()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombrePartidotextBox.Clear();
            LugarPartidotextBox.Clear();
            FechadateTimePicker.ResetText();
            //TipoPartidocomboBox.SelectedIndex = -1;
            CantidadtextBox.Clear();
            TipoPartidocomboBox.Text =string.Empty;
            PreciocomboBox.Text = string.Empty;
            TicketcomboBox.Text = string.Empty;
            DescripcioncomboBox.Text = string.Empty;
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Partido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Partido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Partido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                IderrorProvider.SetError(IdnumericUpDown, "Llenar Partido Id");
                paso = true;
            }
            if (error == 2 && TipoPartidocomboBox.Text == string.Empty)
            {
                errorProvider.SetError(TipoPartidocomboBox,
                   "Debes seleccionar un Tipo de Partido");
                paso = true;
            }
            if (error == 2 && NombrePartidotextBox.Text == string.Empty)
            {
                errorProvider.SetError(NombrePartidotextBox,
                   "Debes ingresar un Nombre");
                paso = true;
            }
            if (error == 2 && LugarPartidotextBox.Text == string.Empty)
            {
                errorProvider.SetError(LugarPartidotextBox,
                    "Debes ingresar un Lugar");
                paso = true;
            }
            
            if (error == 2 && CantidadtextBox.Text == string.Empty)
            {
                errorProvider.SetError(CantidadtextBox,
                    "Debes ingresar una Cantidad");
                paso = true;
            }

            return paso;
        }

        private void LlenarCampos()
        {
            TipoPartidocomboBox.Text = partido.TipoPartidoId.ToString();
            NombrePartidotextBox.Text = partido.NombrePartido.ToString();
            FechadateTimePicker.Value = partido.FechaPartido;
            LugarPartidotextBox.Text = partido.LugarPartido.ToString();
            DescripcioncomboBox.Text = partido.Descripcion.ToString();
            CantidadtextBox.Text = partido.CantidadDisponible.ToString();
            PreciocomboBox.Text = partido.PrecioTicket.ToString();
            TicketcomboBox.Text = partido.TicketId.ToString();
            foreach (var item in partido.Detalle)
            {
                PartidodataGridView.Rows.Add(item.Descripcion, item.CantidadDisponible, item.PrecioTicket);
            }
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        private decimal ToDecimal(object valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor.ToString(), out retorno);
            return retorno;

        }

        private Partido Llenaclase()
        {
            Partido partido = new Partido();
            if (IdnumericUpDown.Value == 0)
            {
                partido.PartidoId = 0;
            }
            else
            {
                partido.PartidoId = Convert.ToInt32(IdnumericUpDown.Value);
            }
                partido.TipoPartidoId = Convert.ToString(TipoPartidocomboBox.Text);
                partido.NombrePartido = NombrePartidotextBox.Text;
                partido.FechaPartido = FechadateTimePicker.Value;
                partido.LugarPartido = LugarPartidotextBox.Text;
                partido.Descripcion = DescripcioncomboBox.Text;
                partido.CantidadDisponible = Convert.ToInt32(CantidadtextBox.Text);
                partido.PrecioTicket = Convert.ToInt32(PreciocomboBox.Text);
                partido.TicketId = Convert.ToInt32(TicketcomboBox.Text);
                
            return partido;
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
                Partido partido = BLL.PartidosBLL.Buscar(id);

                if (partido != null)
                {
                    IdnumericUpDown.Value = partido.PartidoId;
                    TipoPartidocomboBox.Text = partido.TipoPartidoId.ToString();
                    NombrePartidotextBox.Text = partido.NombrePartido.ToString();
                    FechadateTimePicker.Value = partido.FechaPartido;
                    LugarPartidotextBox.Text = partido.LugarPartido.ToString();
                    DescripcioncomboBox.Text = partido.Descripcion.ToString();
                    CantidadtextBox.Text = partido.CantidadDisponible.ToString();
                    PreciocomboBox.Text = partido.PrecioTicket.ToString();
                    TicketcomboBox.Text = partido.TicketId.ToString();

                    PartidodataGridView.DataSource = partido.Detalle;
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
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
                partido = Llenaclase();
                if (IdnumericUpDown.Value == 0)
                {
                    if (BLL.PartidosBLL.Guardar(partido))
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
                    var result = MessageBox.Show("Seguro de Modificar?", "+Partidos",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (BLL.PartidosBLL.Modificar(Llenaclase()))
                        {
                            MessageBox.Show("Modificado!!");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Guardar!!");
                        }
                    }
                }
            }
        }

        private void LlenarComboBox()
        {
            Repositorio<Ticket> ticket = new Repositorio<Ticket>(new Contexto());
            TicketcomboBox.DataSource = ticket.GetList(c => true);
            TicketcomboBox.ValueMember = "TicketId";
            TicketcomboBox.DisplayMember = "TicketId";
            DescripcioncomboBox.DataSource = ticket.GetList(c => true);
            DescripcioncomboBox.ValueMember = "Descripcion";
            DescripcioncomboBox.DisplayMember = "Descripcion";
            PreciocomboBox.DataSource = ticket.GetList(c => true);
            PreciocomboBox.ValueMember = "PrecioTicket";
            PreciocomboBox.DisplayMember = "PrecioTicket";

            Repositorio<TipoPartido> tipoPartido = new Repositorio<TipoPartido>(new Contexto());
            TipoPartidocomboBox.DataSource = tipoPartido.GetList(c => true);
            TipoPartidocomboBox.ValueMember = "TipoPartidoId";
            TipoPartidocomboBox.DisplayMember = "Descripcion";

        }

        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            List<PartidoDetalle> partidoDetalles = new List<PartidoDetalle>();
            if (Validar(2))
            {
                MessageBox.Show("Llene los Campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }/*
            if (PreciocomboBox.Text == string.Empty || TicketcomboBox.Text == string.Empty ||DescripcioncomboBox.Text == string.Empty)
            {
                partido.Detalle.Add(new PartidoDetalle
                        (Convert.ToInt32(TicketcomboBox.Text),
                        Convert.ToInt32(TicketcomboBox.Text),
                        DescripcioncomboBox.Text,
                        Convert.ToInt32(CantidadtextBox.Text),
                        Convert.ToInt32(PreciocomboBox.Text)

                    ));
            }*/
            else
            {
                partido.Detalle.Add(new PartidoDetalle
                        (Convert.ToInt32(TicketcomboBox.Text),
                        Convert.ToInt32(TicketcomboBox.Text),
                        DescripcioncomboBox.Text,
                        Convert.ToInt32(CantidadtextBox.Text),
                        Convert.ToInt32(PreciocomboBox.Text)

                    ));

                //Cargar el detalle al Grid
                PartidodataGridView.DataSource = null;
                PartidodataGridView.DataSource = partido.Detalle;
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Llenar campos Vacios");
                return;
            }
            var result = MessageBox.Show("Seguro de  Eliminar?", "+Partidos",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (BLL.PartidosBLL.Eliminar(Convert.ToInt32(IdnumericUpDown.Value)))
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

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Eliminar el detalle seleccionado?", "+Partidos",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (RowSelected >= 0)
                {
                    PartidoDetalle partidoDetalle = partido.Detalle.ElementAt(RowSelected);
                    Detalle.Add(new PartidoDetalle(partido.PartidoId, partido.TicketId, partido.Descripcion, partido.CantidadDisponible , partido.PrecioTicket));
                    partido.Detalle.RemoveAt(RowSelected);
                    PartidodataGridView.DataSource = null;
                    PartidodataGridView.DataSource = partido.Detalle;
                    RowSelected = -1;
                    MessageBox.Show("Eliminado!");
                }
            }
        }

        private void CantidadtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
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
    }
}
