using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace TPI_NewWare.Clases
{
    class Grid01 : DataGridView 
    {
        public string Pp_Formato { get; set; }

        public Grid01()
        {
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            AllowUserToResizeColumns = false;
        }
        /// <summary>
        /// Método para formatear la grilla que responde al formato "tituloColumna1, anchoColumna1, N; ..."
        /// </summary>
        /// <param name="formato"></param string>
        public void Formatear (string formato)
        {
            if (formato == "")
                return;
            Pp_Formato = formato;
            Formatear();
        }
        public void Formatear()
        {
            if (Pp_Formato == "")
                return;
            string[] columnas;
            columnas = Pp_Formato.Split(';');
            this.ColumnCount = columnas.Length;
            this.Font = new System.Drawing.Font("Arial", 10);
            for (int i = 0; i < this.ColumnCount; i++)
            {
                string[] valores = columnas[i].Split(',');
                this.Columns[i].HeaderText = valores[0].ToString();
                this.Columns[i].Width = int.Parse(valores[1].ToString());
                this.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.Columns[i].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
                if (valores.Length < 3)
                    this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                else
                    this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        public void Cargar(DataTable tabla)
        {
            int col = this.Columns.Count;
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                this.Rows.Add();
                for (int columna = 0; columna < col; columna++)
                {
                    this.Rows[fila].Cells[columna].Value = tabla.Rows[fila][columna].ToString();
                }
            }
        }
    }
}
