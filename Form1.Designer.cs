namespace PROYECTO_FINAL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Ofertas = new System.Windows.Forms.Button();
            this.iViajeLogo = new System.Windows.Forms.PictureBox();
            this.Informacion = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.Paquetes = new System.Windows.Forms.Button();
            this.Administracion = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.PanelInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iViajeLogo)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1270, 9);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(1246, 9);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(18, 18);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.BackColor = System.Drawing.Color.White;
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(1246, 9);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(18, 18);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 1;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.BackColor = System.Drawing.Color.White;
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(1222, 9);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(18, 18);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 2;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.Ofertas);
            this.BarraTitulo.Controls.Add(this.iViajeLogo);
            this.BarraTitulo.Controls.Add(this.Informacion);
            this.BarraTitulo.Controls.Add(this.Inicio);
            this.BarraTitulo.Controls.Add(this.Paquetes);
            this.BarraTitulo.Controls.Add(this.Administracion);
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Ofertas
            // 
            this.Ofertas.FlatAppearance.BorderSize = 0;
            this.Ofertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ofertas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ofertas.ForeColor = System.Drawing.Color.Teal;
            this.Ofertas.Location = new System.Drawing.Point(546, 12);
            this.Ofertas.Name = "Ofertas";
            this.Ofertas.Size = new System.Drawing.Size(188, 32);
            this.Ofertas.TabIndex = 19;
            this.Ofertas.Text = "Ofertas";
            this.Ofertas.UseVisualStyleBackColor = true;
            this.Ofertas.Click += new System.EventHandler(this.Ofertas_Click);
            // 
            // iViajeLogo
            // 
            this.iViajeLogo.BackColor = System.Drawing.Color.White;
            this.iViajeLogo.Image = ((System.Drawing.Image)(resources.GetObject("iViajeLogo.Image")));
            this.iViajeLogo.Location = new System.Drawing.Point(0, 0);
            this.iViajeLogo.Name = "iViajeLogo";
            this.iViajeLogo.Size = new System.Drawing.Size(215, 50);
            this.iViajeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iViajeLogo.TabIndex = 18;
            this.iViajeLogo.TabStop = false;
            // 
            // Informacion
            // 
            this.Informacion.FlatAppearance.BorderSize = 0;
            this.Informacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Informacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacion.ForeColor = System.Drawing.Color.Teal;
            this.Informacion.Location = new System.Drawing.Point(756, 12);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(188, 33);
            this.Informacion.TabIndex = 6;
            this.Informacion.Text = "Información";
            this.Informacion.UseVisualStyleBackColor = true;
            this.Informacion.Click += new System.EventHandler(this.Informacion_Click);
            // 
            // Inicio
            // 
            this.Inicio.FlatAppearance.BorderSize = 0;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.ForeColor = System.Drawing.Color.Teal;
            this.Inicio.Location = new System.Drawing.Point(235, 12);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(59, 33);
            this.Inicio.TabIndex = 5;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Paquetes
            // 
            this.Paquetes.FlatAppearance.BorderSize = 0;
            this.Paquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paquetes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paquetes.ForeColor = System.Drawing.Color.Teal;
            this.Paquetes.Location = new System.Drawing.Point(330, 12);
            this.Paquetes.Name = "Paquetes";
            this.Paquetes.Size = new System.Drawing.Size(188, 32);
            this.Paquetes.TabIndex = 4;
            this.Paquetes.Text = "Paquetes ";
            this.Paquetes.UseVisualStyleBackColor = true;
            this.Paquetes.Click += new System.EventHandler(this.Paquetes_Click);
            // 
            // Administracion
            // 
            this.Administracion.FlatAppearance.BorderSize = 0;
            this.Administracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administracion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administracion.ForeColor = System.Drawing.Color.Teal;
            this.Administracion.Location = new System.Drawing.Point(1088, 12);
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(128, 32);
            this.Administracion.TabIndex = 3;
            this.Administracion.Text = "Administración";
            this.Administracion.UseVisualStyleBackColor = true;
            this.Administracion.Click += new System.EventHandler(this.Administracion_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.PanelInicio);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1300, 600);
            this.panelContenedor.TabIndex = 38;
            // 
            // PanelInicio
            // 
            this.PanelInicio.BackColor = System.Drawing.Color.Transparent;
            this.PanelInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInicio.FlatAppearance.BorderSize = 0;
            this.PanelInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PanelInicio.Font = new System.Drawing.Font("Ananda", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanelInicio.ForeColor = System.Drawing.Color.Transparent;
            this.PanelInicio.Image = ((System.Drawing.Image)(resources.GetObject("PanelInicio.Image")));
            this.PanelInicio.Location = new System.Drawing.Point(0, 0);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(1300, 600);
            this.PanelInicio.TabIndex = 5;
            this.PanelInicio.Text = "iViaje";
            this.PanelInicio.UseCompatibleTextRendering = true;
            this.PanelInicio.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iViajeLogo)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button Administracion;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Paquetes;
        private System.Windows.Forms.Button Informacion;
        private System.Windows.Forms.PictureBox iViajeLogo;
        private System.Windows.Forms.Button PanelInicio;
        private System.Windows.Forms.Button Ofertas;
    }
}

