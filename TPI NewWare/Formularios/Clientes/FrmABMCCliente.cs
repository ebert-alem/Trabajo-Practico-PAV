using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPI_NewWare.Negocio;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Formularios.Clientes
{
    public partial class FrmABMCCliente : TPI_NewWare.Formularios.FrmABMBase
    {
        Ng_Cliente negocio = new Ng_Cliente();
        protected override ClaseBase Objeto => new Cliente();

        public FrmABMCCliente()
        {
            InitializeComponent();
            Grilla = grid;
        }
        private void FrmABMCCliente_Load(object sender, EventArgs e)
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
                grid.Rows[i].Cells[0].Value = tabla.Rows[i]["id_documento"].ToString();
                //grid.Rows[i].Cells[1].Value = tabla.Rows[i]["documento"].ToString();
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["nombres"].ToString();
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["apellido"].ToString();
                //grid.Rows[i].Cells[4].Value = tabla.Rows[i]["telefono"].ToString();
                //grid.Rows[i].Cells[5].Value = tabla.Rows[i]["calle"].ToString();
                //grid.Rows[i].Cells[6].Value = tabla.Rows[i]["numeroCalle"].ToString();
                //grid.Rows[i].Cells[7].Value = tabla.Rows[i]["email"].ToString();
                //grid.Rows[i].Cells[8].Value = tabla.Rows[i]["activos"].ToString();
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
            FrmAM = new FrmAMCliente(this);
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmAM);
        }

        public override void MostrarSubformConsulta()
        {
            FrmAM = new FrmAMCliente(this, IdActual());
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmAM);
        }

        //Devuelve el id de la fila actualmente seleccionada
        protected override int IdActual()
        {
            return int.Parse(TablaCompleta.Rows[this.Grilla.CurrentRow.Index]["nroDocumento"].ToString());
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
                Cliente objeto = new Cliente();
                //Carga un objeto con los datos de la tabal seleccionada 
                objeto.Cargar_datos(TablaCompleta.Rows[this.Grilla.CurrentRow.Index]);
                //Rellena los campos con los datos
                Ng_TipDoc ng_TipDoc = new Ng_TipDoc();
                TipDoc tipDoc = ng_TipDoc.Buscar(int.Parse(objeto.TipoDocumento));

                lbl_visualizacion.Text = tipDoc.NombreTipoDocumento + ": " + objeto.Documento;
                lbl_visualizacion.Text += "\nNombre: " + objeto.Nombre;
                lbl_visualizacion.Text += "\nApellido: " + objeto.Apellido;
                lbl_visualizacion.Text += "\nTelefono: " + objeto.Telefono;
                lbl_visualizacion.Text += "\nDomicilio: " + objeto.Calle + " " + objeto.NumeroCalle;
                lbl_visualizacion.Text += "\nEmail: " + objeto.Email;

            }
        }
    }
}
