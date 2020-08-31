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

namespace TPI_NewWare.Formularios
{
    public partial class FrmABMHerramientas : Form
    {
        Ng_Herramienta Ng_Herramienta = new Ng_Herramienta();
        DataTable Tabla_Completa = new DataTable();

        public FrmABMHerramientas()
        {
            InitializeComponent();
        }

        private void FrmABMHerramientas_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los valores elegidos
            CargarGrilla(Ng_Herramienta.Lista());
           
        }

        private void CargarGrilla(DataTable tabla)
        {
            //Guardo la tabla completa
            Tabla_Completa = tabla;

            //Cargo la grilla
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = tabla.Rows[i]["id"].ToString();
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
            }
            //Actualiza la visualizacion del primer elemento
            ActualizarVisualizacion();

        }
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lbl_id.Text = this.grid.CurrentRow.Cells[0].Value.ToString();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
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
            if (grid.Rows.Count == 0)
            {
                // Si la grilla esta vacia borra el texto
                lbl_id.Text = "";
                lbl_nombre.Text = "";
                lbl_descripcion.Text = "";
            }
            else 
            {             
                //Busca la herramienta seleccionada en la bd por id
                Herramienta herramienta = new Herramienta();
                //Carga un objeto con los datos de la tabal seleccionada 
                herramienta.Cargar_datos(Tabla_Completa.Rows[this.grid.CurrentRow.Index]);
                //Rellena los campos con los datos
                lbl_id.Text = "Id: " + herramienta.Id;
                lbl_nombre.Text = "Nombre: " + herramienta.Nombre;
                lbl_descripcion.Text = "Descripción: " + herramienta.Descripcion;
            }
        }

        private void lbl_id_txt_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        //Actualiza la tabla segun el nombre ingresado al presionar enter
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                string filtro = txt_nombre.Text;
                if (filtro != "")
                {
                    CargarGrilla(Ng_Herramienta.Lista_nombre(filtro));
                }
                else
                {
                    CargarGrilla(Ng_Herramienta.Lista());
                }

            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
