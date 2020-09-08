namespace TPI_NewWare.Formularios
{
    partial class FrmAMHerramientas
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
            this.txt_descripcion.Location = new System.Drawing.Point(40, 182);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensajeError = "\"Descripción vacia\"";
            this.txt_descripcion.Pp_nombre_campo = "\"descripcion\"";
            this.txt_descripcion.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_descripcion.Pp_validable = true;
            this.txt_descripcion.Size = new System.Drawing.Size(333, 85);
            this.txt_descripcion.TabIndex = 13;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(117, 88);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nombre.Pp_nombre_campo = "\"nombre\"";
            this.txt_nombre.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(256, 22);
            this.txt_nombre.TabIndex = 12;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 88);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre.TabIndex = 15;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_descripcion.Location = new System.Drawing.Point(36, 145);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.lbl_descripcion.TabIndex = 14;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // FrmAMHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_descripcion);
            this.Name = "FrmAMHerramientas";
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.lbl_descripcion, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_descripcion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_descripcion;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
    }
}
