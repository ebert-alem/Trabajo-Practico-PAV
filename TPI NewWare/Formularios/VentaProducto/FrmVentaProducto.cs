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
            
            CargarGrilla(venta.Consulta());
        }


        public void CargarGrilla(DataTable tabla)
        {
            //Guardo la tabla completa
            DataTable TablaCompleta = tabla;

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
                                tabla.Rows[i]["nombreEmpleado"]);
            }

            //Actualiza la visualizacion del primer elemento
            
        }


    }
}
