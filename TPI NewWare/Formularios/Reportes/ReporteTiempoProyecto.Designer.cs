namespace TPI_NewWare.Formularios.Reportes
{
    partial class ReporteTiempoProyecto
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
            this.rpt_TiempoPorProyecto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltxt_fechaFinalizacion = new TPI_NewWare.Clases.LabelText01();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpt_TiempoPorProyecto
            // 
            this.rpt_TiempoPorProyecto.LocalReport.ReportEmbeddedResource = "TPI_NewWare.Formularios.Reportes.rpt_TiempoPorProyecto.rdlc";
            this.rpt_TiempoPorProyecto.Location = new System.Drawing.Point(12, 62);
            this.rpt_TiempoPorProyecto.Name = "rpt_TiempoPorProyecto";
            this.rpt_TiempoPorProyecto.ServerReport.BearerToken = null;
            this.rpt_TiempoPorProyecto.Size = new System.Drawing.Size(762, 384);
            this.rpt_TiempoPorProyecto.TabIndex = 0;
            this.rpt_TiempoPorProyecto.Load += new System.EventHandler(this.rpt_TiempoPorProyecto_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.ltxt_fechaFinalizacion);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 43);
            this.panel1.TabIndex = 2;
            // 
            // ltxt_fechaFinalizacion
            // 
            this.ltxt_fechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt_fechaFinalizacion.Location = new System.Drawing.Point(530, 11);
            this.ltxt_fechaFinalizacion.Margin = new System.Windows.Forms.Padding(4);
            this.ltxt_fechaFinalizacion.Name = "ltxt_fechaFinalizacion";
            this.ltxt_fechaFinalizacion.Pp_Etiqueta = "Año:";
            this.ltxt_fechaFinalizacion.Pp_mask = "0000";
            this.ltxt_fechaFinalizacion.Pp_mensajeError = null;
            this.ltxt_fechaFinalizacion.Pp_nombre_campo = null;
            this.ltxt_fechaFinalizacion.Pp_nombre_tabla = null;
            this.ltxt_fechaFinalizacion.Pp_ReadOnly = false;
            this.ltxt_fechaFinalizacion.Pp_Text = "";
            this.ltxt_fechaFinalizacion.Pp_validable = false;
            this.ltxt_fechaFinalizacion.Size = new System.Drawing.Size(228, 28);
            this.ltxt_fechaFinalizacion.TabIndex = 0;
            // 
            // ReporteTiempoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(806, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rpt_TiempoPorProyecto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteTiempoProyecto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ReporteTiempoProyecto_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_TiempoPorProyecto;
        private System.Windows.Forms.Panel panel1;
        private Clases.LabelText01 ltxt_fechaFinalizacion;
    }
}