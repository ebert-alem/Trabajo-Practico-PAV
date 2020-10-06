using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Clases;

namespace TPI_NewWare.Clases
{
    public partial class Exporador01 : UserControl
    {
        public string Pp_Etiqueta
        {
            get { return lbl_etiqueta.Text; }
            set { lbl_etiqueta.Text = value; }
        }
        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }

        public string Pp_Text
        {
            get { return txt_id.Text; }
            set { txt_id.Text = value; }
        }
        public string Pp_display { get; set; }
        public string Pp_value { get; set; }
        public string Pp_tabla { get; set; }

        Be_BaseDatos _BD = new Be_BaseDatos();
        
        public Exporador01()
        {
            InitializeComponent();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_id.Text=="")
            {
                txt_descripcion.Text = "";
                return;
            }
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar== (char)Keys.Tab)
            {
                try
                {
                    int.Parse(txt_id.Text);
                    BuscarId(txt_id.Text);
                }
                catch (Exception)
                {
                    BuscarDesc(txt_id.Text);                    
                }
            }
        }
        private void BuscarDesc(string descripcion)
        {
            string sql = "SELECT " + Pp_value + ", " + Pp_display
                        + " FROM " + Pp_tabla
                        + " WHERE " + Pp_display + " like '%" + descripcion + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 1)
            {
                txt_id.Text = tabla.Rows[0][0].ToString();
                txt_descripcion.Text = tabla.Rows[0][1].ToString();
            }
            else
            {
                cmb_combo.Cargar(tabla, Pp_display, Pp_value);
                ComboVisible();
            }
        }
        public void BuscarId(string id_usuario)
        {
            string sql = "SELECT " + Pp_value + ", " + Pp_display
                        + " FROM " + Pp_tabla
                        + " WHERE " + Pp_value + " = " + id_usuario;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count==1)
            {
                txt_id.Text = tabla.Rows[0][0].ToString();
                txt_descripcion.Text = tabla.Rows[0][1].ToString();
            }
            else
            {
                cmb_combo.Cargar(Pp_tabla, Pp_display, Pp_value);
                ComboVisible();
            }
        }
        private void ComboVisible()
        {
            if (cmb_combo.Visible==true)
            {
                cmb_combo.Visible = false;
                txt_id.Visible = true;
                txt_descripcion.Visible = true;
                btn_buscar.Visible = true;
            }
            else
            {
                cmb_combo.Visible = true;
                txt_id.Visible = false;
                txt_descripcion.Visible = false;
                btn_buscar.Visible = false;
                cmb_combo.DroppedDown = true;
            }
        }

        private void cmb_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_id.Text = cmb_combo.SelectedValue.ToString();
            BuscarId(txt_id.Text);
            ComboVisible();
            txt_id.Focus();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cmb_combo.Cargar(Pp_tabla, Pp_display, Pp_value);
            ComboVisible();
        }
    }
}
