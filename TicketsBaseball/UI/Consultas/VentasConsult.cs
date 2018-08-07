using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.UI.Reportes;

namespace TicketsDeportivos.UI.Consultas
{
    public partial class VentasConsult : Form
    {
        Venta venta = new Venta();
        Expression<Func<Venta, bool>> filtrar = x => true;
        public VentasConsult()
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

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriotextBox.ReadOnly = true;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            int id;
            decimal valor = 0;

            if (FiltrocomboBox.Text == string.Empty && FechaPartidocheckBox.Checked == true)
            {
                filtrar = t => true && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
            }
            else
            {
                filtrar = t => true;
            }

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
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.VentaId == id && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.VentaId == id;
                    }

                    break;
                //TipoPartidoId
                case 1:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    id = int.Parse(CriteriotextBox.Text);
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.UsuarioId == id && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.UsuarioId == id;
                    }

                    break;
                //Nombre
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.Ticket == Convert.ToInt32(CriteriotextBox.Text) && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.Ticket == Convert.ToInt32(CriteriotextBox.Text);
                    }

                    break;
                //Lugar
                case 3:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.Cantidad == Convert.ToInt32(CriteriotextBox.Text) && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.Cantidad == Convert.ToInt32(CriteriotextBox.Text);
                    }

                    break;
                //Descripcion
                case 4:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text) && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text);
                    }

                    break;
                //Cantidad
                case 6:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;
                    }

                    valor = Convert.ToDecimal(CriteriotextBox.Text);
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.Total == valor && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.Total == valor;
                    }

                    break;
            }
            VentasdataGridView.DataSource = BLL.VentasBLL.GetList(filtrar);
            CantidadtextBox.Text = VentasdataGridView.RowCount.ToString();

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

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            VentasReviewer ventasReviewer = new VentasReviewer(BLL.VentasBLL.GetList(filtrar));
            {
                ventasReviewer.Show();
            }

        }

        private void VentasConsult_Load(object sender, EventArgs e)
        {
            CriteriotextBox.ReadOnly = true;
        }
    }
}
