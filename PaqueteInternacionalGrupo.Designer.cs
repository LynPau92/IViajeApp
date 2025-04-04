namespace PROYECTO_FINAL
{
    partial class PaqueteInternacionalGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaqueteInternacionalGrupo));
            this.Cantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PaqIntGrupo = new System.Windows.Forms.Button();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reservasDataGridView = new System.Windows.Forms.DataGridView();
            this.personasComboBox = new System.Windows.Forms.ComboBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.destinoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaLlegadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.guardarReservaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Cantidad
            // 
            this.Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.ForeColor = System.Drawing.Color.Teal;
            this.Cantidad.Location = new System.Drawing.Point(235, 386);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(73, 16);
            this.Cantidad.TabIndex = 17;
            this.Cantidad.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(335, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(441, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(382, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reservar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PaqIntGrupo
            // 
            this.PaqIntGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaqIntGrupo.FlatAppearance.BorderSize = 0;
            this.PaqIntGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaqIntGrupo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaqIntGrupo.ForeColor = System.Drawing.Color.Teal;
            this.PaqIntGrupo.Location = new System.Drawing.Point(273, 2);
            this.PaqIntGrupo.Name = "PaqIntGrupo";
            this.PaqIntGrupo.Size = new System.Drawing.Size(258, 61);
            this.PaqIntGrupo.TabIndex = 20;
            this.PaqIntGrupo.Text = "Paquetes internacionales (grupos) ";
            this.PaqIntGrupo.UseVisualStyleBackColor = true;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(770, 2);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 38;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(265, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(244, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Destino";
            // 
            // reservasDataGridView
            // 
            this.reservasDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservasDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.reservasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservasDataGridView.Location = new System.Drawing.Point(218, 256);
            this.reservasDataGridView.Name = "reservasDataGridView";
            this.reservasDataGridView.Size = new System.Drawing.Size(406, 98);
            this.reservasDataGridView.TabIndex = 47;
            // 
            // personasComboBox
            // 
            this.personasComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personasComboBox.FormattingEnabled = true;
            this.personasComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.personasComboBox.Location = new System.Drawing.Point(457, 146);
            this.personasComboBox.Name = "personasComboBox";
            this.personasComboBox.Size = new System.Drawing.Size(56, 21);
            this.personasComboBox.TabIndex = 46;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefonoTextBox.Location = new System.Drawing.Point(572, 72);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(117, 20);
            this.telefonoTextBox.TabIndex = 45;
            this.telefonoTextBox.Text = "Teléfono";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(398, 72);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 20);
            this.emailTextBox.TabIndex = 44;
            this.emailTextBox.Text = "iviaje@gmail.com";
            // 
            // destinoComboBox
            // 
            this.destinoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destinoComboBox.FormattingEnabled = true;
            this.destinoComboBox.Items.AddRange(new object[] {
            "Colombia (Medellín-Bogotá) - 7 días y 6 noches",
            "Ecuador (Quito-Quilotoa-Baños de Agua Santa) - 7 días y 6 noches",
            "Perú (Lima-Cusco) - 7 días y 6 noches",
            "Guatemala - 7 días y 6 noches",
            "El Salvador - 7 días y 6 noches",
            "Disney - 5 días y 4 noches"});
            this.destinoComboBox.Location = new System.Drawing.Point(313, 110);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(271, 21);
            this.destinoComboBox.TabIndex = 43;
            this.destinoComboBox.Text = "  ";
            // 
            // fechaLlegadaDateTimePicker
            // 
            this.fechaLlegadaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaLlegadaDateTimePicker.Location = new System.Drawing.Point(366, 182);
            this.fechaLlegadaDateTimePicker.Name = "fechaLlegadaDateTimePicker";
            this.fechaLlegadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaLlegadaDateTimePicker.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(265, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cantidad de personas";
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreClienteTextBox.Location = new System.Drawing.Point(132, 72);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(246, 20);
            this.nombreClienteTextBox.TabIndex = 40;
            this.nombreClienteTextBox.Text = "Nombre completo";
            // 
            // guardarReservaButton
            // 
            this.guardarReservaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guardarReservaButton.FlatAppearance.BorderSize = 0;
            this.guardarReservaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarReservaButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarReservaButton.ForeColor = System.Drawing.Color.Teal;
            this.guardarReservaButton.Location = new System.Drawing.Point(366, 221);
            this.guardarReservaButton.Name = "guardarReservaButton";
            this.guardarReservaButton.Size = new System.Drawing.Size(121, 29);
            this.guardarReservaButton.TabIndex = 39;
            this.guardarReservaButton.Text = "Reservar";
            this.guardarReservaButton.UseVisualStyleBackColor = true;
            // 
            // PaqueteInternacionalGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservasDataGridView);
            this.Controls.Add(this.personasComboBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.destinoComboBox);
            this.Controls.Add(this.fechaLlegadaDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(this.guardarReservaButton);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.PaqIntGrupo);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaqueteInternacionalGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PaqIntGrupo;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reservasDataGridView;
        private System.Windows.Forms.ComboBox personasComboBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox destinoComboBox;
        private System.Windows.Forms.DateTimePicker fechaLlegadaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.Button guardarReservaButton;
    }
}