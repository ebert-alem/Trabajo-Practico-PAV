using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Clases;
using System.Data;

namespace TPI_NewWare.Clases
{
    class ComboBox01 : ComboBox 
    {
        public string Pp_Tabla { get; set; }
        public string Pp_Display { get; set; }
        public string Pp_Value { get; set; }
        public bool Pp_seleccionado { get; set;}

        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }

        Be_BaseDatos _BD = new Be_BaseDatos();

        public void Cargar()
        {
            string sql = "SELECT * FROM " + Pp_Tabla;
            this.DisplayMember = Pp_Display;
            this.ValueMember = Pp_Value;
            this.DataSource = _BD.Consulta(sql);
        }
        public void Cargar (string nombre_tabla, string display, string value)
        {
            string sql = "SELECT * FROM " + nombre_tabla;
            this.DisplayMember = display;
            this.ValueMember = value;
            this.DataSource = _BD.Consulta(sql);
        }
        public void Cargar (DataTable tabla, string display, string value)
        {
            this.DisplayMember = display;
            this.ValueMember = value;
            this.DataSource = tabla;
        }
        public void Cargar (EstructuraComboBox ec)
        {
            this.DisplayMember = ec.Display;
            this.ValueMember = ec.Value;
            this.DataSource = ec.Tabla;
        }

        public void CargarDobleDisplay(string nombre_tabla, string display1, string display2, string value)
        {
            string sql = "SELECT *, (" + display1 + "+ ' ' +" + display2 + ") AS concatenacion FROM " + nombre_tabla;
            
            this.DisplayMember = "concatenacion";
            this.ValueMember = value;
            this.DataSource = _BD.Consulta(sql);
        }
        public void CargarDobleValue(string nombre_tabla, string display1, string display2, string value1, string value2)
        {
            string sql = "SELECT *, (" + display1 + "+ ' ' +" + display2 + ") AS dobleDisplay, (Convert(varchar(20), " + value1 + ") + ', ' + Convert(varchar(20), " + value2 + ")) AS dobleValue FROM " + nombre_tabla;

            this.DisplayMember = "dobleDisplay";
            this.ValueMember = "dobleValue";
            this.DataSource = _BD.Consulta(sql); 
        }



    }
   
}
