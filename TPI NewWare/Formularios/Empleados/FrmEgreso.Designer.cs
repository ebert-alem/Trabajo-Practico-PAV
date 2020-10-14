namespace TPI_NewWare.Formularios.Empleados
{
    partial class FrmEgreso
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
            this.lbl_Egreso = new System.Windows.Forms.Label();
            this.txt_Egreso = new TPI_NewWare.Clases.TextBox01();
            this.cmb_Egreso = new TPI_NewWare.Clases.ComboBox01();
            this.lbl_OtroMotivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.FlatAppearance.BorderSize = 0;
            this.btn_crear.Text = "Aceptar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            // 
            // lbl_Egreso
            // 
            this.lbl_Egreso.AutoSize = true;
            this.lbl_Egreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Egreso.ForeColor = System.Drawing.Color.White;
            this.lbl_Egreso.Location = new System.Drawing.Point(29, 86);
            this.lbl_Egreso.Name = "lbl_Egreso";
            this.lbl_Egreso.Size = new System.Drawing.Size(143, 20);
            this.lbl_Egreso.TabIndex = 35;
            this.lbl_Egreso.Text = "Motivo de Egreso:";
            // 
            // txt_Egreso
            // 
            this.txt_Egreso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Egreso.Location = new System.Drawing.Point(33, 192);
            this.txt_Egreso.Multiline = true;
            this.txt_Egreso.Name = "txt_Egreso";
            this.txt_Egreso.Pp_mensajeError = "\"Descripción vacia\"";
            this.txt_Egreso.Pp_nombre_campo = "\"descripcion\"";
            this.txt_Egreso.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_Egreso.Pp_validable = true;
            this.txt_Egreso.Size = new System.Drawing.Size(333, 64);
            this.txt_Egreso.TabIndex = 37;
            // 
            // cmb_Egreso
            // 
            this.cmb_Egreso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Egreso.FormattingEnabled = true;
            this.cmb_Egreso.Location = new System.Drawing.Point(33, 109);
            this.cmb_Egreso.Name = "cmb_Egreso";
            this.cmb_Egreso.Pp_Display = "nombre";
            this.cmb_Egreso.Pp_mensajeError = null;
            this.cmb_Egreso.Pp_nombre_campo = null;
            this.cmb_Egreso.Pp_nombre_tabla = null;
            this.cmb_Egreso.Pp_seleccionado = false;
            this.cmb_Egreso.Pp_Tabla = "MOTIVOEGRESO";
            this.cmb_Egreso.Pp_validable = false;
            this.cmb_Egreso.Pp_Value = null;
            this.cmb_Egreso.Size = new System.Drawing.Size(333, 25);
            this.cmb_Egreso.TabIndex = 40;
            // 
            // lbl_OtroMotivo
            // 
            this.lbl_OtroMotivo.AutoSize = true;
            this.lbl_OtroMotivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OtroMotivo.ForeColor = System.Drawing.Color.White;
            this.lbl_OtroMotivo.Location = new System.Drawing.Point(29, 169);
            this.lbl_OtroMotivo.Name = "lbl_OtroMotivo";
            this.lbl_OtroMotivo.Size = new System.Drawing.Size(46, 20);
            this.lbl_OtroMotivo.TabIndex = 41;
            this.lbl_OtroMotivo.Text = "Otro:";
            // 
            // FrmEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lbl_OtroMotivo);
            this.Controls.Add(this.cmb_Egreso);
            this.Controls.Add(this.txt_Egreso);
            this.Controls.Add(this.lbl_Egreso);
            this.Name = "FrmEgreso";
            this.Load += new System.EventHandler(this.FrmEgresos_Load);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.lbl_Egreso, 0);
            this.Controls.SetChildIndex(this.txt_Egreso, 0);
            this.Controls.SetChildIndex(this.cmb_Egreso, 0);
            this.Controls.SetChildIndex(this.lbl_OtroMotivo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Egreso;
        private Clases.TextBox01 txt_Egreso;
        private Clases.ComboBox01 cmb_Egreso;
        private System.Windows.Forms.Label lbl_OtroMotivo;
    }
}
