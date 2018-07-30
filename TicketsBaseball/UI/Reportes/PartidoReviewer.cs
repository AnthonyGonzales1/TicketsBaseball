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
    public partial class PartidoReviewer : Form
    {
        private List<Partido> partidos = new List<Partido>();

        public PartidoReviewer(List<Partido> lista)
        {
            InitializeComponent();
            this.partidos = lista;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            PartidoCrystalReport report = new PartidoCrystalReport();
            report.SetDataSource(partidos);
            PartidoCrystalReportViewer.ReportSource = report;
            report.Refresh();

        }
    }
}
