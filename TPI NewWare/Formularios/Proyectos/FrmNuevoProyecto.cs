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
    public partial class FrmNuevoProyecto : Form
    {
        
        FrmVentaProyecto formPadre;


        Ng_VentaProducto nuevaVenta = new Ng_VentaProducto();
        

        public FrmNuevoProyecto(FrmVentaProyecto formPadre)
        {
            InitializeComponent();            
            this.formPadre = formPadre;
        }


        public FrmNuevoProyecto(FrmVentaProyecto form, int id_producto, int nroDocumento, int tipoDocumento)
        {
            InitializeComponent();
            formPadre = form;
        }



        private void btn_crear_Click(object sender, EventArgs e)
        {
            //Crea un nuevo proyecto
            Proyecto proyecto = new Proyecto(txt_descripcion.Text, Convert.ToString(cmb_cliente.SelectedValue), "1", dtpInicio.Value.ToShortDateString(), dtpFinEsperado.Value.ToShortDateString());
            proyecto.Crear();

            formPadre.ActualizarGrilla();
            Dispose();            
            
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {
            //Seteamos los cmb...
            cmb_cliente.CargarDobleDisplay("clientes", "nombres", "apellido", "nroDocumento");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            formPadre.ActualizarGrilla();
        }

        private void lbl_lider_Click(object sender, EventArgs e)
        {

        }
    }
}
