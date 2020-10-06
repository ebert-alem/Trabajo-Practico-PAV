namespace TPI_NewWare.Formularios.VentaProducto
{
    partial class FrmNuevaVenta
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
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_lider = new System.Windows.Forms.Label();
            this.lbl_nuevaVenta = new System.Windows.Forms.Label();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.cmb_lider = new TPI_NewWare.Clases.ComboBox01();
            this.cmb_cliente = new TPI_NewWare.Clases.ComboBox01();
            this.cmb_producto = new TPI_NewWare.Clases.ComboBox01();
            this.dtp_fecha_venta = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_venta = new System.Windows.Forms.Label();
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
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(25, 111);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(68, 17);
            this.lbl_producto.TabIndex = 3;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(39, 165);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(54, 17);
            this.lbl_cliente.TabIndex = 3;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_lider
            // 
            this.lbl_lider.AutoSize = true;
            this.lbl_lider.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lider.Location = new System.Drawing.Point(55, 219);
            this.lbl_lider.Name = "lbl_lider";
            this.lbl_lider.Size = new System.Drawing.Size(38, 17);
            this.lbl_lider.TabIndex = 3;
            this.lbl_lider.Text = "Lider";
            // 
            // lbl_nuevaVenta
            // 
            this.lbl_nuevaVenta.AutoSize = true;
            this.lbl_nuevaVenta.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevaVenta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nuevaVenta.Location = new System.Drawing.Point(44, 30);
            this.lbl_nuevaVenta.Name = "lbl_nuevaVenta";
            this.lbl_nuevaVenta.Size = new System.Drawing.Size(202, 36);
            this.lbl_nuevaVenta.TabIndex = 5;
            this.lbl_nuevaVenta.Text = "Nueva venta";
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
            // cmb_lider
            // 
            this.cmb_lider.FormattingEnabled = true;
            this.cmb_lider.Location = new System.Drawing.Point(120, 216);
            this.cmb_lider.Name = "cmb_lider";
            this.cmb_lider.Pp_Display = "";
            this.cmb_lider.Pp_mensajeError = null;
            this.cmb_lider.Pp_nombre_campo = null;
            this.cmb_lider.Pp_nombre_tabla = null;
            this.cmb_lider.Pp_seleccionado = false;
            this.cmb_lider.Pp_Tabla = "";
            this.cmb_lider.Pp_validable = false;
            this.cmb_lider.Pp_Value = "";
            this.cmb_lider.Size = new System.Drawing.Size(126, 21);
            this.cmb_lider.TabIndex = 4;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(120, 163);
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
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(120, 110);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Pp_Display = "nombre";
            this.cmb_producto.Pp_mensajeError = null;
            this.cmb_producto.Pp_nombre_campo = null;
            this.cmb_producto.Pp_nombre_tabla = null;
            this.cmb_producto.Pp_seleccionado = false;
            this.cmb_producto.Pp_Tabla = "PRODUCTO";
            this.cmb_producto.Pp_validable = false;
            this.cmb_producto.Pp_Value = "id";
            this.cmb_producto.Size = new System.Drawing.Size(126, 21);
            this.cmb_producto.TabIndex = 2;
            // 
            // dtp_fecha_venta
            // 
            this.dtp_fecha_venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_venta.Location = new System.Drawing.Point(120, 269);
            this.dtp_fecha_venta.Name = "dtp_fecha_venta";
            this.dtp_fecha_venta.Size = new System.Drawing.Size(126, 20);
            this.dtp_fecha_venta.TabIndex = 6;
            // 
            // lbl_fecha_venta
            // 
            this.lbl_fecha_venta.AutoSize = true;
            this.lbl_fecha_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_venta.Location = new System.Drawing.Point(46, 273);
            this.lbl_fecha_venta.Name = "lbl_fecha_venta";
            this.lbl_fecha_venta.Size = new System.Drawing.Size(47, 17);
            this.lbl_fecha_venta.TabIndex = 3;
            this.lbl_fecha_venta.Text = "Fecha";
            // 
            // FrmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(280, 429);
            this.Controls.Add(this.dtp_fecha_venta);
            this.Controls.Add(this.lbl_nuevaVenta);
            this.Controls.Add(this.cmb_lider);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.lbl_fecha_venta);
            this.Controls.Add(this.lbl_lider);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_crear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaVenta";
            this.Text = "FrmNuevaVenta";
            this.Load += new System.EventHandler(this.FrmNuevaVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_crear;
        private Clases.ComboBox01 cmb_producto;
        private System.Windows.Forms.Label lbl_producto;
        private Clases.ComboBox01 cmb_cliente;
        private System.Windows.Forms.Label lbl_cliente;
        private Clases.ComboBox01 cmb_lider;
        private System.Windows.Forms.Label lbl_lider;
        private System.Windows.Forms.Label lbl_nuevaVenta;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.DateTimePicker dtp_fecha_venta;
        private System.Windows.Forms.Label lbl_fecha_venta;
    }
}