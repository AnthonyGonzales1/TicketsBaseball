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
using TicketsDeportivos.BLL;
using TicketsDeportivos.Entidades;
using System.Linq.Expressions;

namespace TicketsDeportivos
{
    public partial class PrincipalForm : Form
    {
        Expression<Func<Venta, bool>> filtrar = x => true;
        Expression<Func<Partido, bool>> filtrar1 = x => true;
        Expression<Func<TipoPartido, bool>> filtrar2 = x => true;
        Expression<Func<Usuario, bool>> filtrar3 = x => true;
        Expression<Func<Ticket, bool>> filtrar4 = x => true;
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
            UsuarioReviewer usuarioReviewer = new UsuarioReviewer(BLL.UsuarioBLL.GetList(filtrar3));
            {
                usuarioReviewer.Show();
            }
        }

        private void ReporteTipoPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoPartidoReviewer tipoPartidoReviewer = new TipoPartidoReviewer(BLL.TipoPartidosBLL.GetList(filtrar2));
            {
                tipoPartidoReviewer.Show();
            }
        }

        private void ReportePartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartidoReviewer partidoReviewer = new PartidoReviewer(BLL.PartidosBLL.GetList(filtrar1));
            {
                partidoReviewer.Show();
            }
        }

        private void ReporteVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentasReviewer ventasReviewer = new VentasReviewer(BLL.VentasBLL.GetList(filtrar));
            {
                ventasReviewer.Show();
            }
        }

        private void RegistroPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartidosForm partidosForm = new PartidosForm();
            partidosForm.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsDeportivos.About about = new TicketsDeportivos.About();
            about.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketForm ticket =new TicketForm();
            ticket.Show();
        }

        private void ticketsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicketsConsult ticketsConsult = new TicketsConsult();
            ticketsConsult.Show();
        }

        private void ticketsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TicketsReviewer ticketsReviewer = new TicketsReviewer(BLL.TicketBLL.GetList(filtrar4));
            {
                ticketsReviewer.Show();
            }
        }

        private void reciboDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasReciboReviewer ventasReciboReviewer=new VentasReciboReviewer(BLL.VentasBLL.GetList(filtrar));
            {
                ventasReciboReviewer.Show();
            }
        }
    }
}
