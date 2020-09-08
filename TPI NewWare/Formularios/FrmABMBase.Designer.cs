namespace TPI_NewWare.Formularios
{
    partial class FrmABMBase
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
            this.panel_visualizacion = new System.Windows.Forms.Panel();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_modificar = new FontAwesome.Sharp.IconButton();
            this.lbl_visualizacion = new System.Windows.Forms.Label();
            this.btn_nuevo = new FontAwesome.Sharp.IconButton();
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.lbl_filtro_nombre = new System.Windows.Forms.Label();
            this.panel_visualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_visualizacion
            // 
            this.panel_visualizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_visualizacion.Controls.Add(this.btn_eliminar);
            this.panel_visualizacion.Controls.Add(this.btn_modificar);
            this.panel_visualizacion.Controls.Add(this.lbl_visualizacion);
            this.panel_visualizacion.Controls.Add(this.btn_nuevo);
            this.panel_visualizacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_visualizacion.ForeColor = System.Drawing.Color.White;
            this.panel_visualizacion.Location = new System.Drawing.Point(400, 0);
            this.panel_visualizacion.Name = "panel_visualizacion";
            this.panel_visualizacion.Size = new System.Drawing.Size(400, 450);
            this.panel_visualizacion.TabIndex = 12;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar.IconColor = System.Drawing.Color.White;
            this.btn_eliminar.IconSize = 16;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(265, 410);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Rotation = 0D;
            this.btn_eliminar.Size = new System.Drawing.Size(130, 40);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btn_modificar.IconColor = System.Drawing.Color.White;
            this.btn_modificar.IconSize = 16;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(135, 410);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Rotation = 0D;
            this.btn_modificar.Size = new System.Drawing.Size(130, 40);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbl_visualizacion
            // 
            this.lbl_visualizacion.AutoSize = true;
            this.lbl_visualizacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visualizacion.Location = new System.Drawing.Point(53, 82);
            this.lbl_visualizacion.Name = "lbl_visualizacion";
            this.lbl_visualizacion.Size = new System.Drawing.Size(291, 20);
            this.lbl_visualizacion.TabIndex = 5;
            this.lbl_visualizacion.Text = "No se ha podido cargar el documento";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_nuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_nuevo.IconColor = System.Drawing.Color.White;
            this.btn_nuevo.IconSize = 16;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(3, 410);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Rotation = 0D;
            this.btn_nuevo.Size = new System.Drawing.Size(130, 40);
            this.btn_nuevo.TabIndex = 3;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(92, 25);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = null;
            this.txt_nombre.Pp_nombre_campo = null;
            this.txt_nombre.Pp_nombre_tabla = null;
            this.txt_nombre.Pp_validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(299, 22);
            this.txt_nombre.TabIndex = 11;
            // 
            // lbl_filtro_nombre
            // 
            this.lbl_filtro_nombre.AutoSize = true;
            this.lbl_filtro_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_filtro_nombre.Location = new System.Drawing.Point(12, 27);
            this.lbl_filtro_nombre.Name = "lbl_filtro_nombre";
            this.lbl_filtro_nombre.Size = new System.Drawing.Size(62, 20);
            this.lbl_filtro_nombre.TabIndex = 12;
            this.lbl_filtro_nombre.Text = "Buscar:";
            // 
            // FrmABMBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.panel_visualizacion);
            this.Controls.Add(this.lbl_filtro_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMBase";
            this.Text = "FrmABMBase";
            this.panel_visualizacion.ResumeLayout(false);
            this.panel_visualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_visualizacion;
        public FontAwesome.Sharp.IconButton btn_eliminar;
        public FontAwesome.Sharp.IconButton btn_modificar;
        public System.Windows.Forms.Label lbl_visualizacion;
        public FontAwesome.Sharp.IconButton btn_nuevo;
        public System.Windows.Forms.Label lbl_filtro_nombre;
        internal Clases.TextBox01 txt_nombre;
    }
}