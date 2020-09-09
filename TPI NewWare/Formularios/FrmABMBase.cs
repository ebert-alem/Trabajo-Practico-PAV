using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Formularios
{
    public partial class FrmABMBase : Form
    {
        //Subform que se insertara en el panel de visualizacion
        protected virtual FrmAMBase FrmAM { get; set; }
        //Objeto que se quiere modificar en el CU
        protected virtual ClaseBase objeto { get; set; }
        
        protected virtual DataGridView grilla { get; set; }
        protected virtual DataTable TablaCompleta { get; set; }


        //protected NgBase frm_alta_modificacion { get; }

        public FrmABMBase()
        {
            InitializeComponent();
        }
        
        //Abre el form enviado en su subpanel
        protected void AbrirFormEnPanel(object Subform)
        {

            if (this.panel_visualizacion.Controls.Count > 0)
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

        protected void ActualizarVisualizacion()
        {

            if (grilla.Rows.Count == 0)
            {
                // Si la grilla esta vacia borra el texto                
                lbl_visualizacion.Text = "";
            }
            else
            {
                //Busca la herramienta seleccionada en la bd por id
                Herramienta herramienta = new Herramienta();
                //Carga un objeto con los datos de la tabal seleccionada 
                herramienta.Cargar_datos(TablaCompleta.Rows[this.grilla.CurrentRow.Index]);
                //Rellena los campos con los datos
                lbl_visualizacion.Text = "Id: " + herramienta.Id;
                lbl_visualizacion.Text += "\nNombre: " + herramienta.Nombre;
                lbl_visualizacion.Text += "\nDescripción: " + herramienta.Descripcion;
            }

        }

        //Actualiza cuando un formulario se cierra habiendo realizado el cambio
        public void ActualizarAlta()
        {
            //Actualiza la grilla
            this.CargarGrilla();
            //Habilita la visualizacion
            panel_visualizacion.Visible = true;
            //Muestra la nueva grilla creada como seleccionada
            SetCeldaActual();

            }

        //Actualiza cuando un formulario se cierra sin realizar el cambio el cambio
        public void ActualizarCancelacion()
        {
            panel_visualizacion.Visible = true;
        }

        public virtual void CargarGrilla(DataTable tabla) {}

        public virtual void CargarGrilla() {}

        public virtual void SetCeldaActual() {}

        //Cancela todos los subformularios abiertos
        private void CancelarFormularios()
        {
            //Vuelve visible el panel de visualizacion
            panel_visualizacion.Visible = true;
            //Si existe algun formulario abierto lo cancela
            if (FrmAM != null)
            {
                FrmAM.Close();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Cancela otros formularios existentes
            CancelarFormularios();
            //Crea y muestra el formulario de alta
            MostrarSubformAlta();
        }

        public virtual void MostrarSubformAlta()
        {
        }

        

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //Cancela otros formularios existentes
            CancelarFormularios();
            MostrarSubformConsulta();
        }

        public virtual void MostrarSubformConsulta()
        {
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la herramienta seleccionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Elimina la herramienta seleccionada en el momento
                objeto.Eliminar(IdActual());
                //Actualiza la grilla
                CargarGrilla();
            }
        }

        protected virtual int IdActual()
        {
            return 0;
        }

        private void panel_work_space_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_filtro_nombre_Click(object sender, EventArgs e)
        {

        }

        private void panel_visualizacion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
