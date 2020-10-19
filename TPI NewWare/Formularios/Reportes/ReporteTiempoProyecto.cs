using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Negocio;
using TPI_NewWare.Entidades;
using Microsoft.Reporting.WinForms;

namespace TPI_NewWare.Formularios.Reportes
{
    public partial class ReporteTiempoProyecto : Form
    {
        Proyecto proyecto = new Proyecto();
        
        public ReporteTiempoProyecto()
        {
            InitializeComponent();
        }

        private void ReporteTiempoProyecto_Load(object sender, EventArgs e)
        {

            this.rpt_TiempoPorProyecto.RefreshReport();
        }

        private void rpt_TiempoPorProyecto_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = "SELECT DATEDIFF(day, fecha_inicio, fecha_fin_real) AS Duración, DESCRIPCION AS Nombre, FECHA_FIN_REAL AS Finalizacion "
                         + "FROM dbo.proyectos WHERE fecha_fin_real IS NOT NULL";
            //if (ltxt_fechaFinalizacion.Text != null)
            //{
            //    sql = "SELECT DATEDIFF(day, fecha_inicio, fecha_fin_real) AS Duración, DESCRIPCION AS Nombre, FECHA_FIN_REAL AS Finalizacion "
            //           + "FROM dbo.proyectos WHERE fecha_fin_real IS NOT NULL AND fecha_fin_real<'" + ltxt_fechaFinalizacion.Text +"-12-31' AND '"
            //           + ltxt_fechaFinalizacion.Text + "-01-01'<fecha_fin_real AND fecha_inicio<fecha_fin_real;";
            //}

            tabla = proyecto.BuscarProyectosTerminados(sql);

            ReportDataSource ds = new ReportDataSource("ProyectosTerminados", tabla);

            rpt_TiempoPorProyecto.LocalReport.DataSources.Clear();
            rpt_TiempoPorProyecto.LocalReport.DataSources.Add(ds);
            rpt_TiempoPorProyecto.LocalReport.Refresh();

        }
    }
}
