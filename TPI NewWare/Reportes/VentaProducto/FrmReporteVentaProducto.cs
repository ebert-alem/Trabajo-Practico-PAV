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
using Microsoft.Reporting.WinForms;


namespace TPI_NewWare.Reportes.VentaProducto
{
    public partial class FrmReporteVentaProducto : Form
    {
        DataTable tabla = new DataTable();
        Ng_VentaProducto venta = new Ng_VentaProducto();
        string restriccion = "";

        public FrmReporteVentaProducto()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVentaProducto_Load(object sender, EventArgs e)
        {
            
            //Seteamos los combobox y dateTimePicker...
            cmb_producto.Cargar();
            cmb_cliente.CargarDobleDisplay("clientes", "nombres", "apellido", "nroDocumento");
            cmb_lider.CargarDobleDisplay("empleados", "nombres", "apellido", "legajo");
            
            cmb_producto.SelectedIndex = -1;
            cmb_cliente.SelectedIndex = -1;
            cmb_lider.SelectedIndex = -1;
            cmb_estado.SelectedIndex = -1;

            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;

            
            
        }

        public void armarRestriccion()
        {
            // Agregamos las fechas establecidas...
            restriccion += "Periodo: " + dtpDesde.Value.ToShortDateString();
            restriccion += " y " + dtpHasta.Value.ToShortDateString();

            // Armamos la restriccion segun lo seleccionado en los combobox...
            if (Convert.ToString(cmb_producto.SelectedValue) != "") 
                restriccion += ", producto: " + Convert.ToString(cmb_producto.Text);
            if (Convert.ToString(cmb_cliente.SelectedValue) != "")
                restriccion += ", cliente: " + Convert.ToString(cmb_cliente.Text);
            if (Convert.ToString(cmb_lider.SelectedValue) != "")
                restriccion += ", lider: " + Convert.ToString(cmb_lider.Text);
            if (Convert.ToString(cmb_estado.SelectedItem) != "")
                restriccion += ", estado: " + Convert.ToString(cmb_estado.SelectedItem);

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            if (panel_Filtros.Height == 40) panel_Filtros.Height = 100;
            else
            {
                panel_Filtros.Height = 40;
                cmb_producto.SelectedIndex = -1;
                cmb_cliente.SelectedIndex = -1;
                cmb_lider.SelectedIndex = -1;
                cmb_estado.SelectedIndex = -1;
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            tabla = venta.ConsultaFiltrada(dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString(), Convert.ToString(cmb_producto.SelectedValue), Convert.ToString(cmb_cliente.SelectedValue), Convert.ToString(cmb_lider.SelectedValue));
            setearEstado(tabla);
            armarRestriccion();

            // Asignamos la tabla resultado al reporte...
            this.Rep_VentaProductoBindingSource.DataSource = tabla;
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("RParametros" ,restriccion));
            this.reportViewer.RefreshReport();
            restriccion = "";
        }


        public void setearEstado(DataTable tabla)
        {
            // Agregamos la columna estado al datatable...
            tabla.Columns.Add("estado", typeof(string));

            //Seteamos la columna estado según si el producto se encuentra o no en el proceso instalación...
            foreach (DataRow fila in tabla.Rows)
            {
                if (fila["inicioInstalacion"].ToString() == "" && fila["finInstalacion"].ToString() == "") fila["estado"] = "Pendiente"; ;
                if (fila["inicioInstalacion"].ToString() != "" && fila["finInstalacion"].ToString() == "") fila["estado"] = "En instalación";
                if (fila["inicioInstalacion"].ToString() != "" && fila["finInstalacion"].ToString() != "") fila["estado"] = "Finalizado";
            }

            // Comprueba si se selecciono un estado en el combobox...
            if (cmb_estado.SelectedIndex != -1)
            {
                // Eliminamos las filas que difieren del valor seleccionado... 
                foreach (DataRow fila in tabla.Rows)
                {
                    if (fila["estado"].ToString() != cmb_estado.SelectedItem.ToString())
                        fila.Delete();
                }
            }

        }

    }
}
