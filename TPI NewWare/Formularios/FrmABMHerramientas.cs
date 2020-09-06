using System;
using System.Data;
using System.Windows.Forms;
using TPI_NewWare.Entidades;
using TPI_NewWare.Negocio;

namespace TPI_NewWare.Formularios
{
    public partial class FrmABMHerramientas : Form
    {
        Ng_Herramienta Ng_Herramienta = new Ng_Herramienta();
        DataTable Tabla_Completa = new DataTable();

        //Formularios internos
        private FrmAltaHerramientas frmAltaHerramientas;

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

        private void AbrirFormEnPanel(object Subform)
        {
            if (this.panel_work_space.Controls.Count > 0)
            {   
                //Oculta el panel de previsualizacion
                panel_visualizacion.Visible = false;
            }

            //Crea el nuevo form y lo inserta en el panel
            Form fh = Subform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            //Agrrega el panel contenedor como dato
            this.panel_work_space.Controls.Add(fh);
            this.panel_work_space.Tag = fh;
            fh.Show();

        }
        //Cancela todos los subformularios abiertos
        private void CancelarFormularios()
        {
            //Vuelve visible el panel de visualizacion
            panel_visualizacion.Visible = true;
            //Si existe algun formulario abierto lo cancela
            if (frmAltaHerramientas != null)
            {
                frmAltaHerramientas.Close();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            //Cancela otros formularios existentes
            CancelarFormularios();
            frmAltaHerramientas = new FrmAltaHerramientas(this);
            //Asigna el form a la ventana
            AbrirFormEnPanel(frmAltaHerramientas);
        }

        //Actualiza cuando un formulario se cierra habiendo realizado el cambio
        public void ActualizarAlta()
        {
            //Actualiza la grilla
            this.CargarGrilla(Ng_Herramienta.Lista());
            //Habilita la visualizacion
            panel_visualizacion.Visible = true;
            //Muestra la nueva grilla creada como seleccionada
            grid.ClearSelection();
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["Column1"];
            ActualizarVisualizacion();
        }

        public void ActualizarCancelacion() 
        {
            panel_visualizacion.Visible = true;
        }

        
    }
}
