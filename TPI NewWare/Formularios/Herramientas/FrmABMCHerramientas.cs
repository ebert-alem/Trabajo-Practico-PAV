using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPI_NewWare.Entidades;
using TPI_NewWare.Negocio;

namespace TPI_NewWare.Formularios.Herramientas
{
    public partial class FrmABMCHerramientas : TPI_NewWare.Formularios.FrmABMBase
    {
        Ng_Herramienta Ng_Herramienta = new Ng_Herramienta();
        DataTable Tabla_Completa = new DataTable();

        //Formularios internos
        private FrmAMBase frmAMHerramientas;
        protected override ClaseBase objeto => new Herramienta();


        public FrmABMCHerramientas()
        {
            InitializeComponent();
            grilla = grid;
            TablaCompleta = Tabla_Completa;
        }

        private void FrmABMCHerramientas_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los valores elegidos
            CargarGrilla();
        }
        public override void CargarGrilla(DataTable tabla)
        {
            //Guardo la tabla completa
            TablaCompleta = tabla;

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

        public override void CargarGrilla()
        {
            CargarGrilla(Ng_Herramienta.Consulta());
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarVisualizacion();
        }

        public override void MostrarSubformAlta()
        {
            frmAMHerramientas = new FrmAMHerramientas(this);
            //Asigna el form a la ventana
            AbrirFormEnPanel(frmAMHerramientas);
        }

        public override void MostrarSubformConsulta()
        {
            frmAMHerramientas = new FrmAMHerramientas(this, IdActual());
            //Asigna el form a la ventana
            AbrirFormEnPanel(frmAMHerramientas);
        }

        //Devuelve el id de la fila actualmente seleccionada
        protected override int IdActual()
        {
            return int.Parse(TablaCompleta.Rows[this.grilla.CurrentRow.Index]["id"].ToString());
        }

        //Setea la celda creada como la celda actual
        public override void SetCeldaActual()
        {
            grid.ClearSelection();
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["Column1"];
            ActualizarVisualizacion();
        }
        
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string filtro = txt_nombre.Text;
                if (filtro != "")
                {
                    CargarGrilla(Ng_Herramienta.ConsultaNombre(filtro));
                }
                else
                {
                    CargarGrilla(Ng_Herramienta.Consulta());
                }

            }
        }
    }
}
