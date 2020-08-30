﻿using System;
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
        DataTable dataTable = new DataTable();

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
            dataTable = Ng_Herramienta.Lista();
            CargarGrilla(dataTable);
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
            //Busca la herramienta seleccionada en la bd por id
            Herramienta herramienta = new Herramienta();
            //Carga un objeto con los datos de la tabal seleccionada 
            herramienta.Cargar_datos(dataTable.Rows[this.grid.CurrentRow.Index]);
            //Rellena los campos con los datos
            lbl_id.Text = "Id: " + herramienta.Id;
            lbl_nombre.Text = "Nombre: " + herramienta.Nombre;
            lbl_descripcion.Text = "Descripción: " + herramienta.Descripcion;
        }

        private void lbl_id_txt_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
