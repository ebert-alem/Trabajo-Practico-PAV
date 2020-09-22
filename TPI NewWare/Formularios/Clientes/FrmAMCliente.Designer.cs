namespace TPI_NewWare.Formularios.Clientes
{
    partial class FrmAMCliente
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
            this.lbl_nroDoc = new System.Windows.Forms.Label();
            this.txt_NroDocumento = new TPI_NewWare.Clases.TextBox01();
            this.lbl_tipDoc = new System.Windows.Forms.Label();
            this.cmb_tipDoc = new TPI_NewWare.Clases.ComboBox01();
            this.txt_apellido = new TPI_NewWare.Clases.TextBox01();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.txt_Calle = new TPI_NewWare.Clases.TextBox01();
            this.lbl_nroCalle = new System.Windows.Forms.Label();
            this.txt_nroCalle = new TPI_NewWare.Clases.TextBox01();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new TPI_NewWare.Clases.TextBox01();
            this.txt_email = new TPI_NewWare.Clases.TextBox01();
            this.lbl_email = new System.Windows.Forms.Label();
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
            // lbl_nroDoc
            // 
            this.lbl_nroDoc.AutoSize = true;
            this.lbl_nroDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_nroDoc.Location = new System.Drawing.Point(20, 71);
            this.lbl_nroDoc.Name = "lbl_nroDoc";
            this.lbl_nroDoc.Size = new System.Drawing.Size(145, 20);
            this.lbl_nroDoc.TabIndex = 34;
            this.lbl_nroDoc.Text = "N° de Documento:";
            // 
            // txt_NroDocumento
            // 
            this.txt_NroDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NroDocumento.Location = new System.Drawing.Point(182, 71);
            this.txt_NroDocumento.Name = "txt_NroDocumento";
            this.txt_NroDocumento.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_NroDocumento.Pp_nombre_campo = "\"nombre\"";
            this.txt_NroDocumento.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_NroDocumento.Pp_validable = true;
            this.txt_NroDocumento.Size = new System.Drawing.Size(189, 22);
            this.txt_NroDocumento.TabIndex = 35;
            // 
            // lbl_tipDoc
            // 
            this.lbl_tipDoc.AutoSize = true;
            this.lbl_tipDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_tipDoc.Location = new System.Drawing.Point(20, 106);
            this.lbl_tipDoc.Name = "lbl_tipDoc";
            this.lbl_tipDoc.Size = new System.Drawing.Size(156, 20);
            this.lbl_tipDoc.TabIndex = 36;
            this.lbl_tipDoc.Text = "Tipo de Documento:";
            // 
            // cmb_tipDoc
            // 
            this.cmb_tipDoc.FormattingEnabled = true;
            this.cmb_tipDoc.Items.AddRange(new object[] {
            "Elija una opcion:"});
            this.cmb_tipDoc.Location = new System.Drawing.Point(182, 106);
            this.cmb_tipDoc.Name = "cmb_tipDoc";
            this.cmb_tipDoc.Pp_Display = null;
            this.cmb_tipDoc.Pp_mensajeError = null;
            this.cmb_tipDoc.Pp_nombre_campo = null;
            this.cmb_tipDoc.Pp_nombre_tabla = null;
            this.cmb_tipDoc.Pp_seleccionado = false;
            this.cmb_tipDoc.Pp_Tabla = null;
            this.cmb_tipDoc.Pp_validable = false;
            this.cmb_tipDoc.Pp_Value = null;
            this.cmb_tipDoc.Size = new System.Drawing.Size(189, 21);
            this.cmb_tipDoc.TabIndex = 37;
            this.cmb_tipDoc.SelectedIndexChanged += new System.EventHandler(this.cmb_tipDoc_SelectedIndexChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(115, 176);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_apellido.Pp_nombre_campo = "\"nombre\"";
            this.txt_apellido.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_apellido.Pp_validable = true;
            this.txt_apellido.Size = new System.Drawing.Size(256, 22);
            this.txt_apellido.TabIndex = 41;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_apellido.Location = new System.Drawing.Point(20, 176);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(79, 20);
            this.lbl_apellido.TabIndex = 40;
            this.lbl_apellido.Text = "Apellidos:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(115, 141);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nombre.Pp_nombre_campo = "\"nombre\"";
            this.txt_nombre.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(256, 22);
            this.txt_nombre.TabIndex = 38;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(20, 141);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre.TabIndex = 39;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calle.ForeColor = System.Drawing.Color.White;
            this.lbl_Calle.Location = new System.Drawing.Point(20, 212);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(51, 20);
            this.lbl_Calle.TabIndex = 42;
            this.lbl_Calle.Text = "Calle:";
            // 
            // txt_Calle
            // 
            this.txt_Calle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Calle.Location = new System.Drawing.Point(77, 212);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_Calle.Pp_nombre_campo = "\"nombre\"";
            this.txt_Calle.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_Calle.Pp_validable = true;
            this.txt_Calle.Size = new System.Drawing.Size(156, 22);
            this.txt_Calle.TabIndex = 43;
            // 
            // lbl_nroCalle
            // 
            this.lbl_nroCalle.AutoSize = true;
            this.lbl_nroCalle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroCalle.ForeColor = System.Drawing.Color.White;
            this.lbl_nroCalle.Location = new System.Drawing.Point(239, 212);
            this.lbl_nroCalle.Name = "lbl_nroCalle";
            this.lbl_nroCalle.Size = new System.Drawing.Size(39, 20);
            this.lbl_nroCalle.TabIndex = 44;
            this.lbl_nroCalle.Text = "Nro:";
            // 
            // txt_nroCalle
            // 
            this.txt_nroCalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroCalle.Location = new System.Drawing.Point(284, 212);
            this.txt_nroCalle.Name = "txt_nroCalle";
            this.txt_nroCalle.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nroCalle.Pp_nombre_campo = "\"nombre\"";
            this.txt_nroCalle.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nroCalle.Pp_validable = true;
            this.txt_nroCalle.Size = new System.Drawing.Size(87, 22);
            this.txt_nroCalle.TabIndex = 45;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_telefono.Location = new System.Drawing.Point(20, 250);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(75, 20);
            this.lbl_telefono.TabIndex = 46;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(115, 250);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_telefono.Pp_nombre_campo = "\"nombre\"";
            this.txt_telefono.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_telefono.Pp_validable = true;
            this.txt_telefono.Size = new System.Drawing.Size(256, 22);
            this.txt_telefono.TabIndex = 47;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(115, 285);
            this.txt_email.Name = "txt_email";
            this.txt_email.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_email.Pp_nombre_campo = "\"nombre\"";
            this.txt_email.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_email.Pp_validable = true;
            this.txt_email.Size = new System.Drawing.Size(256, 22);
            this.txt_email.TabIndex = 48;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(20, 285);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 20);
            this.lbl_email.TabIndex = 49;
            this.lbl_email.Text = "Email:";
            // 
            // FrmAMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_nroCalle);
            this.Controls.Add(this.lbl_nroCalle);
            this.Controls.Add(this.txt_Calle);
            this.Controls.Add(this.lbl_Calle);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.cmb_tipDoc);
            this.Controls.Add(this.lbl_tipDoc);
            this.Controls.Add(this.txt_NroDocumento);
            this.Controls.Add(this.lbl_nroDoc);
            this.Name = "FrmAMCliente";
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.lbl_nroDoc, 0);
            this.Controls.SetChildIndex(this.txt_NroDocumento, 0);
            this.Controls.SetChildIndex(this.lbl_tipDoc, 0);
            this.Controls.SetChildIndex(this.cmb_tipDoc, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.lbl_Calle, 0);
            this.Controls.SetChildIndex(this.txt_Calle, 0);
            this.Controls.SetChildIndex(this.lbl_nroCalle, 0);
            this.Controls.SetChildIndex(this.txt_nroCalle, 0);
            this.Controls.SetChildIndex(this.lbl_telefono, 0);
            this.Controls.SetChildIndex(this.txt_telefono, 0);
            this.Controls.SetChildIndex(this.txt_email, 0);
            this.Controls.SetChildIndex(this.lbl_email, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nroDoc;
        private Clases.TextBox01 txt_NroDocumento;
        private System.Windows.Forms.Label lbl_tipDoc;
        private Clases.ComboBox01 cmb_tipDoc;
        private Clases.TextBox01 txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_Calle;
        private Clases.TextBox01 txt_Calle;
        private System.Windows.Forms.Label lbl_nroCalle;
        private Clases.TextBox01 txt_nroCalle;
        private System.Windows.Forms.Label lbl_telefono;
        private Clases.TextBox01 txt_telefono;
        private Clases.TextBox01 txt_email;
        private System.Windows.Forms.Label lbl_email;
    }
}
