namespace TPI_NewWare.Clases
{
    partial class Exporador01
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_etiqueta = new System.Windows.Forms.Label();
            this.txt_id = new TPI_NewWare.Clases.TextBox01();
            this.cmb_combo = new TPI_NewWare.Clases.ComboBox01();
            this.txt_descripcion = new TPI_NewWare.Clases.TextBox01();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_etiqueta
            // 
            this.lbl_etiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etiqueta.Location = new System.Drawing.Point(16, 1);
            this.lbl_etiqueta.Name = "lbl_etiqueta";
            this.lbl_etiqueta.Size = new System.Drawing.Size(121, 22);
            this.lbl_etiqueta.TabIndex = 5;
            this.lbl_etiqueta.Text = "label1";
            this.lbl_etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(143, 1);
            this.txt_id.Name = "txt_id";
            this.txt_id.Pp_mensajeError = null;
            this.txt_id.Pp_nombre_campo = null;
            this.txt_id.Pp_nombre_tabla = null;
            this.txt_id.Pp_validable = false;
            this.txt_id.Size = new System.Drawing.Size(41, 22);
            this.txt_id.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_id, "Ingrese el id o un text (patrón de búsqueda)");
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // cmb_combo
            // 
            this.cmb_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_combo.FormattingEnabled = true;
            this.cmb_combo.Location = new System.Drawing.Point(142, 0);
            this.cmb_combo.Name = "cmb_combo";
            this.cmb_combo.Pp_Display = null;
            this.cmb_combo.Pp_mensajeError = null;
            this.cmb_combo.Pp_nombre_campo = null;
            this.cmb_combo.Pp_nombre_tabla = null;
            this.cmb_combo.Pp_seleccionado = false;
            this.cmb_combo.Pp_Tabla = null;
            this.cmb_combo.Pp_validable = false;
            this.cmb_combo.Pp_Value = null;
            this.cmb_combo.Size = new System.Drawing.Size(274, 24);
            this.cmb_combo.TabIndex = 3;
            this.cmb_combo.Visible = false;
            this.cmb_combo.SelectionChangeCommitted += new System.EventHandler(this.cmb_combo_SelectionChangeCommitted);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(190, 1);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensajeError = null;
            this.txt_descripcion.Pp_nombre_campo = null;
            this.txt_descripcion.Pp_nombre_tabla = null;
            this.txt_descripcion.Pp_validable = false;
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(192, 22);
            this.txt_descripcion.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(387, 0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 25);
            this.btn_buscar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_buscar, "Ver la lista completa de datos");
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Exporador01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_etiqueta);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.cmb_combo);
            this.Name = "Exporador01";
            this.Size = new System.Drawing.Size(419, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox01 txt_descripcion;
        private ComboBox01 cmb_combo;
        private TextBox01 txt_id;
        private System.Windows.Forms.Label lbl_etiqueta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_buscar;
    }
}
