using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Entidades;
using Microsoft.Reporting.WinForms;
using TPI_NewWare.Clases;
using TPI_NewWare.Negocio;

namespace TPI_NewWare.Reportes.HorasEmpleado
{
    public partial class FrmHorasEmpleado : Form
    {
        private Ng_HorasEmpleado negocio = new Ng_HorasEmpleado();

        public FrmHorasEmpleado()
        {
            InitializeComponent();
        }

        private void FrmHorasEmpleado_Load(object sender, EventArgs e)
        {
            this.cmb_proyecto.Cargar();
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            DataTable table = negocio.ConsultaFiltrada(Convert.ToString(cmb_proyecto.SelectedValue), dtpDesde.Value, dtpHasta.Value);

            ReportDataSource ds = new ReportDataSource("HorasEmpleado", table);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(ds);
            reportViewer.RefreshReport();
        }
    }
}
