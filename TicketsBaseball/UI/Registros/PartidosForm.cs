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
        Partido partido = new Partido();
        public PartidosForm()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        private void LlenarComboBox()
        {
            Contexto contexto = new Contexto();

            Repositorio<TipoPartido> tipoPartido = new Repositorio<TipoPartido>(new Contexto());
            TipoPartidocomboBox.DataSource = tipoPartido.GetList(c => true);
            TipoPartidocomboBox.DisplayMember = "Descripcion";
            TipoPartidocomboBox.ValueMember = "TipoPartidoId";

            Eliminarbutton.Enabled = false;
        }

        private void Limpiar()
        {
            NombrePartidotextBox.Clear();
            LugarPartidotextBox.Clear();
            FechadateTimePicker.ResetText();
            PartidodataGridView.Rows.Clear();
            //TipoPartidocomboBox.SelectedIndex = -1;
            DescripciontextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
            TipoPartidocomboBox.ResetText();
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
                errorProvider.SetError(IdnumericUpDown, "Llenar Partido Id");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(TipoPartidocomboBox.Text))
            {
                errorProvider.SetError(TipoPartidocomboBox,
                   "Debes seleccionar un Tipo de Partido");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(NombrePartidotextBox.Text))
            {
                errorProvider.SetError(NombrePartidotextBox,
                   "Debes ingresar un Nombre");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(FechadateTimePicker.Text))
            {
                errorProvider.SetError(FechadateTimePicker,
                   "Debes ingresar una Fecha");
                paso = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(LugarPartidotextBox.Text))
            {
                errorProvider.SetError(LugarPartidotextBox,
                    "Debes ingresar un Lugar");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox,
                    "Debes ingresar una Descripcion");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                errorProvider.SetError(CantidadtextBox,
                    "Debes ingresar una Cantidad");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(PreciotextBox.Text))
            {
                errorProvider.SetError(PreciotextBox,
                    "Debes ingresar un Precio");
                paso = true;
            }
            if (PartidodataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in PartidodataGridView.Rows)
                {
                    partido.AgregarTickets(item.Cells["Descripcion"].Value.ToString(), (int)item.Cells["Cantidad"].Value, (int)item.Cells["Precio"].Value);
                }
            }
            else
            {
                MensajeError("Error al guardar debido a que no agrego Tickets!");
                paso = true;
            }

            return paso;
        }

        private void LlenarCampos()
        {
            TipoPartidocomboBox.Text = partido.TipoPartidoId.ToString();
            NombrePartidotextBox.Text = partido.TipoPartidoId.ToString();
            FechadateTimePicker.Text = partido.Fecha.ToString();
            LugarPartidotextBox.Text = partido.Lugar.ToString();
            foreach (var item in partido.Detalle)
            {
                PartidodataGridView.Rows.Add(item.Descripcion, item.Cantidad, item.Precio);
            }
        }

        private Partido Llenaclase()
        {
            Partido partido = new Partido();

            CantidadtextBox.Text = 0.ToString();
            partido.PartidoId = Convert.ToInt32(IdnumericUpDown.Value);
            partido.TipoPartidoId = Convert.ToInt32(TipoPartidocomboBox.Text);
            partido.Nombre = NombrePartidotextBox.Text;
            partido.Fecha = FechadateTimePicker.Value;
            partido.Lugar = LugarPartidotextBox.Text;
            partido.Descripcion = DescripciontextBox.Text;
            partido.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            partido.Precio = Convert.ToDecimal(PreciotextBox.Text);

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
                Partido partido = BLL.PartidoBLL.Buscar(id);

                if (partido != null)
                {
                    IdnumericUpDown.Value = partido.PartidoId;
                    TipoPartidocomboBox.Text = partido.TipoPartidoId.ToString();
                    NombrePartidotextBox.Text = partido.Nombre.ToString();
                    FechadateTimePicker.Text = partido.Fecha.ToString();
                    LugarPartidotextBox.Text = partido.Lugar.ToString();
                    DescripciontextBox.Text = partido.Descripcion.ToString();
                    CantidadtextBox.Text = partido.Cantidad.ToString();
                    PreciotextBox.Text = partido.Precio.ToString();

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
            Eliminarbutton.Enabled = false;
            errorProvider.Clear();
            Limpiar();
            Guardarbutton.Text = "Guardar";
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Partido partido = Llenaclase();


            if (Validar(2))
            {
                MessageBox.Show("Favor de llenar las Casillas");
            }
            else
            {
                if (IdnumericUpDown.Value == 0)
                {
                    paso = BLL.PartidoBLL.Guardar(partido);
                }
                else
                {
                    var partidos = BLL.PartidoBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));

                    if (partidos != null)
                    {
                        paso = BLL.PartidoBLL.Modificar(partido);
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

                if (BLL.PartidoBLL.Eliminar(id))
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

        private void PartidosForm_Load(object sender, EventArgs e)
        {

        }

        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            int cant = 0;
            int pre = 0;
            int.TryParse(CantidadtextBox.Text, out cant);
            int.TryParse(PreciotextBox.Text, out pre);

            if (!DescripciontextBox.Text.Equals("") && !CantidadtextBox.Text.Equals("") && !PreciotextBox.Text.Equals(""))
            {
                PartidodataGridView.Rows.Add(DescripciontextBox.Text, cant, pre);
                DescripciontextBox.Clear();
                CantidadtextBox.Clear();
                PreciotextBox.Clear();
            }
            else
            {
                MensajeError("Error al agregar debido a que hay campos vacios!!!");
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

        private void DescripciontextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(DescripciontextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                CantidadtextBox.Focus();
            }
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
            if (e.KeyChar == 13)
            {
                Agregarbutton.Focus();
            }
        }

        private void NombrePartidotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(NombrePartidotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                FechadateTimePicker.Focus();
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
            if (e.KeyChar == 13)
            {
                PreciotextBox.Focus();
            }
        }

        
        private void LugarPartidotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(LugarPartidotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                DescripciontextBox.Focus();
            }
        }
        
    }
}
