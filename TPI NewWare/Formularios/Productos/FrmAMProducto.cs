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

namespace TPI_NewWare.Formularios.Productos
{
    public partial class FrmAMProducto : TPI_NewWare.Formularios.FrmAMBase
    {
        FrmABMBase form_contenedor;
        Ng_Producto negocio = new Ng_Producto();
        Producto producto;

        public FrmAMProducto(FrmABMBase form)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
        }
        public FrmAMProducto(FrmABMBase form, int id)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
            btn_crear.Text = "Modificar";

            //Se obtiene el objeto a modificar
            producto = negocio.Buscar(id);
            //Se actualizan los campos del formulario con los atributos
            txt_nombre.Text = producto.Nombre;
            txt_descripcion.Text = producto.Descripcion;
            txt_denominacion.Text = producto.Denominacion;
            txt_fechaFin.Text = producto.FechaFinDesarrollo;
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
                    negocio.Alta(txt_nombre.Text, txt_descripcion.Text, txt_denominacion.Text, txt_fechaFin.Text);
                }
                else
                {
                    //Modfica la herramienta
                    producto.Nombre = txt_nombre.Text;
                    producto.Descripcion = txt_descripcion.Text;
                    producto.Denominacion = txt_denominacion.Text;
                    producto.FechaFinDesarrollo = txt_fechaFin.Text;
                    producto.Guardar();
                }
                form_contenedor.ActualizarAlta();
                this.Close();
            }
        }
    }
}
