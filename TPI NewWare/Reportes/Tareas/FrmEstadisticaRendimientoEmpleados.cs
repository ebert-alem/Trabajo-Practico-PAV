using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Clases;
using Microsoft.Reporting.WinForms;
using TPI_NewWare.Negocio;

namespace TPI_NewWare.Reportes.EmpleadoProyecto
{
    public partial class FrmEstadisticaRendimientoEmpleados : Form
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();
        private Ng_Tareas negocio = new Ng_Tareas();

        public FrmEstadisticaRendimientoEmpleados()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            DataTable table = negocio.ConsultaEstadistica();

            ReportDataSource ds = new ReportDataSource("cantidadTareas", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void FrmEstadisticaRendimientoEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
