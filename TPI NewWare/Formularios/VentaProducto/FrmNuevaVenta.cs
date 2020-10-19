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

namespace TPI_NewWare.Formularios.VentaProducto
{
    public partial class FrmNuevaVenta : Form
    {
        
        FrmVentaProducto formPadre;


        Ng_VentaProducto nuevaVenta = new Ng_VentaProducto();
        

        public FrmNuevaVenta(FrmVentaProducto formPadre)
        {
            InitializeComponent();            
            this.formPadre = formPadre;
        }


        //public FrmNuevaVenta(FrmVentaProducto form, int id_producto, int nroDocumento, int tipoDocumento)
        //{
        //    InitializeComponent();
        //    formPadre = form;
        //}


        private void btn_crear_Click(object sender, EventArgs e)
        {
            //Separa el nroDocumento y el tipoDocumento del cliente...            
            string cad = Convert.ToString(cmb_cliente.SelectedValue);
            string[] separar = cad.Split(',');


            //Creamos la venta nueva...
            nuevaVenta.Alta(Convert.ToString(cmb_producto.SelectedValue), separar[0], separar[1], dtp_fecha_venta.Value.ToShortDateString(), Convert.ToString(cmb_lider.SelectedValue));

            Dispose();            
            formPadre.ActualizarGrilla();
            
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {

            //Seteamos los cmb...
            cmb_producto.Cargar();
            cmb_cliente.CargarDobleValue("clientes", "nombres", "apellido", "nroDocumento", "id_documento");
            cmb_lider.CargarDobleDisplay("empleados", "nombres", "apellido", "legajo");

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            formPadre.ActualizarGrilla();
        }
    }
}
