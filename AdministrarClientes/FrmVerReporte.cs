using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bl;

namespace AdministrarClientes
{
    public partial class FrmVerReporte : Form
    {
        private clClienteBl clienteBl = new clClienteBl();

        public int idCliente;
        public FrmVerReporte(int idCliente) {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private void FrmVerReporte_Load(object sender, EventArgs e) {           
           
            ReporteClientes reporte = new ReporteClientes();           
            reporte.SetParameterValue("@idCliente", idCliente);           
            
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
        }
    }
}
