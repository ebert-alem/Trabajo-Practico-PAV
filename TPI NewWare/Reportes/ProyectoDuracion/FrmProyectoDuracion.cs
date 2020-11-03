using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TPI_NewWare.Clases;
using TPI_NewWare.Negocio;

namespace TPI_NewWare.Reportes.EmpleadoProyecto
{
    public partial class FrmProyectoDuracion : Form
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();
        private Ng_ProyectoDuracion negocio = new Ng_ProyectoDuracion();

        public FrmProyectoDuracion()
        {
            InitializeComponent();
        }

        private void FrmProyectoDuracion_Load(object sender, EventArgs e)
        {

        //    this.reportViewer1.RefreshReport();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            DataTable table = negocio.Consulta();
            ReportDataSource ds = new ReportDataSource("proyectosTerminados", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            DataTable table = negocio.ConsultaFiltrada(dtpDesde.Value, dtpHasta.Value);

            ReportDataSource ds = new ReportDataSource("proyectosTerminados", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}
