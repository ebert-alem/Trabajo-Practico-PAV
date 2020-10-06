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
        Cliente cliente = new Cliente();
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
            ltxtDocumento.Controls["TxtDato"].Enabled = false;
            cmb_tipDoc.Enabled = false;

            //Se obtiene el objeto a modificar
            cliente = negocio.BuscarDocumento(id);

            //Se actualizan los campos del formulario con los atributos
            ltxtDocumento.Pp_Text = cliente.Documento;
            ltxtNombre.Pp_Text = cliente.Nombre;
            ltxtApellido.Pp_Text = cliente.Apellido;
            ltxtCalle.Pp_Text = cliente.Calle;
            ltxtNroCalle.Pp_Text = cliente.NumeroCalle;
            ltxtTelefono.Pp_Text = cliente.Telefono;
            ltxtEmail.Pp_Text = cliente.Email;

            //Bloquear los campos de la pk
            ltxtDocumento.Controls["TxtDato"].Enabled = false;
            cmb_tipDoc.Enabled = false;
            
        }

        private void FrmAMCliente_Load(object sender, EventArgs e)
        {
            //Carga el combobox del tipo de documento utilizando las propiedades del combobox
            cmb_tipDoc.Cargar();
            
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
                    negocio.Alta(ltxtDocumento.Pp_Text, cmb_tipDoc.SelectedValue.ToString(), ltxtNombre.Pp_Text, ltxtApellido.Pp_Text, ltxtTelefono.Text, ltxtCalle.Pp_Text, ltxtNroCalle.Pp_Text, ltxtEmail.Pp_Text, "1");
                }
                else
                {
                    //Modfica la herramienta
                    cliente.Nombre = ltxtNombre.Pp_Text;
                    cliente.Apellido = ltxtApellido.Pp_Text;
                    cliente.Calle = ltxtCalle.Pp_Text;
                    cliente.NumeroCalle = ltxtNroCalle.Pp_Text;
                    cliente.Telefono = ltxtTelefono.Pp_Text;
                    cliente.Email = ltxtEmail.Pp_Text;
                    //Toma la seleccion del combobox
                    //cliente.TipoDocumento = cmb_tipDoc.SelectedValue.ToString();
                    cliente.Guardar();

                }
                
                form_contenedor.ActualizarAlta();
                this.Close();
            }
        }

    }
}