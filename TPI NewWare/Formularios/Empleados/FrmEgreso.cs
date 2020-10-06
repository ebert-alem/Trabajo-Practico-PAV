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
    public partial class FrmEgreso : TPI_NewWare.Formularios.FrmAMBase
    {
        Ng_Empleado negocio = new Ng_Empleado();
        Empleado empleados;
        FrmABMBase form_contenedor;
        DataTable tabla = new DataTable();
        Ng_MotivoEgreso ng_Mot = new Ng_MotivoEgreso();

        public FrmEgreso(FrmABMBase form, int Legajo)
        {
            InitializeComponent();
            form_contenedor = form;

            empleados = negocio.BuscarLegajo(Legajo);

        }

        public override void btn_crear_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            //Valida que el formato de los datos ingresado sea correcto
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (txt_Egreso != null) {
                    ng_Mot.Alta(txt_Egreso.Text);
                }

                //encontrar el id y al empleado.
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (tabla.Rows[i]["nombre"].ToString() == (string)cmb_Egreso.SelectedItem)
                    {
                        empleados.Id_Egreso = tabla.Rows[i]["id"].ToString();
                    }
                }
                this.Close();
            }
        }
        public override void btn_cancelar_Click(object sender, EventArgs e)
        {
            form_contenedor.ActualizarCancelacion();
            this.Close();


        }
        private void cmb_Egreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ng_MotivoEgreso ng_Egreso = new Ng_MotivoEgreso();
            tabla.Clear();
            tabla = ng_Egreso.Consulta();

            //if (tabla.Rows.Count != 0)
            //{
            //    for (int i = 0; i < tabla.Rows.Count; i++)
            //    {
            //        cmb_Egreso.Items.Add(tabla.Rows[i]["id"].ToString());
            //    }
            //} cambiar esto PONER EL DE AXEL AAAAAAAAAAAA

            //for (int i = 0; i < tabla.Rows.Count; i++)
            //{
            //    if (tabla.Rows[i]["nombre"].ToString() == (string)cmb_Egreso.SelectedItem)
            //    {
            //        empleados.Id_Egreso = tabla.Rows[i]["id"].ToString();
            //    }
            //}

        }

    }
}
