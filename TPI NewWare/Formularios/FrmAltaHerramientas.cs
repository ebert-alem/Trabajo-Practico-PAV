using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Clases;
using TPI_NewWare.Negocio;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Formularios
{
    public partial class FrmAltaHerramientas : Form
    {
        FrmABMHerramientas form_contenedor;

        Ng_Herramienta ng_Herramienta = new Ng_Herramienta();

        public FrmAltaHerramientas(FrmABMHerramientas form)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
        }
        public FrmAltaHerramientas(FrmABMHerramientas form, int id)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
            btn_crear.Text = "Modificar";
            Herramienta herramienta = ng_Herramienta.Buscar(id);
            txt_nombre.Text = herramienta.Nombre;
            txt_descripcion.Text = herramienta.Descripcion;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            form_contenedor.ActualizarCancelacion();
            this.Close();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            
            //Valida que el formato de los datos ingresado sea correcto
            if(tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (btn_crear.Text == "Crear")
                {
                    //Da el alta de la herramienta
                    ng_Herramienta.Alta(txt_nombre.Text, txt_descripcion.Text);
                    form_contenedor.ActualizarAlta();
                    this.Close();
                }
                else 
                {
                    //Modfica la herramienta

                }
            }
        }

        private void FrmAltaHerramientas_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
