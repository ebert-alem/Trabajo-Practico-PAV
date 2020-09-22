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


namespace TPI_NewWare.Formularios.Empleados
{
    public partial class FrmAMEmpleados : TPI_NewWare.Formularios.FrmAMBase
    {
        FrmABMBase form_contenedor;

        Ng_Empleado negocio = new Ng_Empleado();
        Empleado empleado;
        DataTable tabla = new DataTable();

        public FrmAMEmpleados(FrmABMBase form)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
        }

        public FrmAMEmpleados(FrmABMBase form, int id)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
            btn_crear.Text = "Modificar";

            //Se obtiene el objeto a modificar
            empleado = negocio.BuscarLegajo(id);

            //Se actualizan los campos del formulario con los atributos
            txt_nombre.Text = empleado.Nombre;
            txt_apellido.Text = empleado.Apellido;
            txt_legajo.Text = empleado.Legajo;
            txt_domicilio.Text = empleado.Domicilio;
            txt_Nacimiento.Text = empleado.FechaNacimiento;
            txt_NroDocumento.Text = empleado.Documento;
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
                    negocio.Alta(txt_legajo.Text, empleado.Id_Egreso, empleado.TipoDocumento, (string)cmb_usuario.SelectedItem, txt_NroDocumento.Text, txt_nombre.Text, txt_apellido.Text, DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss"), "-", (string) txt_domicilio.Text, txt_Nacimiento.Text, "1");
                }
                else
                {
                    //Modfica la herramienta
                    empleado.Nombre = txt_nombre.Text;
                    empleado.Apellido = txt_apellido.Text;
                    empleado.Legajo = txt_legajo.Text;
                    empleado.Domicilio = txt_domicilio.Text;
                    empleado.FechaNacimiento = txt_Nacimiento.Text;
                    empleado.Documento = txt_NroDocumento.Text;
                    empleado.Usuario = (string)cmb_usuario.SelectedItem;


                    empleado.Guardar();
                }
                form_contenedor.ActualizarAlta();
                this.Close();
            }
        }

        private void cmb_TipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TipDoc TiposDoc = new TipDoc();
            Ng_TipDoc ng_TipoDoc = new Ng_TipDoc();
            tabla.Clear();
            tabla = ng_TipoDoc.Consulta();

            if (tabla.Rows.Count != 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    cmb_TipoDoc.Items.Add(tabla.Rows[i]["nombreTipoDocumento"].ToString());
                }
            }

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i]["nombreTipoDocumento"].ToString() == (string)cmb_TipoDoc.SelectedItem) {
                    empleado.TipoDocumento = tabla.Rows[i]["id"].ToString();
                }
            }
        }

        private void cmb_Egreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ng_MotivoEgreso ng_Egreso = new Ng_MotivoEgreso();
            tabla.Clear();
            tabla = ng_Egreso.Consulta();

            if (tabla.Rows.Count != 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    cmb_Egreso.Items.Add(tabla.Rows[i]["nombre"].ToString()); 
                }
            }
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i]["nombre"].ToString() == (string)cmb_Egreso.SelectedItem)
                {
                    empleado.Id_Egreso = tabla.Rows[i]["id"].ToString();
                }
            }

        }

        private void cmb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ng_Usuario ng_usu = new Ng_Usuario();
            tabla.Clear();
            tabla = ng_usu.Consulta();

            if (tabla.Rows.Count != 0) 
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    cmb_usuario.Items.Add(tabla.Rows[i]["nombreUsuario"].ToString());
                }
            }
        }
    }
}
