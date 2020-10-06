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
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_legajo = new TPI_NewWare.Clases.TextBox01();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new TPI_NewWare.Clases.TextBox01();
            this.txt_domicilio = new TPI_NewWare.Clases.TextBox01();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.txt_NroDocumento = new TPI_NewWare.Clases.TextBox01();
            this.lbl_nroDoc = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_Nacimiento = new System.Windows.Forms.Label();
            this.txt_Nacimiento = new TPI_NewWare.Clases.TextBox01();
            this.cmb_TipoDoc = new TPI_NewWare.Clases.ComboBox01();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.cmb_usuario = new TPI_NewWare.Clases.ComboBox01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(114, 72);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nombre.Pp_nombre_campo = "\"nombre\"";
            this.txt_nombre.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(240, 22);
            this.txt_nombre.TabIndex = 22;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 72);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre.TabIndex = 23;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.Location = new System.Drawing.Point(114, 44);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_legajo.Pp_nombre_campo = "\"nombre\"";
            this.txt_legajo.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_legajo.Pp_validable = true;
            this.txt_legajo.Size = new System.Drawing.Size(240, 22);
            this.txt_legajo.TabIndex = 24;
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legajo.ForeColor = System.Drawing.Color.White;
            this.lbl_legajo.Location = new System.Drawing.Point(45, 44);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(63, 20);
            this.lbl_legajo.TabIndex = 25;
            this.lbl_legajo.Text = "Legajo:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_apellido.Location = new System.Drawing.Point(29, 100);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(79, 20);
            this.lbl_apellido.TabIndex = 26;
            this.lbl_apellido.Text = "Apellidos:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(114, 100);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_apellido.Pp_nombre_campo = "\"nombre\"";
            this.txt_apellido.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_apellido.Pp_validable = true;
            this.txt_apellido.Size = new System.Drawing.Size(240, 22);
            this.txt_apellido.TabIndex = 27;
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_domicilio.Location = new System.Drawing.Point(114, 128);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_domicilio.Pp_nombre_campo = "\"nombre\"";
            this.txt_domicilio.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_domicilio.Pp_validable = true;
            this.txt_domicilio.Size = new System.Drawing.Size(240, 22);
            this.txt_domicilio.TabIndex = 28;
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_domicilio.ForeColor = System.Drawing.Color.White;
            this.lbl_domicilio.Location = new System.Drawing.Point(29, 128);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(79, 20);
            this.lbl_domicilio.TabIndex = 29;
            this.lbl_domicilio.Text = "Domicilio:";
            // 
            // txt_NroDocumento
            // 
            this.txt_NroDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NroDocumento.Location = new System.Drawing.Point(239, 30);
            this.txt_NroDocumento.Name = "txt_NroDocumento";
            this.txt_NroDocumento.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_NroDocumento.Pp_nombre_campo = "\"nombre\"";
            this.txt_NroDocumento.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_NroDocumento.Pp_validable = true;
            this.txt_NroDocumento.Size = new System.Drawing.Size(115, 22);
            this.txt_NroDocumento.TabIndex = 30;
            // 
            // lbl_nroDoc
            // 
            this.lbl_nroDoc.AutoSize = true;
            this.lbl_nroDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_nroDoc.Location = new System.Drawing.Point(194, 27);
            this.lbl_nroDoc.Name = "lbl_nroDoc";
            this.lbl_nroDoc.Size = new System.Drawing.Size(39, 20);
            this.lbl_nroDoc.TabIndex = 33;
            this.lbl_nroDoc.Text = "Nro:";
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.AutoSize = true;
            this.lbl_tipoDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_tipoDoc.Location = new System.Drawing.Point(13, 27);
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
            this.lbl_Nacimiento.Location = new System.Drawing.Point(11, 148);
            this.lbl_Nacimiento.Name = "lbl_Nacimiento";
            this.lbl_Nacimiento.Size = new System.Drawing.Size(97, 40);
            this.lbl_Nacimiento.TabIndex = 35;
            this.lbl_Nacimiento.Text = "Fecha de \r\nNacimiento:";
            this.lbl_Nacimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Nacimiento
            // 
            this.txt_Nacimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nacimiento.Location = new System.Drawing.Point(114, 156);
            this.txt_Nacimiento.Name = "txt_Nacimiento";
            this.txt_Nacimiento.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_Nacimiento.Pp_nombre_campo = "\"nombre\"";
            this.txt_Nacimiento.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_Nacimiento.Pp_validable = true;
            this.txt_Nacimiento.Size = new System.Drawing.Size(240, 22);
            this.txt_Nacimiento.TabIndex = 36;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Items.AddRange(new object[] {
            "Elija una opción:"});
            this.cmb_TipoDoc.Location = new System.Drawing.Point(60, 24);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_Display = null;
            this.cmb_TipoDoc.Pp_mensajeError = null;
            this.cmb_TipoDoc.Pp_nombre_campo = null;
            this.cmb_TipoDoc.Pp_nombre_tabla = null;
            this.cmb_TipoDoc.Pp_seleccionado = false;
            this.cmb_TipoDoc.Pp_Tabla = null;
            this.cmb_TipoDoc.Pp_validable = false;
            this.cmb_TipoDoc.Pp_Value = null;
            this.cmb_TipoDoc.Size = new System.Drawing.Size(128, 28);
            this.cmb_TipoDoc.TabIndex = 38;
            this.cmb_TipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoDoc_SelectedIndexChanged);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(41, 321);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(67, 20);
            this.lbl_Usuario.TabIndex = 41;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Items.AddRange(new object[] {
            "Elija una opción:"});
            this.cmb_usuario.Location = new System.Drawing.Point(126, 321);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Pp_Display = null;
            this.cmb_usuario.Pp_mensajeError = null;
            this.cmb_usuario.Pp_nombre_campo = null;
            this.cmb_usuario.Pp_nombre_tabla = null;
            this.cmb_usuario.Pp_seleccionado = false;
            this.cmb_usuario.Pp_Tabla = null;
            this.cmb_usuario.Pp_validable = false;
            this.cmb_usuario.Pp_Value = null;
            this.cmb_usuario.Size = new System.Drawing.Size(240, 21);
            this.cmb_usuario.TabIndex = 42;
            this.cmb_usuario.SelectedIndexChanged += new System.EventHandler(this.cmb_usuario_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_legajo);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_legajo);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Controls.Add(this.txt_domicilio);
            this.groupBox1.Controls.Add(this.lbl_domicilio);
            this.groupBox1.Controls.Add(this.txt_Nacimiento);
            this.groupBox1.Controls.Add(this.lbl_Nacimiento);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 207);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_nroDoc);
            this.groupBox2.Controls.Add(this.lbl_tipoDoc);
            this.groupBox2.Controls.Add(this.cmb_TipoDoc);
            this.groupBox2.Controls.Add(this.txt_NroDocumento);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 72);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documento";
            // 
            // FrmAMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "FrmAMEmpleados";
            this.Controls.SetChildIndex(this.lbl_Usuario, 0);
            this.Controls.SetChildIndex(this.cmb_usuario, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private Clases.TextBox01 txt_legajo;
        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.Label lbl_apellido;
        private Clases.TextBox01 txt_apellido;
        private Clases.TextBox01 txt_domicilio;
        private System.Windows.Forms.Label lbl_domicilio;
        private Clases.TextBox01 txt_NroDocumento;
        private System.Windows.Forms.Label lbl_nroDoc;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.Label lbl_Nacimiento;
        private Clases.TextBox01 txt_Nacimiento;
        private Clases.ComboBox01 cmb_TipoDoc;
        private System.Windows.Forms.Label lbl_Usuario;
        private Clases.ComboBox01 cmb_usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
