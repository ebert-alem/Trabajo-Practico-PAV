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







        private void iconButton1_Click(object sender, EventArgs e)
        {
            Dispose();
            FrmVentaProducto frmVentaProducto = new FrmVentaProducto();
            formPadre.ActualizarGrilla();
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {

            //Seteamos los cmb...
            cmb_producto.Cargar();

            
        }
    }
}
