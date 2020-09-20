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
        protected virtual ClaseBase Objeto { get; set; }
        
        protected virtual DataGridView Grilla { get; set; }
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

        public virtual void ActualizarVisualizacion() { }


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

        protected virtual void CargarGrilla(DataTable tabla) {}

        protected virtual void CargarGrilla() {}

        protected virtual void SetCeldaActual() {}

        //Cancela todos los subformularios abiertos
        protected void CancelarFormularios()
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

        public virtual void MostrarSubformAlta() {}

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (TablaCompleta.Rows.Count != 0)
            {
                //Cancela otros formularios existentes
                CancelarFormularios();
                MostrarSubformConsulta();
            }
        }

        public virtual void MostrarSubformConsulta() {}

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (TablaCompleta.Rows.Count != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el objeto seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Elimina la herramienta seleccionada en el momento
                    Objeto.Eliminar(IdActual());
                    //Actualiza la grilla
                    CargarGrilla();
                }
            }
        }

        protected virtual int IdActual()
        {
            return 0;
        }
    }
}
