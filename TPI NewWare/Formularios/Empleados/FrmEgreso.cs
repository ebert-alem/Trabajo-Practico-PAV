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

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                empleados.Id_Egreso = Convert.ToString(cmb_Egreso.SelectedValue);
                empleados.Guardar();
            }
        }
        public override void btn_cancelar_Click(object sender, EventArgs e)
        {
            form_contenedor.ActualizarCancelacion();
            this.Close();
        }

        private void FrmEgresos_Load(object sender, EventArgs e) 
        {
            cmb_Egreso.Cargar();
        }
            //Ng_MotivoEgreso ng_Egreso = new Ng_MotivoEgreso();
            //tabla.Clear();
            //tabla = ng_Egreso.Consulta();

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
