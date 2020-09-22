namespace TPI_NewWare.Formularios.Productos
{
    partial class FrmAMProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_descripcion = new TPI_NewWare.Clases.TextBox01();
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_denominacion = new System.Windows.Forms.Label();
            this.txt_denominacion = new TPI_NewWare.Clases.TextBox01();
            this.txt_fechaFin = new TPI_NewWare.Clases.TextBox01();
            this.lbl_fechaFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.FlatAppearance.BorderSize = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(16, 157);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensajeError = "\"Descripción vacia\"";
            this.txt_descripcion.Pp_nombre_campo = "\"descripcion\"";
            this.txt_descripcion.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_descripcion.Pp_validable = true;
            this.txt_descripcion.Size = new System.Drawing.Size(372, 85);
            this.txt_descripcion.TabIndex = 21;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(93, 63);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nombre.Pp_nombre_campo = "\"nombre\"";
            this.txt_nombre.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(295, 22);
            this.txt_nombre.TabIndex = 20;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 63);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre.TabIndex = 23;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 120);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.lbl_descripcion.TabIndex = 22;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_denominacion
            // 
            this.lbl_denominacion.AutoSize = true;
            this.lbl_denominacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_denominacion.ForeColor = System.Drawing.Color.White;
            this.lbl_denominacion.Location = new System.Drawing.Point(12, 268);
            this.lbl_denominacion.Name = "lbl_denominacion";
            this.lbl_denominacion.Size = new System.Drawing.Size(120, 20);
            this.lbl_denominacion.TabIndex = 24;
            this.lbl_denominacion.Text = "Denominacion:";
            // 
            // txt_denominacion
            // 
            this.txt_denominacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_denominacion.Location = new System.Drawing.Point(138, 268);
            this.txt_denominacion.Name = "txt_denominacion";
            this.txt_denominacion.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_denominacion.Pp_nombre_campo = "\"nombre\"";
            this.txt_denominacion.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_denominacion.Pp_validable = true;
            this.txt_denominacion.Size = new System.Drawing.Size(250, 22);
            this.txt_denominacion.TabIndex = 25;
            // 
            // txt_fechaFin
            // 
            this.txt_fechaFin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaFin.Location = new System.Drawing.Point(188, 310);
            this.txt_fechaFin.Name = "txt_fechaFin";
            this.txt_fechaFin.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_fechaFin.Pp_nombre_campo = "\"nombre\"";
            this.txt_fechaFin.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_fechaFin.Pp_validable = true;
            this.txt_fechaFin.Size = new System.Drawing.Size(200, 22);
            this.txt_fechaFin.TabIndex = 26;
            // 
            // lbl_fechaFin
            // 
            this.lbl_fechaFin.AutoSize = true;
            this.lbl_fechaFin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaFin.ForeColor = System.Drawing.Color.White;
            this.lbl_fechaFin.Location = new System.Drawing.Point(12, 312);
            this.lbl_fechaFin.Name = "lbl_fechaFin";
            this.lbl_fechaFin.Size = new System.Drawing.Size(170, 20);
            this.lbl_fechaFin.TabIndex = 27;
            this.lbl_fechaFin.Text = "Fecha de Finalización:";
            // 
            // FrmAMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lbl_fechaFin);
            this.Controls.Add(this.txt_fechaFin);
            this.Controls.Add(this.txt_denominacion);
            this.Controls.Add(this.lbl_denominacion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_descripcion);
            this.Name = "FrmAMProducto";
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.lbl_descripcion, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_descripcion, 0);
            this.Controls.SetChildIndex(this.lbl_denominacion, 0);
            this.Controls.SetChildIndex(this.txt_denominacion, 0);
            this.Controls.SetChildIndex(this.txt_fechaFin, 0);
            this.Controls.SetChildIndex(this.lbl_fechaFin, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_descripcion;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_denominacion;
        private Clases.TextBox01 txt_denominacion;
        private Clases.TextBox01 txt_fechaFin;
        private System.Windows.Forms.Label lbl_fechaFin;
    }
}
