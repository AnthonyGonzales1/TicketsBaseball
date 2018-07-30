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

namespace TicketsDeportivos.UI.Consultas
{
    public partial class TipoPartidoConsult : Form
    {
        TipoPartido tipoPartido = new TipoPartido();
        Expression<Func<Partido, bool>> filtrar = x => true;
        public TipoPartidoConsult()
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
            Expression<Func<TipoPartido, bool>> filtrar = x => true;

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
                    filtrar = t => t.TipoPartidoId == id;
                    break;
                //Descripcion
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text);
                    break;
            }
            TipoPartidodataGridView.DataSource = BLL.TipoPartidosBLL.GetList(filtrar);
            CantidadtextBox.Text = TipoPartidodataGridView.RowCount.ToString();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {/*
            ReporteProducto abri = new ReporteProducto(BLL.ProductoBLL.GetList(filtrar));
            abri.Show();*/
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriotextBox.Clear();
            LimpiarError();
            if (FiltrocomboBox.SelectedIndex == 5)
            {
                CriteriotextBox.Enabled = false;

            }
            else
            {
                CriteriotextBox.Enabled = true;
            }
        }

        private void CriteriotextBox_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
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

        private void TipoPartidoConsult_Load(object sender, EventArgs e)
        {
            CriteriotextBox.ReadOnly = true;
        }
    }
}
