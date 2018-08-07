using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketsDeportivos.Entidades;

namespace TicketsDeportivos.UI.Reportes
{
    public partial class TicketsReviewer : Form
    {
        private List<Ticket> tickets = new List<Ticket>();
        public TicketsReviewer(List<Ticket> lista)
        {
            InitializeComponent();
            this.tickets = lista;
        }

        private void PartidoCrystalReportViewer_Load(object sender, EventArgs e)
        {
            TicketsCrystalReport1 report = new TicketsCrystalReport1();
            report.SetDataSource(tickets);
            TicketsCrystalReportViewer.ReportSource = report;
            report.Refresh();
        }
    }
}
