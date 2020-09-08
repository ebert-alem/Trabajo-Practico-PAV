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
        }

        private void FrmABMCHerramientas_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los valores elegidos
            CargarGrilla();
        }

        public override void CargarGrilla(DataTable tabla)
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

        public override void CargarGrilla()
        {
            CargarGrilla(Ng_Herramienta.Consulta());
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
                lbl_visualizacion.Text = "";
            }
            else
            {
                //Busca la herramienta seleccionada en la bd por id
                Herramienta herramienta = new Herramienta();
                //Carga un objeto con los datos de la tabal seleccionada 
                herramienta.Cargar_datos(Tabla_Completa.Rows[this.grid.CurrentRow.Index]);
                //Rellena los campos con los datos
                lbl_visualizacion.Text = "Id: " + herramienta.Id;
                lbl_visualizacion.Text += "\nNombre: " + herramienta.Nombre;
                lbl_visualizacion.Text += "\nDescripción: " + herramienta.Descripcion;
            }
            
        }

        //Actualiza la tabla segun el nombre ingresado al presionar enter
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

        public override void MostrarSubformAlta()
        {
            frmAMHerramientas = new FrmAMHerramientas(this);
            //Asigna el form a la ventana
            AbrirFormEnPanel(frmAMHerramientas);
        }

        public override void MostrarSubformConsulta()
        {
            base.MostrarSubformConsulta();
            frmAMHerramientas = new FrmAMHerramientas(this, IdActual());
            //Asigna el form a la ventana
            AbrirFormEnPanel(frmAMHerramientas);
            //Actualiza la tabla modificada
        }

        //Devuelve el id de la fila actualmente seleccionada
        protected override int IdActual()
        {
            return int.Parse(Tabla_Completa.Rows[this.grid.CurrentRow.Index]["id"].ToString());
        }

        //Setea la celda creada como la celda actual
        public override void SetCeldaActual()
        {
            grid.ClearSelection();
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["Column1"];
            ActualizarVisualizacion();
        }
    }
}
