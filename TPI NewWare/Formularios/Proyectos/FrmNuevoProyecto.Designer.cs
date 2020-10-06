namespace TPI_NewWare.Formularios.VentaProyecto
{
    partial class FrmNuevoProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_crear = new FontAwesome.Sharp.IconButton();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_nuevaVenta = new System.Windows.Forms.Label();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.cmb_cliente = new TPI_NewWare.Clases.ComboBox01();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinEsperado = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new TPI_NewWare.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.FlatAppearance.BorderSize = 0;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_crear.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_crear.IconColor = System.Drawing.Color.Black;
            this.btn_crear.IconSize = 32;
            this.btn_crear.Location = new System.Drawing.Point(53, 361);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Rotation = 0D;
            this.btn_crear.Size = new System.Drawing.Size(40, 40);
            this.btn_crear.TabIndex = 1;
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(77, 248);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(54, 17);
            this.lbl_cliente.TabIndex = 3;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_nuevaVenta
            // 
            this.lbl_nuevaVenta.AutoSize = true;
            this.lbl_nuevaVenta.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevaVenta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nuevaVenta.Location = new System.Drawing.Point(22, 33);
            this.lbl_nuevaVenta.Name = "lbl_nuevaVenta";
            this.lbl_nuevaVenta.Size = new System.Drawing.Size(244, 36);
            this.lbl_nuevaVenta.TabIndex = 5;
            this.lbl_nuevaVenta.Text = "Nuevo Proyecto";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconSize = 32;
            this.btn_cancelar.Location = new System.Drawing.Point(183, 361);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Rotation = 0D;
            this.btn_cancelar.Size = new System.Drawing.Size(40, 40);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(140, 247);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Pp_Display = "nombre";
            this.cmb_cliente.Pp_mensajeError = null;
            this.cmb_cliente.Pp_nombre_campo = null;
            this.cmb_cliente.Pp_nombre_tabla = null;
            this.cmb_cliente.Pp_seleccionado = false;
            this.cmb_cliente.Pp_Tabla = "PRODUCTO";
            this.cmb_cliente.Pp_validable = false;
            this.cmb_cliente.Pp_Value = "id";
            this.cmb_cliente.Size = new System.Drawing.Size(126, 21);
            this.cmb_cliente.TabIndex = 4;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(140, 274);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(126, 20);
            this.dtpInicio.TabIndex = 6;
            this.dtpInicio.Value = new System.DateTime(2020, 10, 4, 13, 16, 34, 0);
            // 
            // dtpFinEsperado
            // 
            this.dtpFinEsperado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinEsperado.Location = new System.Drawing.Point(140, 300);
            this.dtpFinEsperado.Name = "dtpFinEsperado";
            this.dtpFinEsperado.Size = new System.Drawing.Size(128, 20);
            this.dtpFinEsperado.TabIndex = 7;
            this.dtpFinEsperado.Value = new System.DateTime(2020, 10, 4, 13, 16, 34, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(15, 112);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensajeError = "\"Descripción vacia\"";
            this.txt_descripcion.Pp_nombre_campo = "\"descripcion\"";
            this.txt_descripcion.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_descripcion.Pp_validable = true;
            this.txt_descripcion.Size = new System.Drawing.Size(251, 129);
            this.txt_descripcion.TabIndex = 14;
            // 
            // FrmNuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(280, 429);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFinEsperado);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lbl_nuevaVenta);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_crear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoProyecto";
            this.Text = "FrmNuevaVenta";
            this.Load += new System.EventHandler(this.FrmNuevaVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_crear;
        private Clases.ComboBox01 cmb_cliente;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_nuevaVenta;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinEsperado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_descripcion;
    }
}