namespace TPI_NewWare.Reportes.HorasEmpleado
{
    partial class FrmHorasEmpleado
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HorasEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HorasEmpleado = new TPI_NewWare.Reportes.HorasEmpleado.HorasEmpleado();
            this.panel_Filtros = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmb_proyecto = new TPI_NewWare.Clases.ComboBox01();
            this.btn_generar = new FontAwesome.Sharp.IconButton();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HorasEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasEmpleado)).BeginInit();
            this.panel_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // HorasEmpleadoBindingSource
            // 
            this.HorasEmpleadoBindingSource.DataMember = "HorasEmpleado";
            this.HorasEmpleadoBindingSource.DataSource = this.HorasEmpleado;
            // 
            // HorasEmpleado
            // 
            this.HorasEmpleado.DataSetName = "HorasEmpleado";
            this.HorasEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_Filtros
            // 
            this.panel_Filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Filtros.Controls.Add(this.label5);
            this.panel_Filtros.Controls.Add(this.lbl_desde);
            this.panel_Filtros.Controls.Add(this.dtpHasta);
            this.panel_Filtros.Controls.Add(this.dtpDesde);
            this.panel_Filtros.Controls.Add(this.cmb_proyecto);
            this.panel_Filtros.Controls.Add(this.btn_generar);
            this.panel_Filtros.Controls.Add(this.lbl_Titulo);
            this.panel_Filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Filtros.Location = new System.Drawing.Point(0, 0);
            this.panel_Filtros.Name = "panel_Filtros";
            this.panel_Filtros.Size = new System.Drawing.Size(800, 41);
            this.panel_Filtros.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(440, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Hasta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_desde
            // 
            this.lbl_desde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_desde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.ForeColor = System.Drawing.Color.Black;
            this.lbl_desde.Location = new System.Drawing.Point(285, 7);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(47, 26);
            this.lbl_desde.TabIndex = 28;
            this.lbl_desde.Text = "Desde";
            this.lbl_desde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(495, 10);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(82, 20);
            this.dtpHasta.TabIndex = 26;
            this.dtpHasta.Value = new System.DateTime(2020, 10, 27, 13, 27, 0, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(338, 10);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(82, 20);
            this.dtpDesde.TabIndex = 27;
            this.dtpDesde.Value = new System.DateTime(2020, 9, 27, 0, 0, 0, 0);
            // 
            // cmb_proyecto
            // 
            this.cmb_proyecto.FormattingEnabled = true;
            this.cmb_proyecto.Location = new System.Drawing.Point(666, 11);
            this.cmb_proyecto.Name = "cmb_proyecto";
            this.cmb_proyecto.Pp_Display = "descripcion";
            this.cmb_proyecto.Pp_mensajeError = null;
            this.cmb_proyecto.Pp_nombre_campo = null;
            this.cmb_proyecto.Pp_nombre_tabla = null;
            this.cmb_proyecto.Pp_seleccionado = false;
            this.cmb_proyecto.Pp_Tabla = "PROYECTOS";
            this.cmb_proyecto.Pp_validable = false;
            this.cmb_proyecto.Pp_Value = "codigo";
            this.cmb_proyecto.Size = new System.Drawing.Size(126, 21);
            this.cmb_proyecto.TabIndex = 25;
            // 
            // btn_generar
            // 
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_generar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btn_generar.IconColor = System.Drawing.Color.DimGray;
            this.btn_generar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_generar.IconSize = 32;
            this.btn_generar.Location = new System.Drawing.Point(0, 0);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Rotation = 0D;
            this.btn_generar.Size = new System.Drawing.Size(104, 40);
            this.btn_generar.TabIndex = 24;
            this.btn_generar.Text = "GENERAR";
            this.btn_generar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Titulo.Location = new System.Drawing.Point(594, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(109, 26);
            this.lbl_Titulo.TabIndex = 17;
            this.lbl_Titulo.Text = "Proyecto:";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HorasEmpleado";
            reportDataSource1.Value = this.HorasEmpleadoBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TPI_NewWare.Reportes.HorasEmpleado.ListadoHoras.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 41);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(800, 419);
            this.reportViewer.TabIndex = 3;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // FrmHorasEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel_Filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHorasEmpleado";
            this.Text = "FrmHorasEmpleado";
            this.Load += new System.EventHandler(this.FrmHorasEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HorasEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasEmpleado)).EndInit();
            this.panel_Filtros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Filtros;
        private Clases.ComboBox01 cmb_proyecto;
        private FontAwesome.Sharp.IconButton btn_generar;
        private System.Windows.Forms.Label lbl_Titulo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource HorasEmpleadoBindingSource;
        private HorasEmpleado HorasEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}