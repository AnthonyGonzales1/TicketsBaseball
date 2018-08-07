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
using TicketsDeportivos.BLL;
using TicketsDeportivos.UI.Reportes;

namespace TicketsDeportivos.UI.Consultas
{
    public partial class PartidoConsult : Form
    {
        List<Partido> partidos = new List<Partido>();
        Partido partido = new Partido();
        Expression<Func<Partido, bool>> filtrar = x => true;
        public PartidoConsult()
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
            decimal valor = 0;

            if (FiltrocomboBox.Text == string.Empty && FechaPartidocheckBox.Checked == true)
            {
                filtrar = t => true && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
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
                        filtrar = t => t.PartidoId == id && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.PartidoId == id;
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
                        filtrar = t => t.TipoPartidoId == id && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.TipoPartidoId == id;
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
                        filtrar = t => t.NombrePartido.Contains(CriteriotextBox.Text) && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.NombrePartido.Contains(CriteriotextBox.Text);
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
                        filtrar = t => t.LugarPartido.Contains(CriteriotextBox.Text) && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.LugarPartido.Contains(CriteriotextBox.Text);
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
                        filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text) && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
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

                    valor = Convert.ToInt32(CriteriotextBox.Text);
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.CantidadDisponible == Convert.ToInt32(CriteriotextBox.Text) && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.CantidadDisponible == Convert.ToInt32(CriteriotextBox.Text);
                    }

                    break;
                //Precio
                case 7:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;
                    }
                    valor = Convert.ToDecimal(CriteriotextBox.Text);
                    if (FechaPartidocheckBox.Checked == true)
                    {
                        filtrar = t => t.PrecioTicket == valor && (t.FechaPartido.Day >= DesdedateTimePicker.Value.Day) && (t.FechaPartido.Month >= DesdedateTimePicker.Value.Month) && (t.FechaPartido.Year >= DesdedateTimePicker.Value.Year) && (t.FechaPartido.Day <= HastadateTimePicker.Value.Day) && (t.FechaPartido.Month <= HastadateTimePicker.Value.Month) && (t.FechaPartido.Year <= HastadateTimePicker.Value.Year);
                    }
                    else
                    {
                        filtrar = t => t.PrecioTicket == valor;
                    }

                    break;
            }
            partidos = BLL.PartidosBLL.GetList(filtrar);
            PartidodataGridView.DataSource = partidos;
            CanttextBox.Text = PartidodataGridView.RowCount.ToString();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            PartidoReviewer partidoReviewer = new PartidoReviewer(BLL.PartidosBLL.GetList(filtrar));
            {
                partidoReviewer.Show();
            }
        }

        private void CanttextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
