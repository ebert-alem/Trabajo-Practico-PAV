using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPI_NewWare.Entidades;
using TPI_NewWare.Negocio;

namespace TPI_NewWare.Formularios.MotivosEgresos
{
    public partial class FrmABMCEgresos : TPI_NewWare.Formularios.FrmABMBase
    {
        Ng_MotivoEgreso negocio = new Ng_MotivoEgreso();

        protected override ClaseBase Objeto => new MotivoEgreso();


        public FrmABMCEgresos()
        {
            InitializeComponent();
            Grilla = grid;
        }

        private void FrmABMCEgresos_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los valores elegidos
            CargarGrilla();
        }
        protected override void CargarGrilla(DataTable tabla)
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
            }
            //Actualiza la visualizacion del primer elemento
            ActualizarVisualizacion();
        }

        protected override void CargarGrilla()
        {
            CargarGrilla(negocio.Consulta());
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarVisualizacion();
        }

        public override void MostrarSubformAlta()
        {
            FrmAM = new FrmAMEgreso(this);
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmAM);
        }

        public override void MostrarSubformConsulta()
        {
            FrmAM = new FrmAMEgreso(this, IdActual());
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmAM);
        }

        //Devuelve el id de la fila actualmente seleccionada
        protected override int IdActual()
        {
            return int.Parse(TablaCompleta.Rows[this.Grilla.CurrentRow.Index]["id"].ToString());
        }

        //Setea la celda creada como la celda actual
        protected override void SetCeldaActual()
        {
            grid.ClearSelection();
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["Column1"];
            ActualizarVisualizacion();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public override void ActualizarVisualizacion()
        {
            if (Grilla.Rows.Count == 0)
            {
                // Si la grilla esta vacia borra el texto                
                lbl_visualizacion.Text = "";
            }
            else
            {
                //Busca la herramienta seleccionada en la bd por id
                MotivoEgreso motivoEgreso = new MotivoEgreso();
                //Carga un objeto con los datos de la tabal seleccionada 
                motivoEgreso.Cargar_datos(TablaCompleta.Rows[this.Grilla.CurrentRow.Index]);
                //Rellena los campos con los datos
                lbl_visualizacion.Text = "Id: " + motivoEgreso.Id;
                lbl_visualizacion.Text += "\nNombre: " + motivoEgreso.Nombre;
            }
        }

        
    }
}
