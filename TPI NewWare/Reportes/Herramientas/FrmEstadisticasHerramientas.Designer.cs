namespace TPI_NewWare.Reportes.Herramientas
{
    partial class FrmEstadisticasHerramientas
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
            this.btn_generar = new FontAwesome.Sharp.IconButton();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cmb_proyecto = new TPI_NewWare.Clases.ComboBox01();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.cmb_etapa = new TPI_NewWare.Clases.ComboBox01();
            this.lblHerramienta = new System.Windows.Forms.Label();
            this.cmb_Herramienta = new TPI_NewWare.Clases.ComboBox01();
            this.lbl_fechaUso = new System.Windows.Forms.Label();
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
            this.panel_Filtros.Controls.Add(this.btn_generar);
            this.panel_Filtros.Controls.Add(this.lblProyecto);
            this.panel_Filtros.Controls.Add(this.cmb_proyecto);
            this.panel_Filtros.Controls.Add(this.lblEtapa);
            this.panel_Filtros.Controls.Add(this.cmb_etapa);
            this.panel_Filtros.Controls.Add(this.lblHerramienta);
            this.panel_Filtros.Controls.Add(this.cmb_Herramienta);
            this.panel_Filtros.Controls.Add(this.lbl_fechaUso);
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
            // lblProyecto
            // 
            this.lblProyecto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.ForeColor = System.Drawing.Color.Black;
            this.lblProyecto.Location = new System.Drawing.Point(236, 54);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(65, 26);
            this.lblProyecto.TabIndex = 23;
            this.lblProyecto.Text = "Proyecto:";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_proyecto
            // 
            this.cmb_proyecto.FormattingEnabled = true;
            this.cmb_proyecto.Location = new System.Drawing.Point(307, 58);
            this.cmb_proyecto.Name = "cmb_proyecto";
            this.cmb_proyecto.Pp_Display = "descripcion";
            this.cmb_proyecto.Pp_mensajeError = null;
            this.cmb_proyecto.Pp_nombre_campo = null;
            this.cmb_proyecto.Pp_nombre_tabla = null;
            this.cmb_proyecto.Pp_seleccionado = false;
            this.cmb_proyecto.Pp_Tabla = "PROYECTOS";
            this.cmb_proyecto.Pp_validable = false;
            this.cmb_proyecto.Pp_Value = "codigo";
            this.cmb_proyecto.Size = new System.Drawing.Size(121, 21);
            this.cmb_proyecto.TabIndex = 22;
            // 
            // lblEtapa
            // 
            this.lblEtapa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.ForeColor = System.Drawing.Color.Black;
            this.lblEtapa.Location = new System.Drawing.Point(448, 54);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(54, 26);
            this.lblEtapa.TabIndex = 21;
            this.lblEtapa.Text = "Etapa:";
            this.lblEtapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_etapa
            // 
            this.cmb_etapa.FormattingEnabled = true;
            this.cmb_etapa.Location = new System.Drawing.Point(508, 58);
            this.cmb_etapa.Name = "cmb_etapa";
            this.cmb_etapa.Pp_Display = "descripcion";
            this.cmb_etapa.Pp_mensajeError = null;
            this.cmb_etapa.Pp_nombre_campo = null;
            this.cmb_etapa.Pp_nombre_tabla = null;
            this.cmb_etapa.Pp_seleccionado = false;
            this.cmb_etapa.Pp_Tabla = "ETAPAS";
            this.cmb_etapa.Pp_validable = false;
            this.cmb_etapa.Pp_Value = "id";
            this.cmb_etapa.Size = new System.Drawing.Size(121, 21);
            this.cmb_etapa.TabIndex = 20;
            // 
            // lblHerramienta
            // 
            this.lblHerramienta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerramienta.ForeColor = System.Drawing.Color.Black;
            this.lblHerramienta.Location = new System.Drawing.Point(3, 54);
            this.lblHerramienta.Name = "lblHerramienta";
            this.lblHerramienta.Size = new System.Drawing.Size(87, 26);
            this.lblHerramienta.TabIndex = 19;
            this.lblHerramienta.Text = "Herramienta:";
            this.lblHerramienta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHerramienta.Visible = false;
            // 
            // cmb_Herramienta
            // 
            this.cmb_Herramienta.FormattingEnabled = true;
            this.cmb_Herramienta.Location = new System.Drawing.Point(97, 58);
            this.cmb_Herramienta.Name = "cmb_Herramienta";
            this.cmb_Herramienta.Pp_Display = "nombre";
            this.cmb_Herramienta.Pp_mensajeError = null;
            this.cmb_Herramienta.Pp_nombre_campo = null;
            this.cmb_Herramienta.Pp_nombre_tabla = null;
            this.cmb_Herramienta.Pp_seleccionado = true;
            this.cmb_Herramienta.Pp_Tabla = "HERRAMIENTAS";
            this.cmb_Herramienta.Pp_validable = false;
            this.cmb_Herramienta.Pp_Value = "id";
            this.cmb_Herramienta.Size = new System.Drawing.Size(121, 21);
            this.cmb_Herramienta.TabIndex = 18;
            this.cmb_Herramienta.Visible = false;
            // 
            // lbl_fechaUso
            // 
            this.lbl_fechaUso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fechaUso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaUso.ForeColor = System.Drawing.Color.Black;
            this.lbl_fechaUso.Location = new System.Drawing.Point(370, 7);
            this.lbl_fechaUso.Name = "lbl_fechaUso";
            this.lbl_fechaUso.Size = new System.Drawing.Size(93, 26);
            this.lbl_fechaUso.TabIndex = 17;
            this.lbl_fechaUso.Text = "Fecha de uso:";
            this.lbl_fechaUso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel_reporte.TabIndex = 3;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TPI_NewWare.Reportes.Herramientas.EstadisticasHerramientas.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(806, 460);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // FrmEstadisticasHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 500);
            this.Controls.Add(this.panel_reporte);
            this.Controls.Add(this.panel_Filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticasHerramientas";
            this.Text = "FrmEstadisticasHerramientas";
            this.Load += new System.EventHandler(this.FrmEstadisticasHerramientas_Load);
            this.panel_Filtros.ResumeLayout(false);
            this.panel_reporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Filtros;
        private FontAwesome.Sharp.IconButton btn_generar;
        private System.Windows.Forms.Label lblProyecto;
        private Clases.ComboBox01 cmb_proyecto;
        private System.Windows.Forms.Label lblEtapa;
        private Clases.ComboBox01 cmb_etapa;
        private System.Windows.Forms.Label lblHerramienta;
        private Clases.ComboBox01 cmb_Herramienta;
        private System.Windows.Forms.Label lbl_fechaUso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private FontAwesome.Sharp.IconButton btn_filtro;
        private System.Windows.Forms.Panel panel_reporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}