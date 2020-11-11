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

namespace TPI_NewWare.Formularios.VentaProyecto
{
    public partial class FrmVentaProyecto: Form
    {
        private int panelWidth;
        private bool oculto;

        DataTable tabla = new DataTable();
        Ng_VentaProducto venta = new Ng_VentaProducto();
        Ng_Proyecto ng_Proyecto = new Ng_Proyecto();

        Proyecto proyecto = new Proyecto();

        public FrmVentaProyecto()
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

        

        private void FrmProyecto_Load(object sender, EventArgs e)
        {
            panelOpciones.Width = 0;
            panelMultiUso.Width = 0;
            

            //Cargamos la grilla con el resultado de la consulta enviada por parámetro...
            CargarGrilla(ng_Proyecto.Consulta(cbx_eliminados.Checked));

            //Cargamos y seteamos los comboboxs...
            cmb_proyecto.Cargar();
            cmb_cliente.CargarDobleDisplay("clientes", "nombres", "apellido", "nroDocumento");
            cmb_proyecto.SelectedIndex = -1;
            cmb_cliente.SelectedIndex = -1;

            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;

        }


        public void CargarGrilla(DataTable tabla)
        {
            this.tabla = tabla;
            //Cargo la grilla
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                //Verifica si el objeto se encuentra activo
                //if (tabla.Rows[i]["activos"].ToString() == "1")
                //{
                    grid.Rows.Add(tabla.Rows[i]["codigo"],
                                    tabla.Rows[i]["descripcion"],
                                    tabla.Rows[i]["nombre_cliente"],
                                    tabla.Rows[i]["fecha_inicio"],
                                    tabla.Rows[i]["fecha_fin_probable"],
                                    tabla.Rows[i]["fecha_fin_real"]);
                //}
            }

            //Actualiza la visualizacion del primer elemento

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Hacemos la consulta filtrando de acuerdo a los valores seleccionados en los comboboxs y los datetimepikers...
            this.tabla = ng_Proyecto.ConsultaFiltrada(dtpDesde.Value.ToShortDateString(), 
                dtpHasta.Value.ToShortDateString(), Convert.ToString(cmb_proyecto.SelectedValue), 
                Convert.ToString(cmb_cliente.SelectedValue), cbx_eliminados.Checked);

            CargarGrilla(tabla);
            
            timer1.Start();
            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;

            
            //Setea los combos y los datetimes..
            cmb_proyecto.SelectedIndex = -1;
            cmb_cliente.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Now.AddYears(-20);
            dtpHasta.Value = DateTime.Today;
            btnBuscar.Enabled = false;
        }


        public void ActualizarGrilla()
        {
            //Cargamos la grilla con el resultado de la consulta enviada por parámetro...
            CargarGrilla(ng_Proyecto.Consulta(cbx_eliminados.Checked));
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
            AbrirFormEnPanel(new FrmNuevoProyecto(this));
            CargarGrilla(ng_Proyecto.Consulta(cbx_eliminados.Checked));


        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Proyecto proyecto_seleccionado = new Proyecto();
            proyecto_seleccionado.Buscar(IdActual(), "codigo");
            //Marca como finalizado el proyecto con el id actual
            if (proyecto_seleccionado.FechaFinReal != "") proyecto.NoFinalizar(IdActual());
            else proyecto.Finalizar(IdActual());
            CargarGrilla(ng_Proyecto.Consulta(cbx_eliminados.Checked));
        }

        public int IdActual()
        {
            return int.Parse(tabla.Rows[this.grid.CurrentRow.Index]["codigo"].ToString());
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            //Marca como finalizado el proyecto con el id actual
            if (cbx_eliminados.Checked) proyecto.Recuperar(IdActual());
            else proyecto.Eliminar(IdActual());

            CargarGrilla(ng_Proyecto.Consulta(cbx_eliminados.Checked));
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            panelMultiUso.Width = 280;
            AbrirFormEnPanel(new FrmNuevoProyecto(this, IdActual()));
            CargarGrilla(ng_Proyecto.Consulta(cbx_eliminados.Checked));
        }

        private void cbx_eliminados_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_eliminados.Checked)
            {
                btn_nuevo.Enabled = false;
                btn_editar.Enabled = false;
                btn_finalizar.Enabled = false;
            }
            else
            {
                btn_nuevo.Enabled = true;
                btn_editar.Enabled = true;
                btn_finalizar.Enabled = true;
            }
            CargarGrilla(ng_Proyecto.Consulta(cbx_eliminados.Checked));
            
        }
    }
}
