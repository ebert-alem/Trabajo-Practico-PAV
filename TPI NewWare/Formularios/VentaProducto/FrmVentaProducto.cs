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

namespace TPI_NewWare.Formularios.VentaProducto
{
    public partial class FrmVentaProducto : Form
    {
        private int panelWidth;
        private bool oculto;


        DataTable tabla = new DataTable();
        Ng_VentaProducto venta = new Ng_VentaProducto();



        public FrmVentaProducto()
        {
            InitializeComponent();
            panelWidth = panelOpciones.Width;
            oculto = true;
            
        }


        private void btn_filtro_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            btnBuscar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (oculto)
            {
                panelOpciones.Width = panelOpciones.Width + 10;
                if (panelOpciones.Width >= panelWidth)
                {
                    timer1.Stop();
                    oculto = false;
                    this.Refresh();
                }
            }
            else
            {
                panelOpciones.Width = panelOpciones.Width - 10;
                if (panelOpciones.Width <= 0)
                {
                    timer1.Stop();
                    oculto = true;
                    this.Refresh();
                }
            }
        }

        

        private void FrmVentaProducto_Load(object sender, EventArgs e)
        {
            panelOpciones.Width = 0;
            panelMultiUso.Width = 0;
            
            //Cargamos la grilla con el resultado de la consulta enviada por parámetro...
            CargarGrilla(venta.Consulta());
            
            
                //Cargamos y seteamos los comboboxs...
            cmb_producto.Cargar();
            cmb_cliente.CargarDobleDisplay("clientes", "nombres", "apellido", "nroDocumento");
            cmb_lider.CargarDobleDisplay("empleados", "nombres", "apellido", "legajo");
            cmb_producto.SelectedIndex = -1;
            cmb_cliente.SelectedIndex = -1;
            cmb_lider.SelectedIndex = -1;

            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;

        }


        public void CargarGrilla(DataTable tabla)
        {
            
            //Cargo la grilla
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                grid.Rows.Add(tabla.Rows[i]["id"],
                              tabla.Rows[i]["nombreProducto"],
                              tabla.Rows[i]["nombreCliente"],
                              tabla.Rows[i]["fecha_venta"],
                              tabla.Rows[i]["inicioInstalacion"],
                              tabla.Rows[i]["finInstalacion"],
                              tabla.Rows[i]["nombreEmpleado"],
                              tabla.Rows[i]["nroDocumento"],
                              tabla.Rows[i]["tipoDocumento"]);
            }

            //Actualiza la visualizacion del primer elemento
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Hacemos la consulta filtrando de acuerdo a los valores seleccionados en los comboboxs y los datetimepikers...
            tabla = venta.ConsultaFiltrada(dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString(), Convert.ToString(cmb_producto.SelectedValue), Convert.ToString(cmb_cliente.SelectedValue), Convert.ToString(cmb_lider.SelectedValue));
            
            CargarGrilla(tabla);
            
            timer1.Start();
            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;

            
            //Setea los combos y los datetimes..
            cmb_producto.SelectedIndex = -1;
            cmb_cliente.SelectedIndex = -1;
            cmb_lider.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;
            btnBuscar.Enabled = false;
        }


        public void ActualizarGrilla()
        {
            //Cargamos la grilla con el resultado de la consulta enviada por parámetro...
            CargarGrilla(venta.Consulta());
            panelMultiUso.Width = 0;
        }


        protected void AbrirFormEnPanel(object Subform)
        {
            if (this.panelMultiUso.Controls.Count > 0)
            {
                //Oculta el panel de previsualizacion
                panelMultiUso.Visible = false;
            }
            //Crea el nuevo form y lo inserta en el panel
            Form fh = Subform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            //Agrrega el panel contenedor como dato
            this.panelMultiUso.Controls.Add(fh);
            this.panelMultiUso.Tag = fh;
            fh.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            panelMultiUso.Width = 280;
            FrmNuevaVenta nuevaVenta = new FrmNuevaVenta (this);
            AbrirFormEnPanel(nuevaVenta);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificamos si los campos inicio_instalacion y fin_instalacion estan en blanco...
            if ( Convert.ToString(grid.CurrentRow.Cells[4].Value) == "" | Convert.ToString(grid.CurrentRow.Cells[5].Value) == "" )
            {
                btn_editar.Enabled = true;
            }
            else
            {
                btn_editar.Enabled = false;
            }
                        
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            panelMultiUso.Width = 280;
            FrmActualizarVenta actualizarVenta = new FrmActualizarVenta(this, Convert.ToString(grid.CurrentRow.Cells[0].Value), Convert.ToString(grid.CurrentRow.Cells[7].Value), Convert.ToString(grid.CurrentRow.Cells[8].Value), Convert.ToString(grid.CurrentRow.Cells[4].Value));
            AbrirFormEnPanel(actualizarVenta);

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la venta de producto seleccionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {    
                
                venta.EliminarVenta(Convert.ToString(grid.CurrentRow.Cells[0].Value), Convert.ToString(grid.CurrentRow.Cells[7].Value), Convert.ToString(grid.CurrentRow.Cells[8].Value));
                ActualizarGrilla();

            }
        }
    }
}
