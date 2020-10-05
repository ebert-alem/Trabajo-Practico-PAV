using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_NewWare.Formularios.VentaProducto
{
    public partial class FrmNuevaVenta : Form
    {
        
        FrmVentaProducto formPadre;
        
        public FrmNuevaVenta(FrmVentaProducto formPadre)
        {
            InitializeComponent();            
            this.formPadre = formPadre;
        }


        public FrmNuevaVenta(FrmVentaProducto form, int id_producto, int nroDocumento, int tipoDocumento)
        {
            InitializeComponent();
            formPadre = form;


        }



        private void btn_crear_Click(object sender, EventArgs e)
        {
            Dispose();            
            formPadre.ActualizarGrilla();
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {

            //Seteamos los cmb...
            cmb_producto.Cargar();
            cmb_cliente.CargarDobleDisplay("clientes", "nombres", "apellido", "nroDocumento");
            cmb_lider.CargarDobleDisplay("empleados", "nombres", "apellido", "legajo");


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            formPadre.ActualizarGrilla();
        }
    }
}
