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

namespace TPI_NewWare.Reportes.Tareas
{
    public partial class FrmTareasPorEmpleado : Form
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();
        private Ng_Tareas negocio = new Ng_Tareas();
        public FrmTareasPorEmpleado()
        {
            InitializeComponent();
        }

        private void FrmTareasPorEmpleado_Load(object sender, EventArgs e)
        {

            this.cmb_empleado.Cargar();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            DataTable table = negocio.Consulta();

            ReportDataSource ds = new ReportDataSource("tareasEmpleados", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            DataTable table = negocio.ConsultaFiltrada(Convert.ToString(cmb_empleado.SelectedValue));

            ReportDataSource ds = new ReportDataSource("tareasEmpleados", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}
