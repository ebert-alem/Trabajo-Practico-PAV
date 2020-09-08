namespace TPI_NewWare.Formularios
{
    partial class FrmAMBase
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
            this.btn_crear = new FontAwesome.Sharp.IconButton();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_crear.FlatAppearance.BorderSize = 0;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_crear.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_crear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_crear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_crear.IconColor = System.Drawing.Color.Black;
            this.btn_crear.IconSize = 16;
            this.btn_crear.Location = new System.Drawing.Point(0, 410);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Rotation = 0D;
            this.btn_crear.Size = new System.Drawing.Size(200, 40);
            this.btn_crear.TabIndex = 4;
            this.btn_crear.Text = "Crear";
            this.btn_crear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconSize = 16;
            this.btn_cancelar.Location = new System.Drawing.Point(200, 410);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Rotation = 0D;
            this.btn_cancelar.Size = new System.Drawing.Size(200, 40);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmAMBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAMBase";
            this.Text = "FrmABMBase";
            this.ResumeLayout(false);

        }

        #endregion

        protected FontAwesome.Sharp.IconButton btn_crear;
        protected FontAwesome.Sharp.IconButton btn_cancelar;
    }
}