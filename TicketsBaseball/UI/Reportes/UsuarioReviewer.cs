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
    public partial class UsuarioReviewer : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public UsuarioReviewer(List<Usuario> lista)
        {
            InitializeComponent();
            this.usuarios = lista;
        }
        
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            UsuarioCrystalReport1 report = new UsuarioCrystalReport1();
            report.SetDataSource(usuarios);
            UsuarioCrystalReportViewer.ReportSource = report;
            report.Refresh();
        }
    }
}
