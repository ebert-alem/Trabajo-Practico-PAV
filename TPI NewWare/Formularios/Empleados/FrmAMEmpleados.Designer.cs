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
            this.cmb_Egreso = new TPI_NewWare.Clases.ComboBox01();
            this.lbl_MotivoEgreso = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.cmb_usuario = new TPI_NewWare.Clases.ComboBox01();
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
            this.txt_nombre.Location = new System.Drawing.Point(110, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nombre.Pp_nombre_campo = "\"nombre\"";
            this.txt_nombre.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(256, 22);
            this.txt_nombre.TabIndex = 22;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(32, 88);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre.TabIndex = 23;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.Location = new System.Drawing.Point(110, 50);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_legajo.Pp_nombre_campo = "\"nombre\"";
            this.txt_legajo.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_legajo.Pp_validable = true;
            this.txt_legajo.Size = new System.Drawing.Size(256, 22);
            this.txt_legajo.TabIndex = 24;
            this.txt_legajo.Text = "Es un campo Autogenerado";
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legajo.ForeColor = System.Drawing.Color.White;
            this.lbl_legajo.Location = new System.Drawing.Point(41, 49);
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
            this.lbl_apellido.Location = new System.Drawing.Point(25, 122);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(79, 20);
            this.lbl_apellido.TabIndex = 26;
            this.lbl_apellido.Text = "Apellidos:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(110, 120);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_apellido.Pp_nombre_campo = "\"nombre\"";
            this.txt_apellido.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_apellido.Pp_validable = true;
            this.txt_apellido.Size = new System.Drawing.Size(256, 22);
            this.txt_apellido.TabIndex = 27;
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_domicilio.Location = new System.Drawing.Point(110, 155);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_domicilio.Pp_nombre_campo = "\"nombre\"";
            this.txt_domicilio.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_domicilio.Pp_validable = true;
            this.txt_domicilio.Size = new System.Drawing.Size(256, 22);
            this.txt_domicilio.TabIndex = 28;
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_domicilio.ForeColor = System.Drawing.Color.White;
            this.lbl_domicilio.Location = new System.Drawing.Point(25, 157);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(79, 20);
            this.lbl_domicilio.TabIndex = 29;
            this.lbl_domicilio.Text = "Domicilio:";
            // 
            // txt_NroDocumento
            // 
            this.txt_NroDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NroDocumento.Location = new System.Drawing.Point(177, 225);
            this.txt_NroDocumento.Name = "txt_NroDocumento";
            this.txt_NroDocumento.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_NroDocumento.Pp_nombre_campo = "\"nombre\"";
            this.txt_NroDocumento.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_NroDocumento.Pp_validable = true;
            this.txt_NroDocumento.Size = new System.Drawing.Size(189, 22);
            this.txt_NroDocumento.TabIndex = 30;
            // 
            // lbl_nroDoc
            // 
            this.lbl_nroDoc.AutoSize = true;
            this.lbl_nroDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_nroDoc.Location = new System.Drawing.Point(26, 225);
            this.lbl_nroDoc.Name = "lbl_nroDoc";
            this.lbl_nroDoc.Size = new System.Drawing.Size(145, 20);
            this.lbl_nroDoc.TabIndex = 33;
            this.lbl_nroDoc.Text = "N° de Documento:";
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.AutoSize = true;
            this.lbl_tipoDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_tipoDoc.Location = new System.Drawing.Point(15, 258);
            this.lbl_tipoDoc.Name = "lbl_tipoDoc";
            this.lbl_tipoDoc.Size = new System.Drawing.Size(156, 20);
            this.lbl_tipoDoc.TabIndex = 34;
            this.lbl_tipoDoc.Text = "Tipo de Documento:";
            // 
            // lbl_Nacimiento
            // 
            this.lbl_Nacimiento.AutoSize = true;
            this.lbl_Nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nacimiento.ForeColor = System.Drawing.Color.White;
            this.lbl_Nacimiento.Location = new System.Drawing.Point(0, 190);
            this.lbl_Nacimiento.Name = "lbl_Nacimiento";
            this.lbl_Nacimiento.Size = new System.Drawing.Size(171, 20);
            this.lbl_Nacimiento.TabIndex = 35;
            this.lbl_Nacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txt_Nacimiento
            // 
            this.txt_Nacimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nacimiento.Location = new System.Drawing.Point(177, 190);
            this.txt_Nacimiento.Name = "txt_Nacimiento";
            this.txt_Nacimiento.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_Nacimiento.Pp_nombre_campo = "\"nombre\"";
            this.txt_Nacimiento.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_Nacimiento.Pp_validable = true;
            this.txt_Nacimiento.Size = new System.Drawing.Size(189, 22);
            this.txt_Nacimiento.TabIndex = 36;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Items.AddRange(new object[] {
            "Elija una opción:"});
            this.cmb_TipoDoc.Location = new System.Drawing.Point(177, 260);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_Display = "nombreTipoDocumento";
            this.cmb_TipoDoc.Pp_mensajeError = null;
            this.cmb_TipoDoc.Pp_nombre_campo = null;
            this.cmb_TipoDoc.Pp_nombre_tabla = null;
            this.cmb_TipoDoc.Pp_seleccionado = false;
            this.cmb_TipoDoc.Pp_Tabla = "TIPDOC";
            this.cmb_TipoDoc.Pp_validable = false;
            this.cmb_TipoDoc.Pp_Value = "id";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(189, 21);
            this.cmb_TipoDoc.TabIndex = 38;
            // 
            // cmb_Egreso
            // 
            this.cmb_Egreso.FormattingEnabled = true;
            this.cmb_Egreso.Items.AddRange(new object[] {
            "Elija una opción:"});
            this.cmb_Egreso.Location = new System.Drawing.Point(177, 295);
            this.cmb_Egreso.Name = "cmb_Egreso";
            this.cmb_Egreso.Pp_Display = "nombre";
            this.cmb_Egreso.Pp_mensajeError = null;
            this.cmb_Egreso.Pp_nombre_campo = null;
            this.cmb_Egreso.Pp_nombre_tabla = null;
            this.cmb_Egreso.Pp_seleccionado = false;
            this.cmb_Egreso.Pp_Tabla = "MOTIVOEGRESO";
            this.cmb_Egreso.Pp_validable = false;
            this.cmb_Egreso.Pp_Value = "id";
            this.cmb_Egreso.Size = new System.Drawing.Size(189, 21);
            this.cmb_Egreso.TabIndex = 39;
            // 
            // lbl_MotivoEgreso
            // 
            this.lbl_MotivoEgreso.AutoSize = true;
            this.lbl_MotivoEgreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MotivoEgreso.ForeColor = System.Drawing.Color.White;
            this.lbl_MotivoEgreso.Location = new System.Drawing.Point(25, 293);
            this.lbl_MotivoEgreso.Name = "lbl_MotivoEgreso";
            this.lbl_MotivoEgreso.Size = new System.Drawing.Size(143, 20);
            this.lbl_MotivoEgreso.TabIndex = 40;
            this.lbl_MotivoEgreso.Text = "Motivo de Egreso:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(101, 331);
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
            this.cmb_usuario.Location = new System.Drawing.Point(177, 330);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Pp_Display = "nombreUsuario";
            this.cmb_usuario.Pp_mensajeError = null;
            this.cmb_usuario.Pp_nombre_campo = null;
            this.cmb_usuario.Pp_nombre_tabla = "USUARIOS";
            this.cmb_usuario.Pp_seleccionado = false;
            this.cmb_usuario.Pp_Tabla = null;
            this.cmb_usuario.Pp_validable = false;
            this.cmb_usuario.Pp_Value = "nombreUsuario";
            this.cmb_usuario.Size = new System.Drawing.Size(189, 21);
            this.cmb_usuario.TabIndex = 42;
            // 
            // FrmAMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.cmb_usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_MotivoEgreso);
            this.Controls.Add(this.cmb_Egreso);
            this.Controls.Add(this.cmb_TipoDoc);
            this.Controls.Add(this.txt_Nacimiento);
            this.Controls.Add(this.lbl_Nacimiento);
            this.Controls.Add(this.lbl_tipoDoc);
            this.Controls.Add(this.lbl_nroDoc);
            this.Controls.Add(this.txt_NroDocumento);
            this.Controls.Add(this.lbl_domicilio);
            this.Controls.Add(this.txt_domicilio);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_legajo);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FrmAMEmpleados";
            this.Load += new System.EventHandler(this.FrmAMEmpleados_Load);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_legajo, 0);
            this.Controls.SetChildIndex(this.lbl_legajo, 0);
            this.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.txt_domicilio, 0);
            this.Controls.SetChildIndex(this.lbl_domicilio, 0);
            this.Controls.SetChildIndex(this.txt_NroDocumento, 0);
            this.Controls.SetChildIndex(this.lbl_nroDoc, 0);
            this.Controls.SetChildIndex(this.lbl_tipoDoc, 0);
            this.Controls.SetChildIndex(this.lbl_Nacimiento, 0);
            this.Controls.SetChildIndex(this.txt_Nacimiento, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.cmb_TipoDoc, 0);
            this.Controls.SetChildIndex(this.cmb_Egreso, 0);
            this.Controls.SetChildIndex(this.lbl_MotivoEgreso, 0);
            this.Controls.SetChildIndex(this.lbl_Usuario, 0);
            this.Controls.SetChildIndex(this.cmb_usuario, 0);
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
        private Clases.ComboBox01 cmb_Egreso;
        private System.Windows.Forms.Label lbl_MotivoEgreso;
        private System.Windows.Forms.Label lbl_Usuario;
        private Clases.ComboBox01 cmb_usuario;
    }
}
