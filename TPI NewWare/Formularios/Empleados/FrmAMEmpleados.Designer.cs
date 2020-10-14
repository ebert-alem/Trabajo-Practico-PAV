namespace TPI_NewWare.Formularios.Empleados
{
    partial class FrmAMEmpleados
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
            this.txt_domicilio = new TPI_NewWare.Clases.TextBox01();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_Nacimiento = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ltxt_apellido = new TPI_NewWare.Clases.LabelText01();
            this.ltxt_Nombre = new TPI_NewWare.Clases.LabelText01();
            this.ltxt_legajo = new TPI_NewWare.Clases.LabelText01();
            this.cmb_Usuario = new TPI_NewWare.Clases.ComboBox01();
            this.ltxt_nacimiento = new TPI_NewWare.Clases.LabelText01();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_tipDoc = new TPI_NewWare.Clases.ComboBox01();
            this.ltxt_nroDoc = new TPI_NewWare.Clases.LabelText01();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // txt_domicilio
            // 
            this.txt_domicilio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_domicilio.Location = new System.Drawing.Point(173, 140);
            this.txt_domicilio.Multiline = true;
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_domicilio.Pp_nombre_campo = "\"nombre\"";
            this.txt_domicilio.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_domicilio.Pp_validable = true;
            this.txt_domicilio.Size = new System.Drawing.Size(192, 20);
            this.txt_domicilio.TabIndex = 28;
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_domicilio.ForeColor = System.Drawing.Color.White;
            this.lbl_domicilio.Location = new System.Drawing.Point(95, 140);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(79, 20);
            this.lbl_domicilio.TabIndex = 29;
            this.lbl_domicilio.Text = "Domicilio:";
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.AutoSize = true;
            this.lbl_tipoDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_tipoDoc.Location = new System.Drawing.Point(13, 31);
            this.lbl_tipoDoc.Name = "lbl_tipoDoc";
            this.lbl_tipoDoc.Size = new System.Drawing.Size(41, 20);
            this.lbl_tipoDoc.TabIndex = 34;
            this.lbl_tipoDoc.Text = "Tipo:";
            // 
            // lbl_Nacimiento
            // 
            this.lbl_Nacimiento.AutoSize = true;
            this.lbl_Nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nacimiento.ForeColor = System.Drawing.Color.White;
            this.lbl_Nacimiento.Location = new System.Drawing.Point(3, 178);
            this.lbl_Nacimiento.Name = "lbl_Nacimiento";
            this.lbl_Nacimiento.Size = new System.Drawing.Size(171, 20);
            this.lbl_Nacimiento.TabIndex = 35;
            this.lbl_Nacimiento.Text = "Fecha de Nacimiento:";
            this.lbl_Nacimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(105, 215);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(67, 20);
            this.lbl_Usuario.TabIndex = 41;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ltxt_apellido);
            this.groupBox1.Controls.Add(this.ltxt_Nombre);
            this.groupBox1.Controls.Add(this.ltxt_legajo);
            this.groupBox1.Controls.Add(this.cmb_Usuario);
            this.groupBox1.Controls.Add(this.lbl_Usuario);
            this.groupBox1.Controls.Add(this.txt_domicilio);
            this.groupBox1.Controls.Add(this.lbl_domicilio);
            this.groupBox1.Controls.Add(this.lbl_Nacimiento);
            this.groupBox1.Controls.Add(this.ltxt_nacimiento);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 268);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // ltxt_apellido
            // 
            this.ltxt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt_apellido.Location = new System.Drawing.Point(21, 98);
            this.ltxt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.ltxt_apellido.Name = "ltxt_apellido";
            this.ltxt_apellido.Pp_Etiqueta = "Apellido:";
            this.ltxt_apellido.Pp_mask = "LLLLLLLLLL";
            this.ltxt_apellido.Pp_mensajeError = null;
            this.ltxt_apellido.Pp_nombre_campo = null;
            this.ltxt_apellido.Pp_nombre_tabla = null;
            this.ltxt_apellido.Pp_ReadOnly = false;
            this.ltxt_apellido.Pp_Text = "";
            this.ltxt_apellido.Pp_validable = false;
            this.ltxt_apellido.Size = new System.Drawing.Size(347, 28);
            this.ltxt_apellido.TabIndex = 45;
            // 
            // ltxt_Nombre
            // 
            this.ltxt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt_Nombre.Location = new System.Drawing.Point(21, 62);
            this.ltxt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.ltxt_Nombre.Name = "ltxt_Nombre";
            this.ltxt_Nombre.Pp_Etiqueta = "Nombre:";
            this.ltxt_Nombre.Pp_mask = "LLLLLLLLLL";
            this.ltxt_Nombre.Pp_mensajeError = null;
            this.ltxt_Nombre.Pp_nombre_campo = null;
            this.ltxt_Nombre.Pp_nombre_tabla = null;
            this.ltxt_Nombre.Pp_ReadOnly = false;
            this.ltxt_Nombre.Pp_Text = "";
            this.ltxt_Nombre.Pp_validable = false;
            this.ltxt_Nombre.Size = new System.Drawing.Size(347, 28);
            this.ltxt_Nombre.TabIndex = 44;
            // 
            // ltxt_legajo
            // 
            this.ltxt_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt_legajo.Location = new System.Drawing.Point(21, 26);
            this.ltxt_legajo.Margin = new System.Windows.Forms.Padding(4);
            this.ltxt_legajo.Name = "ltxt_legajo";
            this.ltxt_legajo.Pp_Etiqueta = "Legajo:";
            this.ltxt_legajo.Pp_mask = "00000000";
            this.ltxt_legajo.Pp_mensajeError = null;
            this.ltxt_legajo.Pp_nombre_campo = null;
            this.ltxt_legajo.Pp_nombre_tabla = null;
            this.ltxt_legajo.Pp_ReadOnly = false;
            this.ltxt_legajo.Pp_Text = "";
            this.ltxt_legajo.Pp_validable = false;
            this.ltxt_legajo.Size = new System.Drawing.Size(348, 28);
            this.ltxt_legajo.TabIndex = 37;
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(173, 216);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Pp_Display = null;
            this.cmb_Usuario.Pp_mensajeError = null;
            this.cmb_Usuario.Pp_nombre_campo = null;
            this.cmb_Usuario.Pp_nombre_tabla = null;
            this.cmb_Usuario.Pp_seleccionado = false;
            this.cmb_Usuario.Pp_Tabla = null;
            this.cmb_Usuario.Pp_validable = false;
            this.cmb_Usuario.Pp_Value = null;
            this.cmb_Usuario.Size = new System.Drawing.Size(192, 24);
            this.cmb_Usuario.TabIndex = 43;
            // 
            // ltxt_nacimiento
            // 
            this.ltxt_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt_nacimiento.Location = new System.Drawing.Point(22, 173);
            this.ltxt_nacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.ltxt_nacimiento.Name = "ltxt_nacimiento";
            this.ltxt_nacimiento.Pp_Etiqueta = "";
            this.ltxt_nacimiento.Pp_mask = "00/00/0000";
            this.ltxt_nacimiento.Pp_mensajeError = null;
            this.ltxt_nacimiento.Pp_nombre_campo = null;
            this.ltxt_nacimiento.Pp_nombre_tabla = null;
            this.ltxt_nacimiento.Pp_ReadOnly = false;
            this.ltxt_nacimiento.Pp_Text = "  /  /";
            this.ltxt_nacimiento.Pp_validable = false;
            this.ltxt_nacimiento.Size = new System.Drawing.Size(347, 28);
            this.ltxt_nacimiento.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_tipDoc);
            this.groupBox2.Controls.Add(this.lbl_tipoDoc);
            this.groupBox2.Controls.Add(this.ltxt_nroDoc);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 72);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documento";
            // 
            // cmb_tipDoc
            // 
            this.cmb_tipDoc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipDoc.FormattingEnabled = true;
            this.cmb_tipDoc.Location = new System.Drawing.Point(60, 30);
            this.cmb_tipDoc.Name = "cmb_tipDoc";
            this.cmb_tipDoc.Pp_Display = "nombreTipoDocumento";
            this.cmb_tipDoc.Pp_mensajeError = null;
            this.cmb_tipDoc.Pp_nombre_campo = null;
            this.cmb_tipDoc.Pp_nombre_tabla = null;
            this.cmb_tipDoc.Pp_seleccionado = false;
            this.cmb_tipDoc.Pp_Tabla = "TIPDOC";
            this.cmb_tipDoc.Pp_validable = false;
            this.cmb_tipDoc.Pp_Value = null;
            this.cmb_tipDoc.Size = new System.Drawing.Size(128, 24);
            this.cmb_tipDoc.TabIndex = 35;
            // 
            // ltxt_nroDoc
            // 
            this.ltxt_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt_nroDoc.Location = new System.Drawing.Point(97, 26);
            this.ltxt_nroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.ltxt_nroDoc.Name = "ltxt_nroDoc";
            this.ltxt_nroDoc.Pp_Etiqueta = "Nro:";
            this.ltxt_nroDoc.Pp_mask = "00000000";
            this.ltxt_nroDoc.Pp_mensajeError = null;
            this.ltxt_nroDoc.Pp_nombre_campo = null;
            this.ltxt_nroDoc.Pp_nombre_tabla = null;
            this.ltxt_nroDoc.Pp_ReadOnly = false;
            this.ltxt_nroDoc.Pp_Text = "";
            this.ltxt_nroDoc.Pp_validable = false;
            this.ltxt_nroDoc.Size = new System.Drawing.Size(272, 28);
            this.ltxt_nroDoc.TabIndex = 36;
            // 
            // FrmAMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAMEmpleados";
            this.Load += new System.EventHandler(this.FrmAMEmpleados_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Clases.TextBox01 txt_domicilio;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.Label lbl_Nacimiento;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.ComboBox01 cmb_Usuario;
        private Clases.ComboBox01 cmb_tipDoc;
        private Clases.LabelText01 ltxt_nroDoc;
        private Clases.LabelText01 ltxt_nacimiento;
        private Clases.LabelText01 ltxt_apellido;
        private Clases.LabelText01 ltxt_Nombre;
        private Clases.LabelText01 ltxt_legajo;

        //this.Load += new System.EventHandler(this.FrmAMEmpleados_Load);
    }
}
