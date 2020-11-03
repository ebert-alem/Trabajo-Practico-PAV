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

namespace TPI_NewWare.Reportes.ProyectoDuracion
{
    public partial class FrmEstadisticaProyectoDuracion : Form
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();
        private Ng_ProyectoDuracion negocio = new Ng_ProyectoDuracion();
        public FrmEstadisticaProyectoDuracion()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaProyectoDuracion_Load(object sender, EventArgs e)
        {

            this.cmb_proyecto.Cargar();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(cmb_proyecto.SelectedValue) != null) {
                DataTable table = negocio.ConsultaEstadistica(Convert.ToString(cmb_proyecto.SelectedValue));

                ReportDataSource ds = new ReportDataSource("duracionEtapas", table);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();

            }
        }
    }
}
