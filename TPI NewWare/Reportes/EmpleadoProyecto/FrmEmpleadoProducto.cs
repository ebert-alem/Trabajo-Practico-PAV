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

namespace TPI_NewWare.Reportes.EmpleadoProyecto
{
    public partial class FrmEmpleadoProducto : Form
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();
        private Ng_EmpleadoProyecto negocio = new Ng_EmpleadoProyecto();
        public FrmEmpleadoProducto()
        {
            InitializeComponent();
        }
        private void EmpleadoProducto_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
            this.cmb_proyecto.Cargar();

        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            DataTable table = negocio.ConsultaFiltrada(Convert.ToString(cmb_proyecto.SelectedValue));

            ReportDataSource ds = new ReportDataSource("HorasEmpleado", table);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(ds);
            reportViewer.RefreshReport();
        }
    }
}
