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
    public partial class FrmAltaRoles : Form
    {
        FrmABMRoles form_contenedor;

        Ng_Rol ng_Rol = new Ng_Rol();
        Rol rol;

        public FrmAltaRoles(FrmABMRoles form)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
        }
        public FrmAltaRoles(FrmABMRoles form, int id)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
            btn_crear.Text = "Modificar";

            //Se obtiene el objeto a modificar
            rol = ng_Rol.Buscar(id);
            //Se actualizan los campos del formulario con los atributos
            txt_nombre.Text = rol.Nombre;
            txt_descripcion.Text = rol.Descripcion;
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
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (btn_crear.Text == "Crear")
                {
                    //Da el alta de la herramienta
                    ng_Rol.Alta(txt_nombre.Text, txt_descripcion.Text);
                }
                else
                {
                    //Modfica la herramienta
                    rol.Nombre = txt_nombre.Text;
                    rol.Descripcion = txt_descripcion.Text;
                    rol.Guardar();
                }
                form_contenedor.ActualizarAlta();
                this.Close();
            }
        }

        private void FrmAltaHerramientas_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
