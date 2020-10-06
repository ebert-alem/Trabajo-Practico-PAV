using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_NewWare.Clases
{
    public partial class LabelText01 : UserControl
    {
     
        public string Pp_Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }
        public string Pp_mask 
       {
            get { return TxtDato.Mask; }
            set
            {
                TxtDato.Mask = value;
            }
        } 
        public string Pp_Text
        {
            get { return TxtDato.Text; }
            set { TxtDato.Text = value; }
        }

        public bool Pp_ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }
     
        public LabelText01()
        {
            InitializeComponent();
        }
    }
}
