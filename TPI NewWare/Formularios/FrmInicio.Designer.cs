namespace TPI_NewWare
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.panelBarrraSup = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubEstadisticas = new System.Windows.Forms.Panel();
            this.btnSubEstTiemProy = new FontAwesome.Sharp.IconButton();
            this.btnSubEstGantt = new FontAwesome.Sharp.IconButton();
            this.tndSubEstRendEmp = new FontAwesome.Sharp.IconButton();
            this.btnSubEstUsoHerram = new FontAwesome.Sharp.IconButton();
            this.btnSubEstProdVend = new FontAwesome.Sharp.IconButton();
            this.btnEstadisticas = new FontAwesome.Sharp.IconButton();
            this.panelSubGenerar = new System.Windows.Forms.Panel();
            this.btnSubReportes = new FontAwesome.Sharp.IconButton();
            this.btnSubListados = new FontAwesome.Sharp.IconButton();
            this.btnGenerar = new FontAwesome.Sharp.IconButton();
            this.panelSubGestionar = new System.Windows.Forms.Panel();
            this.btnSubTareas = new FontAwesome.Sharp.IconButton();
            this.btnSubEgresoEmp = new FontAwesome.Sharp.IconButton();
            this.btnSubVentasProd = new FontAwesome.Sharp.IconButton();
            this.btnSubProyectos = new FontAwesome.Sharp.IconButton();
            this.btnGestionar = new FontAwesome.Sharp.IconButton();
            this.panelSubSoporte = new System.Windows.Forms.Panel();
            this.btnSubMotivoEgreso = new FontAwesome.Sharp.IconButton();
            this.btnSubTipoDoc = new FontAwesome.Sharp.IconButton();
            this.btnSubEtapas = new FontAwesome.Sharp.IconButton();
            this.btnSubHerramientas = new FontAwesome.Sharp.IconButton();
            this.btnSubRoles = new FontAwesome.Sharp.IconButton();
            this.btnSoporte = new FontAwesome.Sharp.IconButton();
            this.panelSubAdministrar = new System.Windows.Forms.Panel();
            this.btnSubProductos = new FontAwesome.Sharp.IconButton();
            this.btnSubClientes = new FontAwesome.Sharp.IconButton();
            this.btnSubEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnAdministrar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarrraSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubEstadisticas.SuspendLayout();
            this.panelSubGenerar.SuspendLayout();
            this.panelSubGestionar.SuspendLayout();
            this.panelSubSoporte.SuspendLayout();
            this.panelSubAdministrar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarrraSup
            // 
            this.panelBarrraSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBarrraSup.Controls.Add(this.lbl_Titulo);
            this.panelBarrraSup.Controls.Add(this.panel1);
            this.panelBarrraSup.Controls.Add(this.picLogin);
            this.panelBarrraSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarrraSup.Location = new System.Drawing.Point(225, 0);
            this.panelBarrraSup.Name = "panelBarrraSup";
            this.panelBarrraSup.Size = new System.Drawing.Size(806, 100);
            this.panelBarrraSup.TabIndex = 14;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(31, 27);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(191, 52);
            this.lbl_Titulo.TabIndex = 13;
            this.lbl_Titulo.Text = "              ";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Titulo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(614, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 97);
            this.panel1.TabIndex = 12;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(707, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(74, 67);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 11;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelUsuario);
            this.panelPrincipal.Location = new System.Drawing.Point(225, 100);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(806, 500);
            this.panelPrincipal.TabIndex = 15;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.btnCerrarSesion);
            this.panelUsuario.Controls.Add(this.btnSalir);
            this.panelUsuario.Location = new System.Drawing.Point(641, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(165, 87);
            this.panelUsuario.TabIndex = 2;
            this.panelUsuario.Visible = false;
            this.panelUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panelUsuario.MouseLeave += new System.EventHandler(this.panelUsuario_MouseLeave);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconSize = 20;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(33, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Rotation = 0D;
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 30);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconSize = 20;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(33, 29);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(120, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.panelSubEstadisticas);
            this.panelMenu.Controls.Add(this.btnEstadisticas);
            this.panelMenu.Controls.Add(this.panelSubGenerar);
            this.panelMenu.Controls.Add(this.btnGenerar);
            this.panelMenu.Controls.Add(this.panelSubGestionar);
            this.panelMenu.Controls.Add(this.btnGestionar);
            this.panelMenu.Controls.Add(this.panelSubSoporte);
            this.panelMenu.Controls.Add(this.btnSoporte);
            this.panelMenu.Controls.Add(this.panelSubAdministrar);
            this.panelMenu.Controls.Add(this.btnAdministrar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 603);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSubEstadisticas
            // 
            this.panelSubEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(165)))), ((int)(((byte)(202)))));
            this.panelSubEstadisticas.Controls.Add(this.btnSubEstTiemProy);
            this.panelSubEstadisticas.Controls.Add(this.btnSubEstGantt);
            this.panelSubEstadisticas.Controls.Add(this.tndSubEstRendEmp);
            this.panelSubEstadisticas.Controls.Add(this.btnSubEstUsoHerram);
            this.panelSubEstadisticas.Controls.Add(this.btnSubEstProdVend);
            this.panelSubEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubEstadisticas.Location = new System.Drawing.Point(0, 868);
            this.panelSubEstadisticas.Name = "panelSubEstadisticas";
            this.panelSubEstadisticas.Size = new System.Drawing.Size(208, 205);
            this.panelSubEstadisticas.TabIndex = 13;
            this.panelSubEstadisticas.Visible = false;
            // 
            // btnSubEstTiemProy
            // 
            this.btnSubEstTiemProy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEstTiemProy.FlatAppearance.BorderSize = 0;
            this.btnSubEstTiemProy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEstTiemProy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubEstTiemProy.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubEstTiemProy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubEstTiemProy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubEstTiemProy.IconColor = System.Drawing.Color.Black;
            this.btnSubEstTiemProy.IconSize = 16;
            this.btnSubEstTiemProy.Location = new System.Drawing.Point(0, 160);
            this.btnSubEstTiemProy.Name = "btnSubEstTiemProy";
            this.btnSubEstTiemProy.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubEstTiemProy.Rotation = 0D;
            this.btnSubEstTiemProy.Size = new System.Drawing.Size(208, 40);
            this.btnSubEstTiemProy.TabIndex = 4;
            this.btnSubEstTiemProy.Text = "Tiempo de proyecto";
            this.btnSubEstTiemProy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEstTiemProy.UseVisualStyleBackColor = true;
            // 
            // btnSubEstGantt
            // 
            this.btnSubEstGantt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEstGantt.FlatAppearance.BorderSize = 0;
            this.btnSubEstGantt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEstGantt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubEstGantt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubEstGantt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubEstGantt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubEstGantt.IconColor = System.Drawing.Color.Black;
            this.btnSubEstGantt.IconSize = 16;
            this.btnSubEstGantt.Location = new System.Drawing.Point(0, 120);
            this.btnSubEstGantt.Name = "btnSubEstGantt";
            this.btnSubEstGantt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubEstGantt.Rotation = 0D;
            this.btnSubEstGantt.Size = new System.Drawing.Size(208, 40);
            this.btnSubEstGantt.TabIndex = 3;
            this.btnSubEstGantt.Text = "Tareas por etapa";
            this.btnSubEstGantt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEstGantt.UseVisualStyleBackColor = true;
            // 
            // tndSubEstRendEmp
            // 
            this.tndSubEstRendEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tndSubEstRendEmp.FlatAppearance.BorderSize = 0;
            this.tndSubEstRendEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tndSubEstRendEmp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.tndSubEstRendEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.tndSubEstRendEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tndSubEstRendEmp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tndSubEstRendEmp.IconColor = System.Drawing.Color.Black;
            this.tndSubEstRendEmp.IconSize = 16;
            this.tndSubEstRendEmp.Location = new System.Drawing.Point(0, 80);
            this.tndSubEstRendEmp.Name = "tndSubEstRendEmp";
            this.tndSubEstRendEmp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.tndSubEstRendEmp.Rotation = 0D;
            this.tndSubEstRendEmp.Size = new System.Drawing.Size(208, 40);
            this.tndSubEstRendEmp.TabIndex = 2;
            this.tndSubEstRendEmp.Text = "Rendimiento empleados";
            this.tndSubEstRendEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tndSubEstRendEmp.UseVisualStyleBackColor = true;
            // 
            // btnSubEstUsoHerram
            // 
            this.btnSubEstUsoHerram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEstUsoHerram.FlatAppearance.BorderSize = 0;
            this.btnSubEstUsoHerram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEstUsoHerram.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubEstUsoHerram.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubEstUsoHerram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubEstUsoHerram.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubEstUsoHerram.IconColor = System.Drawing.Color.Black;
            this.btnSubEstUsoHerram.IconSize = 16;
            this.btnSubEstUsoHerram.Location = new System.Drawing.Point(0, 40);
            this.btnSubEstUsoHerram.Name = "btnSubEstUsoHerram";
            this.btnSubEstUsoHerram.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubEstUsoHerram.Rotation = 0D;
            this.btnSubEstUsoHerram.Size = new System.Drawing.Size(208, 40);
            this.btnSubEstUsoHerram.TabIndex = 1;
            this.btnSubEstUsoHerram.Text = "Uso de herramientas";
            this.btnSubEstUsoHerram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEstUsoHerram.UseVisualStyleBackColor = true;
            // 
            // btnSubEstProdVend
            // 
            this.btnSubEstProdVend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEstProdVend.FlatAppearance.BorderSize = 0;
            this.btnSubEstProdVend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEstProdVend.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubEstProdVend.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubEstProdVend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubEstProdVend.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubEstProdVend.IconColor = System.Drawing.Color.Black;
            this.btnSubEstProdVend.IconSize = 16;
            this.btnSubEstProdVend.Location = new System.Drawing.Point(0, 0);
            this.btnSubEstProdVend.Name = "btnSubEstProdVend";
            this.btnSubEstProdVend.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubEstProdVend.Rotation = 0D;
            this.btnSubEstProdVend.Size = new System.Drawing.Size(208, 40);
            this.btnSubEstProdVend.TabIndex = 0;
            this.btnSubEstProdVend.Text = "Productos vendidos";
            this.btnSubEstProdVend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEstProdVend.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEstadisticas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnEstadisticas.IconColor = System.Drawing.Color.White;
            this.btnEstadisticas.IconSize = 32;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 828);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Rotation = 0D;
            this.btnEstadisticas.Size = new System.Drawing.Size(208, 40);
            this.btnEstadisticas.TabIndex = 12;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // panelSubGenerar
            // 
            this.panelSubGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(165)))), ((int)(((byte)(202)))));
            this.panelSubGenerar.Controls.Add(this.btnSubReportes);
            this.panelSubGenerar.Controls.Add(this.btnSubListados);
            this.panelSubGenerar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGenerar.Location = new System.Drawing.Point(0, 747);
            this.panelSubGenerar.Name = "panelSubGenerar";
            this.panelSubGenerar.Size = new System.Drawing.Size(208, 81);
            this.panelSubGenerar.TabIndex = 11;
            this.panelSubGenerar.Visible = false;
            // 
            // btnSubReportes
            // 
            this.btnSubReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubReportes.FlatAppearance.BorderSize = 0;
            this.btnSubReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubReportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubReportes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubReportes.IconColor = System.Drawing.Color.Black;
            this.btnSubReportes.IconSize = 16;
            this.btnSubReportes.Location = new System.Drawing.Point(0, 40);
            this.btnSubReportes.Name = "btnSubReportes";
            this.btnSubReportes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubReportes.Rotation = 0D;
            this.btnSubReportes.Size = new System.Drawing.Size(208, 40);
            this.btnSubReportes.TabIndex = 1;
            this.btnSubReportes.Text = "Reportes";
            this.btnSubReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubReportes.UseVisualStyleBackColor = true;
            // 
            // btnSubListados
            // 
            this.btnSubListados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubListados.FlatAppearance.BorderSize = 0;
            this.btnSubListados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubListados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubListados.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubListados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubListados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubListados.IconColor = System.Drawing.Color.Black;
            this.btnSubListados.IconSize = 16;
            this.btnSubListados.Location = new System.Drawing.Point(0, 0);
            this.btnSubListados.Name = "btnSubListados";
            this.btnSubListados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubListados.Rotation = 0D;
            this.btnSubListados.Size = new System.Drawing.Size(208, 40);
            this.btnSubListados.TabIndex = 0;
            this.btnSubListados.Text = "Listados";
            this.btnSubListados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubListados.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnGenerar.IconColor = System.Drawing.Color.White;
            this.btnGenerar.IconSize = 32;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(0, 707);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Rotation = 0D;
            this.btnGenerar.Size = new System.Drawing.Size(208, 40);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panelSubGestionar
            // 
            this.panelSubGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(165)))), ((int)(((byte)(202)))));
            this.panelSubGestionar.Controls.Add(this.btnSubTareas);
            this.panelSubGestionar.Controls.Add(this.btnSubEgresoEmp);
            this.panelSubGestionar.Controls.Add(this.btnSubVentasProd);
            this.panelSubGestionar.Controls.Add(this.btnSubProyectos);
            this.panelSubGestionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGestionar.Location = new System.Drawing.Point(0, 545);
            this.panelSubGestionar.Name = "panelSubGestionar";
            this.panelSubGestionar.Size = new System.Drawing.Size(208, 162);
            this.panelSubGestionar.TabIndex = 9;
            this.panelSubGestionar.Visible = false;
            // 
            // btnSubTareas
            // 
            this.btnSubTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubTareas.FlatAppearance.BorderSize = 0;
            this.btnSubTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTareas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubTareas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubTareas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubTareas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubTareas.IconColor = System.Drawing.Color.Black;
            this.btnSubTareas.IconSize = 16;
            this.btnSubTareas.Location = new System.Drawing.Point(0, 120);
            this.btnSubTareas.Name = "btnSubTareas";
            this.btnSubTareas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubTareas.Rotation = 0D;
            this.btnSubTareas.Size = new System.Drawing.Size(208, 40);
            this.btnSubTareas.TabIndex = 3;
            this.btnSubTareas.Text = "Tareas";
            this.btnSubTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTareas.UseVisualStyleBackColor = true;
            // 
            // btnSubEgresoEmp
            // 
            this.btnSubEgresoEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEgresoEmp.FlatAppearance.BorderSize = 0;
            this.btnSubEgresoEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEgresoEmp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubEgresoEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubEgresoEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubEgresoEmp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubEgresoEmp.IconColor = System.Drawing.Color.Black;
            this.btnSubEgresoEmp.IconSize = 16;
            this.btnSubEgresoEmp.Location = new System.Drawing.Point(0, 80);
            this.btnSubEgresoEmp.Name = "btnSubEgresoEmp";
            this.btnSubEgresoEmp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubEgresoEmp.Rotation = 0D;
            this.btnSubEgresoEmp.Size = new System.Drawing.Size(208, 40);
            this.btnSubEgresoEmp.TabIndex = 2;
            this.btnSubEgresoEmp.Text = "Egreso de empleado";
            this.btnSubEgresoEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEgresoEmp.UseVisualStyleBackColor = true;
            // 
            // btnSubVentasProd
            // 
            this.btnSubVentasProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubVentasProd.FlatAppearance.BorderSize = 0;
            this.btnSubVentasProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubVentasProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubVentasProd.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubVentasProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubVentasProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubVentasProd.IconColor = System.Drawing.Color.Black;
            this.btnSubVentasProd.IconSize = 16;
            this.btnSubVentasProd.Location = new System.Drawing.Point(0, 40);
            this.btnSubVentasProd.Name = "btnSubVentasProd";
            this.btnSubVentasProd.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubVentasProd.Rotation = 0D;
            this.btnSubVentasProd.Size = new System.Drawing.Size(208, 40);
            this.btnSubVentasProd.TabIndex = 1;
            this.btnSubVentasProd.Text = "Ventas producto";
            this.btnSubVentasProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubVentasProd.UseVisualStyleBackColor = true;
            this.btnSubVentasProd.Click += new System.EventHandler(this.btnSubVentasProd_Click);
            // 
            // btnSubProyectos
            // 
            this.btnSubProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubProyectos.FlatAppearance.BorderSize = 0;
            this.btnSubProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProyectos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubProyectos.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubProyectos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubProyectos.IconColor = System.Drawing.Color.Black;
            this.btnSubProyectos.IconSize = 16;
            this.btnSubProyectos.Location = new System.Drawing.Point(0, 0);
            this.btnSubProyectos.Name = "btnSubProyectos";
            this.btnSubProyectos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubProyectos.Rotation = 0D;
            this.btnSubProyectos.Size = new System.Drawing.Size(208, 40);
            this.btnSubProyectos.TabIndex = 0;
            this.btnSubProyectos.Text = "Proyectos";
            this.btnSubProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProyectos.UseVisualStyleBackColor = true;
            this.btnSubProyectos.Click += new System.EventHandler(this.btnSubProyectos_Click);
            // 
            // btnGestionar
            // 
            this.btnGestionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionar.FlatAppearance.BorderSize = 0;
            this.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGestionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionar.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnGestionar.IconColor = System.Drawing.Color.White;
            this.btnGestionar.IconSize = 32;
            this.btnGestionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionar.Location = new System.Drawing.Point(0, 505);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Rotation = 0D;
            this.btnGestionar.Size = new System.Drawing.Size(208, 40);
            this.btnGestionar.TabIndex = 8;
            this.btnGestionar.Text = "Gestionar";
            this.btnGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionar.UseVisualStyleBackColor = false;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // panelSubSoporte
            // 
            this.panelSubSoporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(165)))), ((int)(((byte)(202)))));
            this.panelSubSoporte.Controls.Add(this.btnSubMotivoEgreso);
            this.panelSubSoporte.Controls.Add(this.btnSubTipoDoc);
            this.panelSubSoporte.Controls.Add(this.btnSubEtapas);
            this.panelSubSoporte.Controls.Add(this.btnSubHerramientas);
            this.panelSubSoporte.Controls.Add(this.btnSubRoles);
            this.panelSubSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSoporte.Location = new System.Drawing.Point(0, 303);
            this.panelSubSoporte.Name = "panelSubSoporte";
            this.panelSubSoporte.Size = new System.Drawing.Size(208, 202);
            this.panelSubSoporte.TabIndex = 7;
            this.panelSubSoporte.Visible = false;
            // 
            // btnSubMotivoEgreso
            // 
            this.btnSubMotivoEgreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMotivoEgreso.FlatAppearance.BorderSize = 0;
            this.btnSubMotivoEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMotivoEgreso.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubMotivoEgreso.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubMotivoEgreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubMotivoEgreso.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubMotivoEgreso.IconColor = System.Drawing.Color.Black;
            this.btnSubMotivoEgreso.IconSize = 16;
            this.btnSubMotivoEgreso.Location = new System.Drawing.Point(0, 160);
            this.btnSubMotivoEgreso.Name = "btnSubMotivoEgreso";
            this.btnSubMotivoEgreso.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubMotivoEgreso.Rotation = 0D;
            this.btnSubMotivoEgreso.Size = new System.Drawing.Size(208, 40);
            this.btnSubMotivoEgreso.TabIndex = 4;
            this.btnSubMotivoEgreso.Text = "Motivo de egreso";
            this.btnSubMotivoEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMotivoEgreso.UseVisualStyleBackColor = true;
            this.btnSubMotivoEgreso.Click += new System.EventHandler(this.btnSubMotivoEgreso_Click);
            // 
            // btnSubTipoDoc
            // 
            this.btnSubTipoDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubTipoDoc.FlatAppearance.BorderSize = 0;
            this.btnSubTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTipoDoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubTipoDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubTipoDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubTipoDoc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubTipoDoc.IconColor = System.Drawing.Color.Black;
            this.btnSubTipoDoc.IconSize = 16;
            this.btnSubTipoDoc.Location = new System.Drawing.Point(0, 120);
            this.btnSubTipoDoc.Name = "btnSubTipoDoc";
            this.btnSubTipoDoc.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubTipoDoc.Rotation = 0D;
            this.btnSubTipoDoc.Size = new System.Drawing.Size(208, 40);
            this.btnSubTipoDoc.TabIndex = 3;
            this.btnSubTipoDoc.Text = "Tipo de documento";
            this.btnSubTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTipoDoc.UseVisualStyleBackColor = true;
            this.btnSubTipoDoc.Click += new System.EventHandler(this.btnSubTipoDoc_Click);
            // 
            // btnSubEtapas
            // 
            this.btnSubEtapas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEtapas.FlatAppearance.BorderSize = 0;
            this.btnSubEtapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEtapas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubEtapas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubEtapas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubEtapas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubEtapas.IconColor = System.Drawing.Color.Black;
            this.btnSubEtapas.IconSize = 16;
            this.btnSubEtapas.Location = new System.Drawing.Point(0, 80);
            this.btnSubEtapas.Name = "btnSubEtapas";
            this.btnSubEtapas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubEtapas.Rotation = 0D;
            this.btnSubEtapas.Size = new System.Drawing.Size(208, 40);
            this.btnSubEtapas.TabIndex = 2;
            this.btnSubEtapas.Text = "Etapas";
            this.btnSubEtapas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEtapas.UseVisualStyleBackColor = true;
            this.btnSubEtapas.Click += new System.EventHandler(this.btnSubEtapas_Click);
            // 
            // btnSubHerramientas
            // 
            this.btnSubHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubHerramientas.FlatAppearance.BorderSize = 0;
            this.btnSubHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHerramientas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubHerramientas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubHerramientas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubHerramientas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubHerramientas.IconColor = System.Drawing.Color.Black;
            this.btnSubHerramientas.IconSize = 16;
            this.btnSubHerramientas.Location = new System.Drawing.Point(0, 40);
            this.btnSubHerramientas.Name = "btnSubHerramientas";
            this.btnSubHerramientas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubHerramientas.Rotation = 0D;
            this.btnSubHerramientas.Size = new System.Drawing.Size(208, 40);
            this.btnSubHerramientas.TabIndex = 1;
            this.btnSubHerramientas.Text = "Herramientas";
            this.btnSubHerramientas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHerramientas.UseVisualStyleBackColor = true;
            this.btnSubHerramientas.Click += new System.EventHandler(this.btnSubHerramientas_Click);
            // 
            // btnSubRoles
            // 
            this.btnSubRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubRoles.FlatAppearance.BorderSize = 0;
            this.btnSubRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubRoles.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubRoles.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubRoles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubRoles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubRoles.IconColor = System.Drawing.Color.Black;
            this.btnSubRoles.IconSize = 16;
            this.btnSubRoles.Location = new System.Drawing.Point(0, 0);
            this.btnSubRoles.Name = "btnSubRoles";
            this.btnSubRoles.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubRoles.Rotation = 0D;
            this.btnSubRoles.Size = new System.Drawing.Size(208, 40);
            this.btnSubRoles.TabIndex = 0;
            this.btnSubRoles.Text = "Roles";
            this.btnSubRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubRoles.UseVisualStyleBackColor = true;
            this.btnSubRoles.Click += new System.EventHandler(this.btnSubRoles_Click);
            // 
            // btnSoporte
            // 
            this.btnSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoporte.FlatAppearance.BorderSize = 0;
            this.btnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoporte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSoporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSoporte.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSoporte.IconColor = System.Drawing.Color.White;
            this.btnSoporte.IconSize = 32;
            this.btnSoporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoporte.Location = new System.Drawing.Point(0, 263);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Rotation = 0D;
            this.btnSoporte.Size = new System.Drawing.Size(208, 40);
            this.btnSoporte.TabIndex = 6;
            this.btnSoporte.Text = "Soporte";
            this.btnSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoporte.UseVisualStyleBackColor = false;
            this.btnSoporte.Click += new System.EventHandler(this.btnSoporte_Click);
            // 
            // panelSubAdministrar
            // 
            this.panelSubAdministrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(165)))), ((int)(((byte)(202)))));
            this.panelSubAdministrar.Controls.Add(this.btnSubProductos);
            this.panelSubAdministrar.Controls.Add(this.btnSubClientes);
            this.panelSubAdministrar.Controls.Add(this.btnSubEmpleados);
            this.panelSubAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubAdministrar.Location = new System.Drawing.Point(0, 140);
            this.panelSubAdministrar.Name = "panelSubAdministrar";
            this.panelSubAdministrar.Size = new System.Drawing.Size(208, 123);
            this.panelSubAdministrar.TabIndex = 5;
            this.panelSubAdministrar.Visible = false;
            // 
            // btnSubProductos
            // 
            this.btnSubProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubProductos.FlatAppearance.BorderSize = 0;
            this.btnSubProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubProductos.IconColor = System.Drawing.Color.Black;
            this.btnSubProductos.IconSize = 16;
            this.btnSubProductos.Location = new System.Drawing.Point(0, 80);
            this.btnSubProductos.Name = "btnSubProductos";
            this.btnSubProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubProductos.Rotation = 0D;
            this.btnSubProductos.Size = new System.Drawing.Size(208, 40);
            this.btnSubProductos.TabIndex = 2;
            this.btnSubProductos.Text = "Productos";
            this.btnSubProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProductos.UseVisualStyleBackColor = true;
            this.btnSubProductos.Click += new System.EventHandler(this.btnSubProductos_Click);
            // 
            // btnSubClientes
            // 
            this.btnSubClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubClientes.FlatAppearance.BorderSize = 0;
            this.btnSubClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubClientes.IconColor = System.Drawing.Color.Black;
            this.btnSubClientes.IconSize = 16;
            this.btnSubClientes.Location = new System.Drawing.Point(0, 40);
            this.btnSubClientes.Name = "btnSubClientes";
            this.btnSubClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubClientes.Rotation = 0D;
            this.btnSubClientes.Size = new System.Drawing.Size(208, 40);
            this.btnSubClientes.TabIndex = 1;
            this.btnSubClientes.Text = "Clientes";
            this.btnSubClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubClientes.UseVisualStyleBackColor = true;
            this.btnSubClientes.Click += new System.EventHandler(this.btnSubClientes_Click);
            // 
            // btnSubEmpleados
            // 
            this.btnSubEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEmpleados.FlatAppearance.BorderSize = 0;
            this.btnSubEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEmpleados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubEmpleados.IconColor = System.Drawing.Color.Black;
            this.btnSubEmpleados.IconSize = 16;
            this.btnSubEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnSubEmpleados.Name = "btnSubEmpleados";
            this.btnSubEmpleados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubEmpleados.Rotation = 0D;
            this.btnSubEmpleados.Size = new System.Drawing.Size(208, 40);
            this.btnSubEmpleados.TabIndex = 0;
            this.btnSubEmpleados.Text = "Empleados";
            this.btnSubEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEmpleados.UseVisualStyleBackColor = true;
            this.btnSubEmpleados.Click += new System.EventHandler(this.btnSubEmpleados_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdministrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdministrar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnAdministrar.IconColor = System.Drawing.Color.White;
            this.btnAdministrar.IconSize = 32;
            this.btnAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.Location = new System.Drawing.Point(0, 100);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Rotation = 0D;
            this.btnAdministrar.Size = new System.Drawing.Size(208, 40);
            this.btnAdministrar.TabIndex = 4;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrar.UseVisualStyleBackColor = false;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(208, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1031, 603);
            this.Controls.Add(this.panelBarrraSup);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicio_FormClosed);
            this.Load += new System.EventHandler(this.Form_Inicio_Load);
            this.panelBarrraSup.ResumeLayout(false);
            this.panelBarrraSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelSubEstadisticas.ResumeLayout(false);
            this.panelSubGenerar.ResumeLayout(false);
            this.panelSubGestionar.ResumeLayout(false);
            this.panelSubSoporte.ResumeLayout(false);
            this.panelSubAdministrar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarrraSup;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox picLogin;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubGestionar;
        private FontAwesome.Sharp.IconButton btnSubTareas;
        private FontAwesome.Sharp.IconButton btnSubEgresoEmp;
        private FontAwesome.Sharp.IconButton btnSubVentasProd;
        private FontAwesome.Sharp.IconButton btnSubProyectos;
        private FontAwesome.Sharp.IconButton btnGestionar;
        private System.Windows.Forms.Panel panelSubSoporte;
        private FontAwesome.Sharp.IconButton btnSubMotivoEgreso;
        private FontAwesome.Sharp.IconButton btnSubTipoDoc;
        private FontAwesome.Sharp.IconButton btnSubEtapas;
        private FontAwesome.Sharp.IconButton btnSubHerramientas;
        private FontAwesome.Sharp.IconButton btnSubRoles;
        private FontAwesome.Sharp.IconButton btnSoporte;
        private System.Windows.Forms.Panel panelSubAdministrar;
        private FontAwesome.Sharp.IconButton btnSubProductos;
        private FontAwesome.Sharp.IconButton btnSubClientes;
        private FontAwesome.Sharp.IconButton btnSubEmpleados;
        private FontAwesome.Sharp.IconButton btnAdministrar;
        private System.Windows.Forms.Panel panelSubGenerar;
        private FontAwesome.Sharp.IconButton btnSubReportes;
        private FontAwesome.Sharp.IconButton btnSubListados;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private System.Windows.Forms.Panel panelSubEstadisticas;
        private FontAwesome.Sharp.IconButton btnSubEstTiemProy;
        private FontAwesome.Sharp.IconButton btnSubEstGantt;
        private FontAwesome.Sharp.IconButton tndSubEstRendEmp;
        private FontAwesome.Sharp.IconButton btnSubEstUsoHerram;
        private FontAwesome.Sharp.IconButton btnSubEstProdVend;
        private FontAwesome.Sharp.IconButton btnEstadisticas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}

