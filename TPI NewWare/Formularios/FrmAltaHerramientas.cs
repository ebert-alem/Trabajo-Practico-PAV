using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_NewWare.Formularios
{
    public partial class FrmAltaHerramientas : Form
    {
        Panel panel_visualizacion;
        public FrmAltaHerramientas(Panel panel)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            panel_visualizacion = panel;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_visualizacion.Visible = true;
            this.Close();
        }


    }
}
