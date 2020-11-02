namespace TPI_NewWare.Reportes.VentaProducto
{
    partial class FrmEstadisticasVentasProducto
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
            this.panel_Filtros = new System.Windows.Forms.Panel();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.btn_generar = new FontAwesome.Sharp.IconButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLider = new System.Windows.Forms.Label();
            this.cmb_lider = new TPI_NewWare.Clases.ComboBox01();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmb_cliente = new TPI_NewWare.Clases.ComboBox01();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmb_producto = new TPI_NewWare.Clases.ComboBox01();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btn_filtro = new FontAwesome.Sharp.IconButton();
            this.panel_reporte = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_Filtros.SuspendLayout();
            this.panel_reporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Filtros
            // 
            this.panel_Filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Filtros.Controls.Add(this.cmb_estado);
            this.panel_Filtros.Controls.Add(this.btn_generar);
            this.panel_Filtros.Controls.Add(this.lblEstado);
            this.panel_Filtros.Controls.Add(this.lblLider);
            this.panel_Filtros.Controls.Add(this.cmb_lider);
            this.panel_Filtros.Controls.Add(this.lblCliente);
            this.panel_Filtros.Controls.Add(this.cmb_cliente);
            this.panel_Filtros.Controls.Add(this.lblProducto);
            this.panel_Filtros.Controls.Add(this.cmb_producto);
            this.panel_Filtros.Controls.Add(this.lbl_Titulo);
            this.panel_Filtros.Controls.Add(this.label5);
            this.panel_Filtros.Controls.Add(this.lbl_desde);
            this.panel_Filtros.Controls.Add(this.dtpHasta);
            this.panel_Filtros.Controls.Add(this.dtpDesde);
            this.panel_Filtros.Controls.Add(this.btn_filtro);
            this.panel_Filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Filtros.Location = new System.Drawing.Point(0, 0);
            this.panel_Filtros.Name = "panel_Filtros";
            this.panel_Filtros.Size = new System.Drawing.Size(806, 40);
            this.panel_Filtros.TabIndex = 1;
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Pendiente",
            "En instalación",
            "Finalizado"});
            this.cmb_estado.Location = new System.Drawing.Point(671, 58);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(121, 21);
            this.cmb_estado.TabIndex = 0;
            this.cmb_estado.Visible = false;
            // 
            // btn_generar
            // 
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_generar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btn_generar.IconColor = System.Drawing.Color.DimGray;
            this.btn_generar.IconSize = 32;
            this.btn_generar.Location = new System.Drawing.Point(46, 0);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Rotation = 0D;
            this.btn_generar.Size = new System.Drawing.Size(104, 40);
            this.btn_generar.TabIndex = 24;
            this.btn_generar.Text = "GENERAR";
            this.btn_generar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(614, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 26);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstado.Visible = false;
            // 
            // lblLider
            // 
            this.lblLider.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLider.ForeColor = System.Drawing.Color.Black;
            this.lblLider.Location = new System.Drawing.Point(419, 54);
            this.lblLider.Name = "lblLider";
            this.lblLider.Size = new System.Drawing.Size(44, 26);
            this.lblLider.TabIndex = 23;
            this.lblLider.Text = "Líder:";
            this.lblLider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_lider
            // 
            this.cmb_lider.FormattingEnabled = true;
            this.cmb_lider.Location = new System.Drawing.Point(469, 58);
            this.cmb_lider.Name = "cmb_lider";
            this.cmb_lider.Pp_Display = null;
            this.cmb_lider.Pp_mensajeError = null;
            this.cmb_lider.Pp_nombre_campo = null;
            this.cmb_lider.Pp_nombre_tabla = null;
            this.cmb_lider.Pp_seleccionado = false;
            this.cmb_lider.Pp_Tabla = null;
            this.cmb_lider.Pp_validable = false;
            this.cmb_lider.Pp_Value = null;
            this.cmb_lider.Size = new System.Drawing.Size(121, 21);
            this.cmb_lider.TabIndex = 22;
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(216, 54);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 26);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(276, 58);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Pp_Display = null;
            this.cmb_cliente.Pp_mensajeError = null;
            this.cmb_cliente.Pp_nombre_campo = null;
            this.cmb_cliente.Pp_nombre_tabla = null;
            this.cmb_cliente.Pp_seleccionado = false;
            this.cmb_cliente.Pp_Tabla = "CLIENTES";
            this.cmb_cliente.Pp_validable = false;
            this.cmb_cliente.Pp_Value = null;
            this.cmb_cliente.Size = new System.Drawing.Size(121, 21);
            this.cmb_cliente.TabIndex = 20;
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.Location = new System.Drawing.Point(3, 54);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(66, 26);
            this.lblProducto.TabIndex = 19;
            this.lblProducto.Text = "Producto:";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProducto.Visible = false;
            // 
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(75, 58);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Pp_Display = "nombre";
            this.cmb_producto.Pp_mensajeError = null;
            this.cmb_producto.Pp_nombre_campo = null;
            this.cmb_producto.Pp_nombre_tabla = null;
            this.cmb_producto.Pp_seleccionado = true;
            this.cmb_producto.Pp_Tabla = "PRODUCTO";
            this.cmb_producto.Pp_validable = false;
            this.cmb_producto.Pp_Value = "id";
            this.cmb_producto.Size = new System.Drawing.Size(121, 21);
            this.cmb_producto.TabIndex = 18;
            this.cmb_producto.Visible = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Titulo.Location = new System.Drawing.Point(354, 7);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(109, 26);
            this.lbl_Titulo.TabIndex = 17;
            this.lbl_Titulo.Text = "Fecha de venta:";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(640, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hasta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_desde
            // 
            this.lbl_desde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_desde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.ForeColor = System.Drawing.Color.Black;
            this.lbl_desde.Location = new System.Drawing.Point(485, 7);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(47, 26);
            this.lbl_desde.TabIndex = 15;
            this.lbl_desde.Text = "Desde";
            this.lbl_desde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(695, 10);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(82, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(538, 10);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(82, 20);
            this.dtpDesde.TabIndex = 2;
            this.dtpDesde.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btn_filtro
            // 
            this.btn_filtro.FlatAppearance.BorderSize = 0;
            this.btn_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_filtro.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btn_filtro.IconColor = System.Drawing.Color.DimGray;
            this.btn_filtro.IconSize = 32;
            this.btn_filtro.Location = new System.Drawing.Point(0, 0);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Rotation = 0D;
            this.btn_filtro.Size = new System.Drawing.Size(40, 40);
            this.btn_filtro.TabIndex = 1;
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
            // 
            // panel_reporte
            // 
            this.panel_reporte.Controls.Add(this.reportViewer);
            this.panel_reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_reporte.Location = new System.Drawing.Point(0, 40);
            this.panel_reporte.Name = "panel_reporte";
            this.panel_reporte.Size = new System.Drawing.Size(806, 460);
            this.panel_reporte.TabIndex = 2;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TPI_NewWare.Reportes.VentaProducto.EstadisticasVentaProducto.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(806, 460);
            this.reportViewer.TabIndex = 0;
            // 
            // FrmEstadisticasVentasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 500);
            this.Controls.Add(this.panel_reporte);
            this.Controls.Add(this.panel_Filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticasVentasProducto";
            this.Text = "FrmEstadisticasVentasProducto";
            this.Load += new System.EventHandler(this.FrmEstadisticasVentasProducto_Load);
            this.panel_Filtros.ResumeLayout(false);
            this.panel_reporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Filtros;
        private System.Windows.Forms.ComboBox cmb_estado;
        private FontAwesome.Sharp.IconButton btn_generar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblLider;
        private Clases.ComboBox01 cmb_lider;
        private System.Windows.Forms.Label lblCliente;
        private Clases.ComboBox01 cmb_cliente;
        private System.Windows.Forms.Label lblProducto;
        private Clases.ComboBox01 cmb_producto;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private FontAwesome.Sharp.IconButton btn_filtro;
        private System.Windows.Forms.Panel panel_reporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}