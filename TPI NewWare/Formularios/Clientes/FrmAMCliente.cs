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

namespace TPI_NewWare.Formularios.Clientes
{
    public partial class FrmAMCliente : TPI_NewWare.Formularios.FrmAMBase
    {
        FrmABMBase form_contenedor;

        Ng_Cliente negocio = new Ng_Cliente();
        Cliente cliente;
        DataTable tabla = new DataTable();

        public FrmAMCliente(FrmABMBase form)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
        }

        public FrmAMCliente(FrmABMBase form, int id)
        {
            InitializeComponent();
            //Seteo el panel contenedor como atributo
            form_contenedor = form;
            btn_crear.Text = "Modificar";

            //Se obtiene el objeto a modificar
            cliente = negocio.Buscar(id);

            //Se actualizan los campos del formulario con los atributos
            txt_NroDocumento.Text = cliente.Documento;
            txt_nombre.Text = cliente.Nombre;
            txt_apellido.Text = cliente.Apellido;
            txt_Calle.Text = cliente.Calle;
            txt_nroCalle.Text = cliente.NumeroCalle;
            txt_telefono.Text = cliente.Telefono;
            txt_email.Text = cliente.Email;
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
                    negocio.Alta(txt_NroDocumento.Text, (string)cmb_tipDoc.SelectedItem, txt_nombre.Text, txt_apellido.Text, txt_Calle.Text, txt_nroCalle.Text, txt_telefono.Text, txt_email.Text, "true");
                }
                else
                {
                    //Modfica la herramienta
                    cliente.Documento = txt_NroDocumento.Text;
                    cliente.TipoDocumento = (string)cmb_tipDoc.SelectedItem;
                    cliente.Nombre = txt_nombre.Text;
                    cliente.Apellido = txt_apellido.Text;
                    cliente.Calle = txt_Calle.Text;
                    cliente.NumeroCalle = txt_nroCalle.Text;
                    cliente.Telefono = txt_telefono.Text;
                    cliente.Email = txt_email.Text;

                    cliente.Guardar();
                }
                form_contenedor.ActualizarAlta();
                this.Close();
            }
        }


        private void cmb_tipDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ng_TipDoc ng_TipoDoc = new Ng_TipDoc();
            tabla.Clear();
            tabla = ng_TipoDoc.Consulta();

            if (tabla.Rows.Count != 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    cmb_tipDoc.Items.Add(tabla.Rows[i]["id"].ToString());
                }
            }
        }
    }
}