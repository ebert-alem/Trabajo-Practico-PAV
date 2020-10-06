namespace TPI_NewWare.Formularios.Empleados
{
    partial class FrmABMCEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.lbl_filtro_nombre = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btn_Baja = new FontAwesome.Sharp.IconButton();
            this.panel_work_space.SuspendLayout();
            this.panel_visualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_visualizacion
            // 
            this.panel_visualizacion.Controls.Add(this.btn_Baja);
            this.panel_visualizacion.Controls.SetChildIndex(this.btn_eliminar, 0);
            this.panel_visualizacion.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.panel_visualizacion.Controls.SetChildIndex(this.lbl_visualizacion, 0);
            this.panel_visualizacion.Controls.SetChildIndex(this.btn_modificar, 0);
            this.panel_visualizacion.Controls.SetChildIndex(this.btn_Baja, 0);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.Location = new System.Drawing.Point(267, 460);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(95, 12);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = null;
            this.txt_nombre.Pp_nombre_campo = null;
            this.txt_nombre.Pp_nombre_tabla = null;
            this.txt_nombre.Pp_validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(299, 22);
            this.txt_nombre.TabIndex = 18;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_filtro_nombre
            // 
            this.lbl_filtro_nombre.AutoSize = true;
            this.lbl_filtro_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_filtro_nombre.Location = new System.Drawing.Point(15, 14);
            this.lbl_filtro_nombre.Name = "lbl_filtro_nombre";
            this.lbl_filtro_nombre.Size = new System.Drawing.Size(62, 20);
            this.lbl_filtro_nombre.TabIndex = 19;
            this.lbl_filtro_nombre.Text = "Buscar:";
            // 
            // Apellidos
            // 
            this.Apellidos.FillWeight = 204.5551F;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 71.04379F;
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60.2124F;
            this.Column1.HeaderText = "Legajo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Apellidos});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.grid.Location = new System.Drawing.Point(0, 55);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(394, 445);
            this.grid.TabIndex = 15;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Baja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Baja.FlatAppearance.BorderSize = 0;
            this.btn_Baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Baja.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Baja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Baja.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_Baja.IconColor = System.Drawing.Color.White;
            this.btn_Baja.IconSize = 16;
            this.btn_Baja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Baja.Location = new System.Drawing.Point(267, 460);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Rotation = 0D;
            this.btn_Baja.Size = new System.Drawing.Size(130, 40);
            this.btn_Baja.TabIndex = 11;
            this.btn_Baja.Text = "Eliminar";
            this.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Baja.UseVisualStyleBackColor = false;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // FrmABMCEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_filtro_nombre);
            this.Controls.Add(this.grid);
            this.Name = "FrmABMCEmpleados";
            this.Load += new System.EventHandler(this.FrmABMCEmpleados_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.lbl_filtro_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.panel_work_space, 0);
            this.panel_work_space.ResumeLayout(false);
            this.panel_visualizacion.ResumeLayout(false);
            this.panel_visualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_filtro_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView grid;
        public FontAwesome.Sharp.IconButton btn_Baja;
    }
}
