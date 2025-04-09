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
            iconcerrar = new System.Windows.Forms.PictureBox();
            iconmaximizar = new System.Windows.Forms.PictureBox();
            iconrestaurar = new System.Windows.Forms.PictureBox();
            iconminimizar = new System.Windows.Forms.PictureBox();
            BarraTitulo = new System.Windows.Forms.Panel();
            Ofertas = new System.Windows.Forms.Button();
            iViajeLogo = new System.Windows.Forms.PictureBox();
            Informacion = new System.Windows.Forms.Button();
            Inicio = new System.Windows.Forms.Button();
            Paquetes = new System.Windows.Forms.Button();
            Administracion = new System.Windows.Forms.Button();
            panelContenedor = new System.Windows.Forms.Panel();
            PanelInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iViajeLogo).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            iconcerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            iconcerrar.Image = (System.Drawing.Image)resources.GetObject("iconcerrar.Image");
            iconcerrar.Location = new System.Drawing.Point(1482, 10);
            iconcerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new System.Drawing.Size(21, 21);
            iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            iconcerrar.TabIndex = 1;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            iconmaximizar.Image = (System.Drawing.Image)resources.GetObject("iconmaximizar.Image");
            iconmaximizar.Location = new System.Drawing.Point(1454, 10);
            iconmaximizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new System.Drawing.Size(21, 21);
            iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            iconmaximizar.TabIndex = 2;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            iconrestaurar.BackColor = System.Drawing.Color.White;
            iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            iconrestaurar.Image = (System.Drawing.Image)resources.GetObject("iconrestaurar.Image");
            iconrestaurar.Location = new System.Drawing.Point(1454, 10);
            iconrestaurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new System.Drawing.Size(21, 21);
            iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 1;
            iconrestaurar.TabStop = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            iconminimizar.BackColor = System.Drawing.Color.White;
            iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            iconminimizar.Image = (System.Drawing.Image)resources.GetObject("iconminimizar.Image");
            iconminimizar.Location = new System.Drawing.Point(1426, 10);
            iconminimizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new System.Drawing.Size(21, 21);
            iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 2;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = System.Drawing.Color.White;
            BarraTitulo.Controls.Add(Ofertas);
            BarraTitulo.Controls.Add(iViajeLogo);
            BarraTitulo.Controls.Add(Informacion);
            BarraTitulo.Controls.Add(Inicio);
            BarraTitulo.Controls.Add(Paquetes);
            BarraTitulo.Controls.Add(Administracion);
            BarraTitulo.Controls.Add(iconminimizar);
            BarraTitulo.Controls.Add(iconrestaurar);
            BarraTitulo.Controls.Add(iconmaximizar);
            BarraTitulo.Controls.Add(iconcerrar);
            BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            BarraTitulo.Location = new System.Drawing.Point(0, 0);
            BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new System.Drawing.Size(1517, 58);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // Ofertas
            // 
            Ofertas.FlatAppearance.BorderSize = 0;
            Ofertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Ofertas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Ofertas.ForeColor = System.Drawing.Color.Teal;
            Ofertas.Location = new System.Drawing.Point(553, 12);
            Ofertas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Ofertas.Name = "Ofertas";
            Ofertas.Size = new System.Drawing.Size(219, 37);
            Ofertas.TabIndex = 19;
            Ofertas.Text = "Ofertas";
            Ofertas.UseVisualStyleBackColor = true;
            Ofertas.Click += Ofertas_Click;
            // 
            // iViajeLogo
            // 
            iViajeLogo.BackColor = System.Drawing.Color.White;
            iViajeLogo.Image = (System.Drawing.Image)resources.GetObject("iViajeLogo.Image");
            iViajeLogo.Location = new System.Drawing.Point(0, 0);
            iViajeLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            iViajeLogo.Name = "iViajeLogo";
            iViajeLogo.Size = new System.Drawing.Size(150, 58);
            iViajeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            iViajeLogo.TabIndex = 18;
            iViajeLogo.TabStop = false;
            // 
            // Informacion
            // 
            Informacion.FlatAppearance.BorderSize = 0;
            Informacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Informacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Informacion.ForeColor = System.Drawing.Color.Teal;
            Informacion.Location = new System.Drawing.Point(798, 12);
            Informacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Informacion.Name = "Informacion";
            Informacion.Size = new System.Drawing.Size(219, 38);
            Informacion.TabIndex = 6;
            Informacion.Text = "Información";
            Informacion.UseVisualStyleBackColor = true;
            Informacion.Click += Informacion_Click;
            // 
            // Inicio
            // 
            Inicio.FlatAppearance.BorderSize = 0;
            Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Inicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Inicio.ForeColor = System.Drawing.Color.Teal;
            Inicio.Location = new System.Drawing.Point(190, 12);
            Inicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Inicio.Name = "Inicio";
            Inicio.Size = new System.Drawing.Size(69, 38);
            Inicio.TabIndex = 5;
            Inicio.Text = "Inicio";
            Inicio.UseVisualStyleBackColor = true;
            Inicio.Click += Inicio_Click;
            // 
            // Paquetes
            // 
            Paquetes.FlatAppearance.BorderSize = 0;
            Paquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Paquetes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Paquetes.ForeColor = System.Drawing.Color.Teal;
            Paquetes.Location = new System.Drawing.Point(301, 12);
            Paquetes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Paquetes.Name = "Paquetes";
            Paquetes.Size = new System.Drawing.Size(219, 37);
            Paquetes.TabIndex = 4;
            Paquetes.Text = "Paquetes ";
            Paquetes.UseVisualStyleBackColor = true;
            Paquetes.Click += Paquetes_Click;
            // 
            // Administracion
            // 
            Administracion.FlatAppearance.BorderSize = 0;
            Administracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Administracion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Administracion.ForeColor = System.Drawing.Color.Teal;
            Administracion.Location = new System.Drawing.Point(1269, 14);
            Administracion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Administracion.Name = "Administracion";
            Administracion.Size = new System.Drawing.Size(149, 37);
            Administracion.TabIndex = 3;
            Administracion.Text = "Administración";
            Administracion.UseVisualStyleBackColor = true;
            Administracion.Click += Administracion_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = System.Drawing.Color.Transparent;
            panelContenedor.Controls.Add(PanelInicio);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(0, 58);
            panelContenedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(1517, 692);
            panelContenedor.TabIndex = 38;
            // 
            // PanelInicio
            // 
            PanelInicio.BackColor = System.Drawing.Color.Transparent;
            PanelInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            PanelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelInicio.FlatAppearance.BorderSize = 0;
            PanelInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PanelInicio.Font = new System.Drawing.Font("Ananda", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            PanelInicio.ForeColor = System.Drawing.Color.Transparent;
            PanelInicio.Image = (System.Drawing.Image)resources.GetObject("PanelInicio.Image");
            PanelInicio.Location = new System.Drawing.Point(0, 0);
            PanelInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PanelInicio.Name = "PanelInicio";
            PanelInicio.Size = new System.Drawing.Size(1517, 692);
            PanelInicio.TabIndex = 5;
            PanelInicio.Text = "iViaje";
            PanelInicio.UseCompatibleTextRendering = true;
            PanelInicio.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1517, 750);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iViajeLogo).EndInit();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);

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

