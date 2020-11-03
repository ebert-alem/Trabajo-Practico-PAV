namespace TPI_NewWare.Reportes.Tareas
{
    partial class FrmTareasPorEmpleado
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
            this.tareasEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_TareasEmpleado = new TPI_NewWare.Reportes.Tareas.ds_TareasEmpleado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_Filtros = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_generar = new FontAwesome.Sharp.IconButton();
            this.btn_filtro = new FontAwesome.Sharp.IconButton();
            this.cmb_empleado = new TPI_NewWare.Clases.ComboBox01();
            ((System.ComponentModel.ISupportInitialize)(this.tareasEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TareasEmpleado)).BeginInit();
            this.panel_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tareasEmpleadoBindingSource
            // 
            this.tareasEmpleadoBindingSource.DataMember = "tareasEmpleado";
            this.tareasEmpleadoBindingSource.DataSource = this.ds_TareasEmpleado;
            // 
            // ds_TareasEmpleado
            // 
            this.ds_TareasEmpleado.DataSetName = "ds_TareasEmpleado";
            this.ds_TareasEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tareasEmpleados";
            reportDataSource1.Value = this.tareasEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPI_NewWare.Reportes.Tareas.ListadoTareasProyecto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 419);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel_Filtros
            // 
            this.panel_Filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Filtros.Controls.Add(this.cmb_empleado);
            this.panel_Filtros.Controls.Add(this.lbl_Titulo);
            this.panel_Filtros.Controls.Add(this.btn_generar);
            this.panel_Filtros.Controls.Add(this.btn_filtro);
            this.panel_Filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Filtros.Location = new System.Drawing.Point(0, 0);
            this.panel_Filtros.Name = "panel_Filtros";
            this.panel_Filtros.Size = new System.Drawing.Size(800, 41);
            this.panel_Filtros.TabIndex = 4;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Titulo.Location = new System.Drawing.Point(590, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(109, 26);
            this.lbl_Titulo.TabIndex = 28;
            this.lbl_Titulo.Text = "Empleado:";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btn_filtro
            // 
            this.btn_filtro.FlatAppearance.BorderSize = 0;
            this.btn_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_filtro.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btn_filtro.IconColor = System.Drawing.Color.DimGray;
            this.btn_filtro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_filtro.IconSize = 32;
            this.btn_filtro.Location = new System.Drawing.Point(0, 0);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Rotation = 0D;
            this.btn_filtro.Size = new System.Drawing.Size(40, 40);
            this.btn_filtro.TabIndex = 1;
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(662, 11);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Pp_Display = "apellido";
            this.cmb_empleado.Pp_mensajeError = null;
            this.cmb_empleado.Pp_nombre_campo = null;
            this.cmb_empleado.Pp_nombre_tabla = null;
            this.cmb_empleado.Pp_seleccionado = false;
            this.cmb_empleado.Pp_Tabla = "EMPLEADOS";
            this.cmb_empleado.Pp_validable = false;
            this.cmb_empleado.Pp_Value = "legajo";
            this.cmb_empleado.Size = new System.Drawing.Size(126, 21);
            this.cmb_empleado.TabIndex = 29;
            // 
            // FrmTareasPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.panel_Filtros);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTareasPorEmpleado";
            this.Text = "FrmTareasPorEmpleado";
            this.Load += new System.EventHandler(this.FrmTareasPorEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tareasEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TareasEmpleado)).EndInit();
            this.panel_Filtros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel_Filtros;
        private FontAwesome.Sharp.IconButton btn_generar;
        private FontAwesome.Sharp.IconButton btn_filtro;
        private Clases.ComboBox01 cmb_empleado;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.BindingSource tareasEmpleadoBindingSource;
        private ds_TareasEmpleado ds_TareasEmpleado;
    }
}