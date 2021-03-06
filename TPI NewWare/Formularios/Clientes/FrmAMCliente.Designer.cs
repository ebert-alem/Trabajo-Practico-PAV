﻿namespace TPI_NewWare.Formularios.Clientes
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
            this.lbl_tipDoc = new System.Windows.Forms.Label();
            this.cmb_tipDoc = new TPI_NewWare.Clases.ComboBox01();
            this.ltxtDocumento = new TPI_NewWare.Clases.LabelText01();
            this.ltxtNombre = new TPI_NewWare.Clases.LabelText01();
            this.ltxtApellido = new TPI_NewWare.Clases.LabelText01();
            this.ltxtCalle = new TPI_NewWare.Clases.LabelText01();
            this.ltxtNroCalle = new TPI_NewWare.Clases.LabelText01();
            this.ltxtTelefono = new TPI_NewWare.Clases.LabelText01();
            this.ltxtEmail = new TPI_NewWare.Clases.LabelText01();
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
            // lbl_tipDoc
            // 
            this.lbl_tipDoc.AutoSize = true;
            this.lbl_tipDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipDoc.ForeColor = System.Drawing.Color.White;
            this.lbl_tipDoc.Location = new System.Drawing.Point(12, 107);
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
            this.cmb_tipDoc.Location = new System.Drawing.Point(174, 106);
            this.cmb_tipDoc.Name = "cmb_tipDoc";
            this.cmb_tipDoc.Pp_Display = "nombreTipoDocumento";
            this.cmb_tipDoc.Pp_mensajeError = null;
            this.cmb_tipDoc.Pp_nombre_campo = "";
            this.cmb_tipDoc.Pp_nombre_tabla = "";
            this.cmb_tipDoc.Pp_seleccionado = false;
            this.cmb_tipDoc.Pp_Tabla = "TIPDOC";
            this.cmb_tipDoc.Pp_validable = false;
            this.cmb_tipDoc.Pp_Value = "id";
            this.cmb_tipDoc.Size = new System.Drawing.Size(193, 21);
            this.cmb_tipDoc.TabIndex = 37;
            // 
            // ltxtDocumento
            // 
            this.ltxtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtDocumento.ForeColor = System.Drawing.Color.White;
            this.ltxtDocumento.Location = new System.Drawing.Point(24, 71);
            this.ltxtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.ltxtDocumento.Name = "ltxtDocumento";
            this.ltxtDocumento.Pp_Etiqueta = "N de Documento:";
            this.ltxtDocumento.Pp_mask = "00000000";
            this.ltxtDocumento.Pp_mensajeError = null;
            this.ltxtDocumento.Pp_nombre_campo = null;
            this.ltxtDocumento.Pp_nombre_tabla = null;
            this.ltxtDocumento.Pp_ReadOnly = false;
            this.ltxtDocumento.Pp_Text = "";
            this.ltxtDocumento.Pp_validable = false;
            this.ltxtDocumento.Size = new System.Drawing.Size(347, 28);
            this.ltxtDocumento.TabIndex = 51;
            // 
            // ltxtNombre
            // 
            this.ltxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtNombre.ForeColor = System.Drawing.Color.White;
            this.ltxtNombre.Location = new System.Drawing.Point(24, 134);
            this.ltxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.ltxtNombre.Name = "ltxtNombre";
            this.ltxtNombre.Pp_Etiqueta = "Nombre:";
            this.ltxtNombre.Pp_mask = "LLLLLLLLLLLLLLLLLLLL";
            this.ltxtNombre.Pp_mensajeError = null;
            this.ltxtNombre.Pp_nombre_campo = null;
            this.ltxtNombre.Pp_nombre_tabla = null;
            this.ltxtNombre.Pp_ReadOnly = false;
            this.ltxtNombre.Pp_Text = "";
            this.ltxtNombre.Pp_validable = false;
            this.ltxtNombre.Size = new System.Drawing.Size(347, 28);
            this.ltxtNombre.TabIndex = 52;
            // 
            // ltxtApellido
            // 
            this.ltxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtApellido.ForeColor = System.Drawing.Color.White;
            this.ltxtApellido.Location = new System.Drawing.Point(24, 170);
            this.ltxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.ltxtApellido.Name = "ltxtApellido";
            this.ltxtApellido.Pp_Etiqueta = "Apellidos:";
            this.ltxtApellido.Pp_mask = "LLLLLLLLLLLLLLLLLLLL";
            this.ltxtApellido.Pp_mensajeError = null;
            this.ltxtApellido.Pp_nombre_campo = null;
            this.ltxtApellido.Pp_nombre_tabla = null;
            this.ltxtApellido.Pp_ReadOnly = false;
            this.ltxtApellido.Pp_Text = "";
            this.ltxtApellido.Pp_validable = false;
            this.ltxtApellido.Size = new System.Drawing.Size(347, 28);
            this.ltxtApellido.TabIndex = 53;
            // 
            // ltxtCalle
            // 
            this.ltxtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtCalle.ForeColor = System.Drawing.Color.White;
            this.ltxtCalle.Location = new System.Drawing.Point(24, 206);
            this.ltxtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.ltxtCalle.Name = "ltxtCalle";
            this.ltxtCalle.Pp_Etiqueta = "Calle:";
            this.ltxtCalle.Pp_mask = "LLLLLLLLLLLLLLLLLLLL";
            this.ltxtCalle.Pp_mensajeError = null;
            this.ltxtCalle.Pp_nombre_campo = null;
            this.ltxtCalle.Pp_nombre_tabla = null;
            this.ltxtCalle.Pp_ReadOnly = false;
            this.ltxtCalle.Pp_Text = "";
            this.ltxtCalle.Pp_validable = false;
            this.ltxtCalle.Size = new System.Drawing.Size(347, 28);
            this.ltxtCalle.TabIndex = 54;
            // 
            // ltxtNroCalle
            // 
            this.ltxtNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtNroCalle.ForeColor = System.Drawing.Color.White;
            this.ltxtNroCalle.Location = new System.Drawing.Point(24, 242);
            this.ltxtNroCalle.Margin = new System.Windows.Forms.Padding(4);
            this.ltxtNroCalle.Name = "ltxtNroCalle";
            this.ltxtNroCalle.Pp_Etiqueta = "Nro:";
            this.ltxtNroCalle.Pp_mask = "0000";
            this.ltxtNroCalle.Pp_mensajeError = null;
            this.ltxtNroCalle.Pp_nombre_campo = null;
            this.ltxtNroCalle.Pp_nombre_tabla = null;
            this.ltxtNroCalle.Pp_ReadOnly = false;
            this.ltxtNroCalle.Pp_Text = "";
            this.ltxtNroCalle.Pp_validable = false;
            this.ltxtNroCalle.Size = new System.Drawing.Size(347, 28);
            this.ltxtNroCalle.TabIndex = 55;
            // 
            // ltxtTelefono
            // 
            this.ltxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtTelefono.ForeColor = System.Drawing.Color.White;
            this.ltxtTelefono.Location = new System.Drawing.Point(24, 278);
            this.ltxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.ltxtTelefono.Name = "ltxtTelefono";
            this.ltxtTelefono.Pp_Etiqueta = "Telefono:";
            this.ltxtTelefono.Pp_mask = "00000000000";
            this.ltxtTelefono.Pp_mensajeError = null;
            this.ltxtTelefono.Pp_nombre_campo = null;
            this.ltxtTelefono.Pp_nombre_tabla = null;
            this.ltxtTelefono.Pp_ReadOnly = false;
            this.ltxtTelefono.Pp_Text = "";
            this.ltxtTelefono.Pp_validable = false;
            this.ltxtTelefono.Size = new System.Drawing.Size(347, 28);
            this.ltxtTelefono.TabIndex = 56;
            // 
            // ltxtEmail
            // 
            this.ltxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtEmail.ForeColor = System.Drawing.Color.White;
            this.ltxtEmail.Location = new System.Drawing.Point(24, 314);
            this.ltxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.ltxtEmail.Name = "ltxtEmail";
            this.ltxtEmail.Pp_Etiqueta = "Email:";
            this.ltxtEmail.Pp_mask = "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&";
            this.ltxtEmail.Pp_mensajeError = null;
            this.ltxtEmail.Pp_nombre_campo = null;
            this.ltxtEmail.Pp_nombre_tabla = null;
            this.ltxtEmail.Pp_ReadOnly = false;
            this.ltxtEmail.Pp_Text = "";
            this.ltxtEmail.Pp_validable = false;
            this.ltxtEmail.Size = new System.Drawing.Size(347, 28);
            this.ltxtEmail.TabIndex = 57;
            // 
            // FrmAMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.ltxtEmail);
            this.Controls.Add(this.ltxtTelefono);
            this.Controls.Add(this.ltxtNroCalle);
            this.Controls.Add(this.ltxtCalle);
            this.Controls.Add(this.ltxtApellido);
            this.Controls.Add(this.ltxtNombre);
            this.Controls.Add(this.ltxtDocumento);
            this.Controls.Add(this.cmb_tipDoc);
            this.Controls.Add(this.lbl_tipDoc);
            this.Name = "FrmAMCliente";
            this.Load += new System.EventHandler(this.FrmAMCliente_Load);
            this.Controls.SetChildIndex(this.lbl_tipDoc, 0);
            this.Controls.SetChildIndex(this.cmb_tipDoc, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.ltxtDocumento, 0);
            this.Controls.SetChildIndex(this.ltxtNombre, 0);
            this.Controls.SetChildIndex(this.ltxtApellido, 0);
            this.Controls.SetChildIndex(this.ltxtCalle, 0);
            this.Controls.SetChildIndex(this.ltxtNroCalle, 0);
            this.Controls.SetChildIndex(this.ltxtTelefono, 0);
            this.Controls.SetChildIndex(this.ltxtEmail, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_tipDoc;
        private Clases.ComboBox01 cmb_tipDoc;
        private Clases.LabelText01 ltxtDocumento;
        private Clases.LabelText01 ltxtNombre;
        private Clases.LabelText01 ltxtApellido;
        private Clases.LabelText01 ltxtCalle;
        private Clases.LabelText01 ltxtNroCalle;
        private Clases.LabelText01 ltxtTelefono;
        private Clases.LabelText01 ltxtEmail;
    }
}
