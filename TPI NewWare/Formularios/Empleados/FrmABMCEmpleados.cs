using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPI_NewWare.Negocio;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Formularios.Empleados
{
    public partial class FrmABMCEmpleados : TPI_NewWare.Formularios.FrmABMBase
    {
        Ng_Empleado negocio = new Ng_Empleado();
        private FrmEgreso FrmE;

        protected override ClaseBase Objeto => new Empleado();

        public FrmABMCEmpleados()
        {
            InitializeComponent();
            Grilla = grid;
        }
        private void FrmABMCEmpleados_Load(object sender, EventArgs e)
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
                grid.Rows[i].Cells[0].Value = tabla.Rows[i]["legajo"].ToString();
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["nombres"].ToString();
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["apellido"].ToString();
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
            FrmAM = new FrmAMEmpleados(this);
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmAM);
        }

        public override void MostrarSubformConsulta()
        {
            FrmAM = new FrmAMEmpleados(this, IdActual());
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmAM);
        }


        //Devuelve el id de la fila actualmente seleccionada
        protected override int IdActual()
        {
            return int.Parse(TablaCompleta.Rows[this.Grilla.CurrentRow.Index]["Legajo"].ToString());
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
                Empleado objeto = new Empleado();
                //Carga un objeto con los datos de la tabal seleccionada 
                objeto.Cargar_datos(TablaCompleta.Rows[this.Grilla.CurrentRow.Index]);
                //Rellena los campos con los datos
                lbl_visualizacion.Text = "Legano: " + objeto.Legajo;
                lbl_visualizacion.Text += "\nNombre: " + objeto.Nombre;
                lbl_visualizacion.Text += "\nApellido: " + objeto.Apellido;
                lbl_visualizacion.Text += "\nFecha de Ingreso: " + objeto.FechaIngreso;
                lbl_visualizacion.Text += "\nFecha de Egreso: " + objeto.FechaEgreso;
                lbl_visualizacion.Text += "\nDomicilio: " + objeto.Domicilio;
                lbl_visualizacion.Text += "\nfechaNacimiento: " + objeto.FechaNacimiento;
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            FrmE = new FrmEgreso(this, IdActual());
            //Asigna el form a la ventana
            AbrirFormEnPanel(FrmE);
        }
    }
}
