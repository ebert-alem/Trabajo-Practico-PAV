﻿using TPI_NewWare.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Formularios.Herramientas;
using TPI_NewWare.Formularios.Roles;
using TPI_NewWare.Formularios.Etapas;
using TPI_NewWare.Formularios.TipoDocumento;
using TPI_NewWare.Formularios.MotivosEgresos;
using TPI_NewWare.Formularios.Empleados;
using TPI_NewWare.Formularios.Productos;
using TPI_NewWare.Formularios.Clientes;
using TPI_NewWare.Formularios.VentaProducto;
using TPI_NewWare.Formularios.VentaProyecto;
using TPI_NewWare.Reportes.VentaProducto;
using TPI_NewWare.Reportes.EmpleadoProyecto;
using TPI_NewWare.Reportes.HorasEmpleado;
using TPI_NewWare.Reportes.Herramientas;
using TPI_NewWare.Reportes.ProyectoDuracion;
using TPI_NewWare.Reportes.Tareas;

namespace TPI_NewWare
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }


        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormEnPanel(object Subform)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = Subform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogin_Click(object sender, EventArgs e)
        {            
            if (panelUsuario.Visible == false) panelUsuario.Visible = true;
            else panelUsuario.Visible = false;               
        }

        private void btnSalir_Leave(object sender, EventArgs e)
        {
            btnCerrarSesion.Visible = false;
            btnSalir.Visible = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void panelUsuario_Leave(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panelUsuario_MouseLeave(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmTareas());
        }

        private void btnPromedios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmPromedios());
        }



        private void ocultarSubMenu()
        {
            panelSubAdministrar.Visible = false;
            panelSubSoporte.Visible = false;
            panelSubGestionar.Visible = false;
            panelSubGenerar.Visible = false;
            panelSubEstadisticas.Visible = false;
        }


        private void mostrarSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubAdministrar);
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubSoporte);
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubGestionar);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubGenerar);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubEstadisticas);
        }

        private void btnSubHerramientas_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Herramientas";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmABMCHerramientas());
        }


        private void btnSubRoles_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Roles";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmABMCRoles());
        }

        private void btnSubEtapas_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Etapas";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmABMCEtapas());
        }

        private void btnSubTipoDoc_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Tipos de Documento";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmTipDoc());
        }

        private void btnSubMotivoEgreso_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Motivos de Egreso";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmABMCEgresos());
        }

        private void btnSubEmpleados_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Empleados";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmABMCEmpleados());
        }

        private void btnSubProductos_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Productos";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmABMCProducto());
        }

        private void btnSubClientes_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Clientes";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmABMCCliente());
        }

        private void btnSubVentasProd_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Venta Producto";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmVentaProducto());
        }

        private void btnSubProyectos_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Proyectos";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmVentaProyecto());
        }

        private void btnSubReporteVentas_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Reporte de Ventas";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmReporteVentaProducto());
        }

        private void btnEmpleadosProyecto_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Empleados por proyecto";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmEmpleadoProducto());
        }

        private void btnHorasEmpleado_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Horas por Empleado";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmHorasEmpleado());
        }

        private void btnSubReporteHerramientas_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Reporte de Herramientas";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmReporteHerramientas());
        }

        private void btnDistribucionEmpleados_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Distribucion de empleados";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmEstadisticaEmpleadoProyecto());
        }

        private void btnSubEstTiemProy_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Tiempo de proyectos";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmEstadisticasHorasProyecto());
        }

        private void btnSubEstProdVend_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Productos Vendidos";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmEstadisticasVentasProducto());
        }

        private void btnSubEstUsoHerram_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Uso de herramientas";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmEstadisticasHerramientas());
        }

        private void btn_proyectosTerminados_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Proyectos Terminados";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmProyectoDuracion());
        }

        private void btn_subTareasEmpleado_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Tareas";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmTareasPorEmpleado());
        }

        private void btnSubEstGantt_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Duración de Etapas";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmEstadisticaProyectoDuracion());
        }

        private void tndSubEstRendEmp_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Rendimiento de Empleados";
            lbl_Titulo.Visible = true;
            AbrirFormEnPanel(new FrmEstadisticaRendimientoEmpleados());
        }

        private void btnSubEgresoEmp_Click(object sender, EventArgs e)
        {

        }
    }

}
