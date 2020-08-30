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

namespace TPI_NewWare.Formularios
{
    public partial class FrmABMHerramientas : Form
    {
        Ng_Herramienta Ng_Herramienta = new Ng_Herramienta();

        public FrmABMHerramientas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubRoles_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmABMHerramientas_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los valores elegidos
            CargarGrilla(Ng_Herramienta.Lista());
            ActualizarVisualizacion();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = tabla.Rows[i]["id"].ToString();
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
            }
        }
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lbl_id.Text = this.grid.CurrentRow.Cells[0].Value.ToString();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarVisualizacion();
        }

        private void ActualizarVisualizacion()
        {
            lbl_id.Text = "Id: " + this.grid.CurrentRow.Cells[0].Value.ToString();
            lbl_nombre.Text = "Nombre: " + this.grid.CurrentRow.Cells[1].Value.ToString();
            lbl_descripcion.Text = "Descripción: " + this.grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void lbl_id_txt_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
