using TPI_NewWare.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_NewWare
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }


        private void Form_Inicio_Load(object sender, EventArgs e)
        {
           
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
            panelUsuario.Visible = true;
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
            AbrirFormEnPanel(new FrmABMHerramientas());
        }

    }

}
