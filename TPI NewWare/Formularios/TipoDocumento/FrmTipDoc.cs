using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPI_NewWare.Entidades;
using TPI_NewWare.Negocio;

namespace TPI_NewWare.Formularios.TipoDocumento
{
    public partial class FrmTipDoc : TPI_NewWare.Formularios.FrmABMBase
    {
        Ng_TipDoc negocio = new Ng_TipDoc();

        protected override ClaseBase Objeto => new TipDoc();


        public FrmTipDoc()
        {
            InitializeComponent();
            Grilla = grid;
        }

        private void FrmABMCTipoDoc_Load(object sender, EventArgs e)
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
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["nombreTipoDocumento"].ToString();
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
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
            FrmAM = new FrmAMTipDoc(this);
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmAM);
        }

        public override void MostrarSubformConsulta()
        {
            FrmAM = new FrmAMTipDoc(this, IdActual());
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
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["id"];
            ActualizarVisualizacion();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string filtro = txt_nombre.Text;
                if (filtro != "")
                {
                    CargarGrilla(negocio.ConsultaNombre(filtro));
                }
                else
                {
                    CargarGrilla(negocio.Consulta());
                }

            }
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
                TipDoc tipDoc = new TipDoc();
                //Carga un objeto con los datos de la tabal seleccionada 
                tipDoc.Cargar_datos(TablaCompleta.Rows[this.Grilla.CurrentRow.Index]);
                //Rellena los campos con los datos
                lbl_visualizacion.Text = "Id: " + tipDoc.Id;
                lbl_visualizacion.Text = "\nNombre: " + tipDoc.NombreTipoDocumento;
                lbl_visualizacion.Text += "\nDescripción: " + tipDoc.Descripcion;
            }
        }
    }

}
