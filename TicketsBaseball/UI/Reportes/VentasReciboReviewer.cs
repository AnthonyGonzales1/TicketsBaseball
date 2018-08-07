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
    public partial class VentasReciboReviewer : Form
    {
        private List<Venta> ventas = new List<Venta>();
        public VentasReciboReviewer(List<Venta> lista)
        {
            InitializeComponent();
            this.ventas = lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            VentasReciboCrystalReport1 report = new VentasReciboCrystalReport1();
            report.SetDataSource(ventas);
            VentasReciboCrystalReportViewer.ReportSource = report;
            report.Refresh();
        }
    }
}
