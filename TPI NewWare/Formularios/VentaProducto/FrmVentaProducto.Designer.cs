namespace TPI_NewWare.Formularios.VentaProducto
{
    partial class FrmVentaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmb_lider = new TPI_NewWare.Clases.ComboBox01();
            this.cmb_cliente = new TPI_NewWare.Clases.ComboBox01();
            this.cmb_producto = new TPI_NewWare.Clases.ComboBox01();
            this.panelGrilla = new System.Windows.Forms.Panel();
            this.panelMultiUso = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_editar = new FontAwesome.Sharp.IconButton();
            this.btn_nuevo = new FontAwesome.Sharp.IconButton();
            this.btn_filtro = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSup = new System.Windows.Forms.Panel();
            this.panelInf = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFondo.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.panelOpciones);
            this.panelFondo.Controls.Add(this.panelGrilla);
            this.panelFondo.Controls.Add(this.panelBotones);
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Controls.Add(this.panelSup);
            this.panelFondo.Controls.Add(this.panelInf);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(806, 500);
            this.panelFondo.TabIndex = 0;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelOpciones.CausesValidation = false;
            this.panelOpciones.Controls.Add(this.btnBuscar);
            this.panelOpciones.Controls.Add(this.label3);
            this.panelOpciones.Controls.Add(this.label2);
            this.panelOpciones.Controls.Add(this.label1);
            this.panelOpciones.Controls.Add(this.label5);
            this.panelOpciones.Controls.Add(this.label4);
            this.panelOpciones.Controls.Add(this.lbl_Titulo);
            this.panelOpciones.Controls.Add(this.dtpHasta);
            this.panelOpciones.Controls.Add(this.dtpDesde);
            this.panelOpciones.Controls.Add(this.cmb_lider);
            this.panelOpciones.Controls.Add(this.cmb_cliente);
            this.panelOpciones.Controls.Add(this.cmb_producto);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(74, 35);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(251, 429);
            this.panelOpciones.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.DimGray;
            this.btnBuscar.IconSize = 32;
            this.btnBuscar.Location = new System.Drawing.Point(110, 350);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Líder asociado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(141, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hasta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Desde";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Titulo.Location = new System.Drawing.Point(25, 7);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(125, 26);
            this.lbl_Titulo.TabIndex = 14;
            this.lbl_Titulo.Text = "Fecha de venta D/H";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(144, 62);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(79, 20);
            this.dtpHasta.TabIndex = 1;
            this.dtpHasta.Value = new System.DateTime(2020, 10, 4, 13, 16, 34, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(29, 62);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(79, 20);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = new System.DateTime(2020, 10, 4, 13, 16, 34, 0);
            // 
            // cmb_lider
            // 
            this.cmb_lider.FormattingEnabled = true;
            this.cmb_lider.Location = new System.Drawing.Point(29, 293);
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
            this.cmb_lider.TabIndex = 0;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(29, 220);
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
            this.cmb_cliente.TabIndex = 0;
            // 
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(29, 149);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Pp_Display = "nombre";
            this.cmb_producto.Pp_mensajeError = null;
            this.cmb_producto.Pp_nombre_campo = null;
            this.cmb_producto.Pp_nombre_tabla = null;
            this.cmb_producto.Pp_seleccionado = false;
            this.cmb_producto.Pp_Tabla = "PRODUCTO";
            this.cmb_producto.Pp_validable = false;
            this.cmb_producto.Pp_Value = "id";
            this.cmb_producto.Size = new System.Drawing.Size(121, 21);
            this.cmb_producto.TabIndex = 0;
            // 
            // panelGrilla
            // 
            this.panelGrilla.Controls.Add(this.panelMultiUso);
            this.panelGrilla.Controls.Add(this.grid);
            this.panelGrilla.Controls.Add(this.panel2);
            this.panelGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrilla.Location = new System.Drawing.Point(74, 35);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(732, 429);
            this.panelGrilla.TabIndex = 22;
            // 
            // panelMultiUso
            // 
            this.panelMultiUso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMultiUso.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMultiUso.Location = new System.Drawing.Point(418, 0);
            this.panelMultiUso.Name = "panelMultiUso";
            this.panelMultiUso.Size = new System.Drawing.Size(280, 429);
            this.panelMultiUso.TabIndex = 18;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(698, 429);
            this.grid.TabIndex = 17;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "# Producto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre Producto";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cliente";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha de venta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Inicio de instalación";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fin de instalación";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lider asociado";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "nroDocumento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "tipoDocumento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(698, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 429);
            this.panel2.TabIndex = 21;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBotones.Controls.Add(this.btn_eliminar);
            this.panelBotones.Controls.Add(this.btn_editar);
            this.panelBotones.Controls.Add(this.btn_nuevo);
            this.panelBotones.Controls.Add(this.btn_filtro);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(34, 35);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(40, 429);
            this.panelBotones.TabIndex = 20;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar.IconColor = System.Drawing.Color.DimGray;
            this.btn_eliminar.IconSize = 32;
            this.btn_eliminar.Location = new System.Drawing.Point(0, 138);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Rotation = 0D;
            this.btn_eliminar.Size = new System.Drawing.Size(40, 40);
            this.btn_eliminar.TabIndex = 0;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_editar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btn_editar.IconColor = System.Drawing.Color.DimGray;
            this.btn_editar.IconSize = 32;
            this.btn_editar.Location = new System.Drawing.Point(0, 92);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Rotation = 0D;
            this.btn_editar.Size = new System.Drawing.Size(40, 40);
            this.btn_editar.TabIndex = 0;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_nuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_nuevo.IconColor = System.Drawing.Color.DimGray;
            this.btn_nuevo.IconSize = 32;
            this.btn_nuevo.Location = new System.Drawing.Point(0, 46);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Rotation = 0D;
            this.btn_nuevo.Size = new System.Drawing.Size(40, 40);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
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
            this.btn_filtro.TabIndex = 0;
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 429);
            this.panel1.TabIndex = 20;
            // 
            // panelSup
            // 
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(806, 35);
            this.panelSup.TabIndex = 23;
            // 
            // panelInf
            // 
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 464);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(806, 36);
            this.panelInf.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmVentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(806, 500);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentaProducto";
            this.Text = "FrmVentaProducto";
            this.Load += new System.EventHandler(this.FrmVentaProducto_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelBotones;
        private FontAwesome.Sharp.IconButton btn_filtro;
        private System.Windows.Forms.Panel panelGrilla;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private Clases.ComboBox01 cmb_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Titulo;
        private Clases.ComboBox01 cmb_lider;
        private Clases.ComboBox01 cmb_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_nuevo;
        private FontAwesome.Sharp.IconButton btn_editar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private System.Windows.Forms.Panel panelMultiUso;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}