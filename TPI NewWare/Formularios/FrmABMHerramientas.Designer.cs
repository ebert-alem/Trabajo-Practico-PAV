namespace TPI_NewWare.Formularios
{
    partial class FrmABMHerramientas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevo = new FontAwesome.Sharp.IconButton();
            this.panel_work_space = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.lbl_filtro_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.panel_visualizacion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_work_space.SuspendLayout();
            this.panel_visualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.grid.Location = new System.Drawing.Point(0, 76);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(380, 424);
            this.grid.TabIndex = 4;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 33.42287F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 103.275F;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 202.3884F;
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel_work_space);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 500);
            this.panel1.TabIndex = 7;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_nuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_nuevo.IconColor = System.Drawing.Color.Black;
            this.btn_nuevo.IconSize = 16;
            this.btn_nuevo.Location = new System.Drawing.Point(3, 460);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_nuevo.Rotation = 0D;
            this.btn_nuevo.Size = new System.Drawing.Size(200, 40);
            this.btn_nuevo.TabIndex = 3;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // panel_work_space
            // 
            this.panel_work_space.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_work_space.Controls.Add(this.panel_visualizacion);
            this.panel_work_space.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_work_space.Location = new System.Drawing.Point(0, 0);
            this.panel_work_space.Name = "panel_work_space";
            this.panel_work_space.Size = new System.Drawing.Size(400, 436);
            this.panel_work_space.TabIndex = 10;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(29, 107);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(65, 17);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(29, 76);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 17);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "Id:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(29, 140);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(84, 17);
            this.lbl_descripcion.TabIndex = 8;
            this.lbl_descripcion.Text = "Descrpcion:";
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 16;
            this.iconButton3.Location = new System.Drawing.Point(200, 460);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(200, 40);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Modificar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // lbl_filtro_nombre
            // 
            this.lbl_filtro_nombre.AutoSize = true;
            this.lbl_filtro_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_nombre.Location = new System.Drawing.Point(24, 40);
            this.lbl_filtro_nombre.Name = "lbl_filtro_nombre";
            this.lbl_filtro_nombre.Size = new System.Drawing.Size(65, 17);
            this.lbl_filtro_nombre.TabIndex = 10;
            this.lbl_filtro_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(95, 39);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = null;
            this.txt_nombre.Pp_nombre_campo = null;
            this.txt_nombre.Pp_nombre_tabla = null;
            this.txt_nombre.Pp_validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(285, 22);
            this.txt_nombre.TabIndex = 8;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // panel_visualizacion
            // 
            this.panel_visualizacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_visualizacion.Controls.Add(this.lbl_id);
            this.panel_visualizacion.Controls.Add(this.lbl_nombre);
            this.panel_visualizacion.Controls.Add(this.lbl_descripcion);
            this.panel_visualizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_visualizacion.Location = new System.Drawing.Point(0, 0);
            this.panel_visualizacion.Name = "panel_visualizacion";
            this.panel_visualizacion.Size = new System.Drawing.Size(400, 221);
            this.panel_visualizacion.TabIndex = 11;
            // 
            // FrmABMHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lbl_filtro_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMHerramientas";
            this.Text = "FrmABMHerramientas";
            this.Load += new System.EventHandler(this.FrmABMHerramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_work_space.ResumeLayout(false);
            this.panel_visualizacion.ResumeLayout(false);
            this.panel_visualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_filtro_nombre;
        private System.Windows.Forms.Panel panel_work_space;
        private FontAwesome.Sharp.IconButton btn_nuevo;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel_visualizacion;
    }
}