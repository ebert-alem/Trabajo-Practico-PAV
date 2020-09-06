namespace TPI_NewWare.Formularios
{
    partial class FrmAltaHerramientas
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.btn_crear = new FontAwesome.Sharp.IconButton();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.txt_descripcion = new TPI_NewWare.Clases.TextBox01();
            this.txt_nombre = new TPI_NewWare.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(30, 105);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(65, 17);
            this.lbl_nombre.TabIndex = 11;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(30, 138);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(84, 17);
            this.lbl_descripcion.TabIndex = 10;
            this.lbl_descripcion.Text = "Descrpcion:";
            // 
            // btn_crear
            // 
            this.btn_crear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_crear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_crear.FlatAppearance.BorderSize = 0;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_crear.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_crear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_crear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_crear.IconColor = System.Drawing.Color.Black;
            this.btn_crear.IconSize = 16;
            this.btn_crear.Location = new System.Drawing.Point(1, 411);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_crear.Rotation = 0D;
            this.btn_crear.Size = new System.Drawing.Size(200, 40);
            this.btn_crear.TabIndex = 2;
            this.btn_crear.Text = "Crear";
            this.btn_crear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconSize = 16;
            this.btn_cancelar.Location = new System.Drawing.Point(198, 411);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_cancelar.Rotation = 0D;
            this.btn_cancelar.Size = new System.Drawing.Size(200, 40);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(33, 168);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensajeError = "\"Descripción vacia\"";
            this.txt_descripcion.Pp_nombre_campo = "\"descripcion\"";
            this.txt_descripcion.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_descripcion.Pp_validable = true;
            this.txt_descripcion.Size = new System.Drawing.Size(335, 85);
            this.txt_descripcion.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(112, 102);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = "\"Nombre vacio\"";
            this.txt_nombre.Pp_nombre_campo = "\"nombre\"";
            this.txt_nombre.Pp_nombre_tabla = "\"HERRAMIENTAS\"";
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(256, 22);
            this.txt_nombre.TabIndex = 0;
            // 
            // FrmAltaHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaHerramientas";
            this.Text = "FrmAltaHerramientas";
            this.Load += new System.EventHandler(this.FrmAltaHerramientas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_descripcion;
        private FontAwesome.Sharp.IconButton btn_crear;
        private FontAwesome.Sharp.IconButton btn_cancelar;
    }
}