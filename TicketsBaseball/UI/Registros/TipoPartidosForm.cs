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
    public partial class TipoPartidosForm : Form
    {
        TipoPartido tipoPartido;
        public TipoPartidosForm()
        {
            InitializeComponent();
        }
        private void DescripciontextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 46) || (e.KeyChar == 44) || (e.KeyChar == 32) || (e.KeyChar == 13))
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
                Guardarbutton.Focus();
            }
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
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
            if (error == 2 && DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox,
                   "Debe ingresar una Descripcion");
                paso = true;
            }

            return paso;
        }

        private void LlenarCampos()
        {
            DescripciontextBox.Text = tipoPartido.Descripcion.ToString();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Partidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Partidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Partidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private TipoPartido LlenaClase()
        {
            TipoPartido tipoPartido =new TipoPartido();
            if (IdnumericUpDown.Value == 0)
            {
                tipoPartido.TipoPartidoId = 0;
            }
            else
            {
                tipoPartido.TipoPartidoId = Convert.ToInt32(IdnumericUpDown.Value);

            }
            tipoPartido.Descripcion = DescripciontextBox.Text;

            return tipoPartido;
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
                tipoPartido = BLL.TipoPartidosBLL.Buscar(id);

                if (tipoPartido != null)
                {
                    IdnumericUpDown.Value = tipoPartido.TipoPartidoId;
                    DescripciontextBox.Text = tipoPartido.Descripcion.ToString();
                   
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
            if (Validar(2))
            {
                MessageBox.Show("Llenar Campos vacios");
                errorProvider.Clear();
                return;
            }
            else
            {
                tipoPartido = LlenaClase();
                if (IdnumericUpDown.Value == 0)
                {
                    if (BLL.TipoPartidosBLL.Guardar(tipoPartido))
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
                    var result = MessageBox.Show("Seguro de Modificar?", "+TipoPartidos",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (BLL.TipoPartidosBLL.Modificar(LlenaClase()))
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
                Limpiar();
                errorProvider.Clear();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de llenar casilla para poder Eliminar");
            }
            var result = MessageBox.Show("Seguro de  Eliminar?", "+Tipo de Partidos",
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
    }
}
