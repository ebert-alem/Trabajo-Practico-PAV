using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Clases;
using TPI_NewWare.Negocio;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Formularios
{
    public partial class FrmAMBase : Form
    {
        public FrmAMBase()
        {
            InitializeComponent();
        }

        public virtual void btn_cancelar_Click(object sender, EventArgs e)
        {
        }

        public virtual void btn_crear_Click(object sender, EventArgs e)
        {
        }
    }
}
