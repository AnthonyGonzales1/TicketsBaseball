using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketsDeportivos.UI.Registros;
using TicketsDeportivos.UI.Consultas;
using TicketsDeportivos.UI.Reportes;

namespace TicketsDeportivos
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void RegistroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuarios = new UsuariosForm();
            usuarios.Show();
        }

        private void RegistroTipoPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoPartidosForm tipoPartidosForm = new TipoPartidosForm();
            tipoPartidosForm.Show();
        }

        private void RegistroPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartidosForm partidosForm = new PartidosForm();
            partidosForm.Show();
        }

        private void RegistroVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasForm ventasForm = new VentasForm();
            ventasForm.Show();
        }

        private void ConsultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioConsult usuarioConsult = new UsuarioConsult();
            usuarioConsult.Show();
        }
       
        private void ConsultaTipoPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoPartidoConsult tipoPartidoConsult = new TipoPartidoConsult();
            tipoPartidoConsult.Show();
        }

        private void ConsultaPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartidoConsult partidoConsult = new PartidoConsult();
            partidoConsult.Show();
        }

        private void ConsultaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasConsult ventasConsult = new VentasConsult();
            ventasConsult.Show();
        }

        private void ReporteUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReporteTipoPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReportePartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReporteVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
