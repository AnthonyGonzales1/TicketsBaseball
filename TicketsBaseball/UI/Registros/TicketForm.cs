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
    public partial class TicketForm : Form
    {
        Ticket ticket = new Ticket();
        public TicketForm()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Ticket LlenaClase()
        {
            Ticket ticket = new Ticket();
            if (IdnumericUpDown.Value == 0)
            {
                ticket.TicketId = 0;
            }
            else
            {
                ticket.TicketId = Convert.ToInt32(IdnumericUpDown.Value);
            }

            ticket.PrecioTicket = Convert.ToInt32(PreciotextBox.Text);
            ticket.TipoPartidoId = Convert.ToString(TipoPartidocomboBox.Text);
            ticket.Descripcion = DescripciontextBox.Text;

            return ticket;
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
                ticket = LlenaClase();
                if (IdnumericUpDown.Value == 0)
                {
                    if (BLL.TicketBLL.Guardar(ticket))
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
                    var result = MessageBox.Show("Seguro de Modificar?", "+Tickets",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (BLL.TicketBLL.Modificar(LlenaClase()))
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de llenar casilla para poder Eliminar");
            }
            var result = MessageBox.Show("Seguro de  Eliminar?", "+Tickets",
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

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            PreciotextBox.Clear();
            DescripciontextBox.Clear();
            TipoPartidocomboBox.SelectedText = string.Empty;
        }

        private bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                errorProvider.SetError(IdnumericUpDown,
                   "Debe introducir un Id");
                paso = true;
            }

            if (error == 2 && PreciotextBox.Text == string.Empty)
            {
                errorProvider.SetError(PreciotextBox,
                   "Debe ingresar un Precio");
                paso = true;
            }

            if (error == 2 && DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox,
                   "Debe ingresar una Descripcion");
                paso = true;
            }

            return paso;
        }
        
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            TipoPartido tipo = new TipoPartido();
            if (Validar(1))
            {
                MessageBox.Show("Favor de llenar la casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                ticket = BLL.TicketBLL.Buscar(id);

                if (ticket != null)
                {
                    IdnumericUpDown.Value = ticket.TicketId;
                    PreciotextBox.Text = ticket.PrecioTicket.ToString();
                    TipoPartidocomboBox.Text = ticket.TipoPartidoId.ToString();
                    DescripciontextBox.Text = ticket.Descripcion.ToString();
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

        private void LlenarComboBox()
        {
            Repositorio<TipoPartido> tipoPartido = new Repositorio<TipoPartido>(new Contexto());
            TipoPartidocomboBox.DataSource = tipoPartido.GetList(c => true);
            TipoPartidocomboBox.ValueMember = "TipoPartidoId";
            TipoPartidocomboBox.DisplayMember = "Descripcion";
        }

        private void PreciotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(PreciotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
        }
    }
}
