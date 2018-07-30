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
    public partial class VentasReviewer : Form
    {
        private List<Venta> ventas = new List<Venta>();
        public VentasReviewer(List<Venta> lista)
        {
            InitializeComponent();
            this.ventas = lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            VentasCrystalReport1 report = new VentasCrystalReport1();
            report.SetDataSource(ventas);
            VentasCrystalReportViewer.ReportSource = report;
            report.Refresh();
        }
    }
}
