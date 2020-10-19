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
    public partial class FrmActualizarVenta : Form
    {
        private FrmVentaProducto formPadre;
        private string id_producto;
        private string nroDocumento;
        private string tipoDocumento;
        private string inicio;
        Ng_VentaProducto ng_venta = new Ng_VentaProducto();
        Entidades.VentaProducto venta = new Entidades.VentaProducto();
        



        public FrmActualizarVenta(FrmVentaProducto formPadre, string id_producto, string nroDocumento, string tipoDocumento, string inicio)
        {            
            InitializeComponent();
            this.formPadre = formPadre;
            this.id_producto = id_producto;
            this.nroDocumento = nroDocumento;
            this.tipoDocumento = tipoDocumento;
            this.inicio = inicio;
        }

        private void FrmActualizarVenta_Load(object sender, EventArgs e)
        {
            Ng_Cliente cliente = new Ng_Cliente();
            Ng_Producto producto = new Ng_Producto();


            dtp_inicio_instalacion.Enabled = false;
            dtp_fin_instalacion.Enabled = true;

            lbl_producto.Text += producto.BuscarPorId(id_producto);
            lbl_cliente.Text += cliente.BuscarNombreCompleto(nroDocumento, tipoDocumento);

            //Verificamos si la fecha de inicio_instalacion esta en blanco...
            if (inicio == "")
            {
                dtp_inicio_instalacion.Enabled = true;
                dtp_fin_instalacion.Enabled = false;
                
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            formPadre.ActualizarGrilla();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            ////Verificamos que la fecha ingresada no sea menor a la actual...
            //if (dtp_inicio_instalacion.Value < DateTime.Today | dtp_fin_instalacion.Value < DateTime.Today)
            //{
            //    MessageBox.Show("Fechas incorrectas");
            //}
            //else
            //{    
                
                //Verificamos si se desabilito la opcion de fin_instalacion...
                if (dtp_fin_instalacion.Enabled == false)
                {
                    venta.InicioInstalacion = dtp_inicio_instalacion.Value.ToShortDateString();
                    venta.FinInstalacion = "";
                }
                
                else
                {
                    venta.FinInstalacion = dtp_fin_instalacion.Value.ToShortDateString();
                    venta.InicioInstalacion = "";
                }
                 
                venta.CodProducto = id_producto;                
                venta.Documento = nroDocumento;
                venta.TipoDocumento = tipoDocumento;                               
                venta.Guardar();
                
                Dispose();
                formPadre.ActualizarGrilla();

            //}
        }
    }
}
