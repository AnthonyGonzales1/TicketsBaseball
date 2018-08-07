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
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            ticket = LlenaClase();

            if (Validar(2))
            {
                MessageBox.Show("Favor de llenar las Casillas");
            }
            else
            {
                if (IdnumericUpDown.Value == 0)
                {
                    paso = BLL.TicketBLL.Guardar(ticket);
                }
                else
                {
                    var result = MessageBox.Show("Seguro de Modificar?", "+Ventas",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (BLL.TicketBLL.Modificar(LlenaClase()))
                        {
                            MessageBox.Show("Modificado!!");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Guardar!!");
                        }
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                if (BLL.TicketBLL.Eliminar(id))
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

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            PreciotextBox.Clear();
            DescripciontextBox.Clear();
            TipoPartidocomboBox.Text=string.Empty;
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
        
        private Ticket LlenaClase()
        {
            Ticket ticket = new Ticket();
            if (ticket.TicketId == 0)
            {
                ticket.TicketId = 0;
            }
            else
            {
                ticket.TicketId = Convert.ToInt32(ticket.TicketId);

            }
            ticket.PrecioTicket = Convert.ToInt32(PreciotextBox.Text);
            ticket.Descripcion = DescripciontextBox.Text;

            return ticket;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
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
                    DescripciontextBox.Text = ticket.Descripcion.ToString();
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }
        
        private void TicketForm_Load(object sender, EventArgs e)
        {
            TipoPartidocomboBox.Items.Clear();
            foreach (var item in BLL.TipoPartidosBLL.GetList(x => true))
            {
                TipoPartidocomboBox.Items.Add(item.Descripcion);
            }
        }
    }
}
