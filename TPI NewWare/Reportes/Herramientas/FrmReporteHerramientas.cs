﻿using System;
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



namespace TPI_NewWare.Reportes.Herramientas
{
    public partial class FrmReporteHerramientas : Form
    {
        DataTable tabla = new DataTable();
        Ng_Herramienta herramienta = new Ng_Herramienta();
        string restriccion = "";

        public FrmReporteHerramientas()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVentaProducto_Load(object sender, EventArgs e)
        {
            
            //Seteamos los combobox y dateTimePicker...
            cmb_Herramienta.Cargar();
            cmb_proyecto.Cargar();
            cmb_etapa.Cargar();

            cmb_Herramienta.SelectedIndex = -1;
            cmb_etapa.SelectedIndex = -1;
            cmb_proyecto.SelectedIndex = -1;
           

            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;

                                  
        }

        public void armarRestriccion()
        {
            // Agregamos las fechas establecidas...
            restriccion += "Periodo: " + dtpDesde.Value.ToShortDateString();
            restriccion += " y " + dtpHasta.Value.ToShortDateString();

            // Armamos la restriccion segun lo seleccionado en los combobox...
            if (Convert.ToString(cmb_Herramienta.SelectedValue) != "") 
                restriccion += ", herramienta: " + Convert.ToString(cmb_Herramienta.Text);                        
            if (Convert.ToString(cmb_proyecto.SelectedValue) != "")
                restriccion += ", proyecto: " + Convert.ToString(cmb_proyecto.Text);
            if (Convert.ToString(cmb_etapa.SelectedValue) != "")
                restriccion += ", etapa: " + Convert.ToString(cmb_etapa.Text);

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            if (panel_Filtros.Height == 40) panel_Filtros.Height = 100;
            else
            {
                panel_Filtros.Height = 40;
                cmb_Herramienta.SelectedIndex = -1;
                cmb_etapa.SelectedIndex = -1;
                cmb_proyecto.SelectedIndex = -1;               
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            tabla = herramienta.ConsultaFiltrada(dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString(), Convert.ToString(cmb_Herramienta.SelectedValue), Convert.ToString(cmb_proyecto.SelectedValue), Convert.ToString(cmb_etapa.SelectedValue));
            armarRestriccion();


            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            reportViewer.LocalReport.ReportEmbeddedResource = "TPI_NewWare.Reportes.Herramientas.ReporteHerramientas.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(Datos);
            // Asignamos la tabla resultado al reporte...
            //this.Rep_HerramientasBindingSource.DataSource = tabla;
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("RParametro" ,restriccion));
            this.reportViewer.RefreshReport();
            restriccion = "";
        }
                     

    }
}
