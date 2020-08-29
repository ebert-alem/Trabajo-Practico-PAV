namespace TPI_NewWare.Formularios
{
    partial class FrmTareas
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
            this.btnAgregarTarea = new FontAwesome.Sharp.IconButton();
            this.textAgregarTarea = new System.Windows.Forms.TextBox();
            this.listTareas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.Gray;
            this.btnAgregarTarea.FlatAppearance.BorderSize = 0;
            this.btnAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTarea.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTarea.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarTarea.IconColor = System.Drawing.Color.White;
            this.btnAgregarTarea.IconSize = 16;
            this.btnAgregarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTarea.Location = new System.Drawing.Point(340, 75);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Rotation = 0D;
            this.btnAgregarTarea.Size = new System.Drawing.Size(124, 40);
            this.btnAgregarTarea.TabIndex = 8;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // textAgregarTarea
            // 
            this.textAgregarTarea.Location = new System.Drawing.Point(206, 37);
            this.textAgregarTarea.Name = "textAgregarTarea";
            this.textAgregarTarea.Size = new System.Drawing.Size(388, 20);
            this.textAgregarTarea.TabIndex = 7;
            // 
            // listTareas
            // 
            this.listTareas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listTareas.FormattingEnabled = true;
            this.listTareas.Location = new System.Drawing.Point(206, 136);
            this.listTareas.Name = "listTareas";
            this.listTareas.Size = new System.Drawing.Size(388, 277);
            this.listTareas.TabIndex = 6;
            // 
            // FrmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.textAgregarTarea);
            this.Controls.Add(this.listTareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTareas";
            this.Text = "formTareas";
            this.Load += new System.EventHandler(this.FrmTareas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregarTarea;
        private System.Windows.Forms.TextBox textAgregarTarea;
        private System.Windows.Forms.ListBox listTareas;
    }
}