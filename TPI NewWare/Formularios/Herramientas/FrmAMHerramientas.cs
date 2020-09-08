using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPI_NewWare.Clases;
using TPI_NewWare.Negocio;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Formularios
{
    public partial class FrmAMHerramientas : TPI_NewWare.Formularios.FrmAMBase
    {
        FrmABMBase form_contenedor;

        Ng_Herramienta ng_Herramienta = new Ng_Herramienta();
        Herramienta herramienta;

        public FrmAMHerramientas(FrmABMBase form)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
        }

        public FrmAMHerramientas(FrmABMBase form, int id)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
            btn_crear.Text = "Modificar";

            //Se obtiene el objeto a modificar
            herramienta = ng_Herramienta.Buscar(id);
            //Se actualizan los campos del formulario con los atributos
            txt_nombre.Text = herramienta.Nombre;
            txt_descripcion.Text = herramienta.Descripcion;
        }

        public override void btn_cancelar_Click(object sender, EventArgs e)
        {
            form_contenedor.ActualizarCancelacion();
            this.Close();
        }

        public override void btn_crear_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            //Valida que el formato de los datos ingresado sea correcto
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (btn_crear.Text == "Crear")
                {
                    //Da el alta de la herramienta
                    ng_Herramienta.Alta(txt_nombre.Text, txt_descripcion.Text);
                }
                else
                {
                    //Modfica la herramienta
                    herramienta.Nombre = txt_nombre.Text;
                    herramienta.Descripcion = txt_descripcion.Text;
                    herramienta.Guardar();
                }
                form_contenedor.ActualizarAlta();
                this.Close();
            }
        }
    }
}
