using System;
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

namespace TPI_NewWare.Formularios.VentaProyecto
{
    public partial class FrmNuevoProyecto : Form
    {
        FrmVentaProyecto formPadre;
        Proyecto proyecto = new Proyecto();
        bool Crear = true;

        public FrmNuevoProyecto(FrmVentaProyecto formPadre)
        {
            InitializeComponent();            
            this.formPadre = formPadre;
        }

        public FrmNuevoProyecto(FrmVentaProyecto form, int codigo)
        {
            InitializeComponent();
            formPadre = form;
            Crear = false;

            //Busco el proyecto seleccionado
            proyecto.Buscar(codigo, "codigo");

            //Seteo los atributos
            txt_descripcion.Text = proyecto.Descripcion;
            cmb_cliente.CargarDobleValue("clientes", "nombres", "apellido", "nroDocumento", "id_documento");
            dtpInicio.Value = DateTime.Parse(proyecto.FechaInicio);
            dtpFinEsperado.Value = DateTime.Parse(proyecto.FechaFinProbable);
            


        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            //Crea un nuevo proyecto
            string cad = Convert.ToString(cmb_cliente.SelectedValue);
            string[] separar = cad.Split(',');

            if (Crear)
            {
                Proyecto proyecto = new Proyecto(txt_descripcion.Text, separar[0], separar[1], dtpInicio.Value.ToShortDateString(), dtpFinEsperado.Value.ToShortDateString());
                proyecto.Crear();

            }
            else
            {
                proyecto.Descripcion = txt_descripcion.Text;
                proyecto.Documento = separar[0];
                proyecto.TipoDocumento = separar[1];
                proyecto.FechaInicio = dtpInicio.Value.ToShortDateString();
                proyecto.FechaFinProbable = dtpFinEsperado.Value.ToShortDateString();
                proyecto.Guardar();
            }

            formPadre.ActualizarGrilla();
            Dispose();            
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {
            //Seteamos los cmb...
            cmb_cliente.CargarDobleValue("clientes", "nombres", "apellido", "nroDocumento", "id_documento");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            formPadre.ActualizarGrilla();
        }

        private void lbl_lider_Click(object sender, EventArgs e)
        {

        }
    }
}
