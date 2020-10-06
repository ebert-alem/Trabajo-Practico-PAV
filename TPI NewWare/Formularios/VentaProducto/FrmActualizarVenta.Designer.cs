namespace TPI_NewWare.Formularios.VentaProducto
{
    partial class FrmActualizarVenta
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
            this.lbl_actualizar_venta = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_inicio_instalacion = new System.Windows.Forms.Label();
            this.btn_crear = new FontAwesome.Sharp.IconButton();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.lbl_fin_instalacion = new System.Windows.Forms.Label();
            this.dtp_inicio_instalacion = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin_instalacion = new System.Windows.Forms.DateTimePicker();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_actualizar_venta
            // 
            this.lbl_actualizar_venta.AutoSize = true;
            this.lbl_actualizar_venta.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualizar_venta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_actualizar_venta.Location = new System.Drawing.Point(17, 23);
            this.lbl_actualizar_venta.Name = "lbl_actualizar_venta";
            this.lbl_actualizar_venta.Size = new System.Drawing.Size(249, 36);
            this.lbl_actualizar_venta.TabIndex = 6;
            this.lbl_actualizar_venta.Text = "Actualizar venta";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(20, 80);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(76, 17);
            this.lbl_producto.TabIndex = 7;
            this.lbl_producto.Text = "Producto: ";
            // 
            // lbl_inicio_instalacion
            // 
            this.lbl_inicio_instalacion.AutoSize = true;
            this.lbl_inicio_instalacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio_instalacion.Location = new System.Drawing.Point(38, 182);
            this.lbl_inicio_instalacion.Name = "lbl_inicio_instalacion";
            this.lbl_inicio_instalacion.Size = new System.Drawing.Size(141, 17);
            this.lbl_inicio_instalacion.TabIndex = 7;
            this.lbl_inicio_instalacion.Text = "Inicio de instalación:";
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
            this.btn_crear.TabIndex = 8;
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
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
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_fin_instalacion
            // 
            this.lbl_fin_instalacion.AutoSize = true;
            this.lbl_fin_instalacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fin_instalacion.Location = new System.Drawing.Point(38, 254);
            this.lbl_fin_instalacion.Name = "lbl_fin_instalacion";
            this.lbl_fin_instalacion.Size = new System.Drawing.Size(124, 17);
            this.lbl_fin_instalacion.TabIndex = 7;
            this.lbl_fin_instalacion.Text = "Fin de instalación:";
            // 
            // dtp_inicio_instalacion
            // 
            this.dtp_inicio_instalacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio_instalacion.Location = new System.Drawing.Point(41, 202);
            this.dtp_inicio_instalacion.Name = "dtp_inicio_instalacion";
            this.dtp_inicio_instalacion.Size = new System.Drawing.Size(200, 20);
            this.dtp_inicio_instalacion.TabIndex = 10;
            // 
            // dtp_fin_instalacion
            // 
            this.dtp_fin_instalacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fin_instalacion.Location = new System.Drawing.Point(41, 274);
            this.dtp_fin_instalacion.Name = "dtp_fin_instalacion";
            this.dtp_fin_instalacion.Size = new System.Drawing.Size(200, 20);
            this.dtp_fin_instalacion.TabIndex = 10;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(20, 122);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(62, 17);
            this.lbl_cliente.TabIndex = 7;
            this.lbl_cliente.Text = "Cliente: ";
            // 
            // FrmActualizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(280, 429);
            this.Controls.Add(this.dtp_fin_instalacion);
            this.Controls.Add(this.dtp_inicio_instalacion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lbl_fin_instalacion);
            this.Controls.Add(this.lbl_inicio_instalacion);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_actualizar_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActualizarVenta";
            this.Text = "FrmActualizarVenta";
            this.Load += new System.EventHandler(this.FrmActualizarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_actualizar_venta;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_inicio_instalacion;
        private FontAwesome.Sharp.IconButton btn_crear;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.Label lbl_fin_instalacion;
        private System.Windows.Forms.DateTimePicker dtp_inicio_instalacion;
        private System.Windows.Forms.DateTimePicker dtp_fin_instalacion;
        private System.Windows.Forms.Label lbl_cliente;
    }
}