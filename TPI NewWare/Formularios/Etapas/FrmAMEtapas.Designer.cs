namespace TPI_NewWare.Formularios.Etapas
{
    partial class FrmAMEtapas
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
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.lbl_nombre = new System.Windows.Forms.Label();
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
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(110, 86);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nombre.Pp_nombre_campo = "\"nombre\"";
            this.txt_nombre.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(256, 22);
            this.txt_nombre.TabIndex = 16;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(29, 86);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre.TabIndex = 17;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // FrmAMEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FrmAMEtapas";
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
    }
}
