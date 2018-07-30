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
    public partial class TipoPartidoReviewer : Form
    {
        private List<TipoPartido> tipoPartidos = new List<TipoPartido>();
        public TipoPartidoReviewer(List<TipoPartido> lista)
        {
            InitializeComponent();
            this.tipoPartidos = lista;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            TipoPartidoCrystalReport1 report = new TipoPartidoCrystalReport1();
            report.SetDataSource(tipoPartidos);
            TipoPartidoCrystalReportViewer.ReportSource = report;
            report.Refresh();
        }
    }
}
