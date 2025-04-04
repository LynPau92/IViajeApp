namespace PROYECTO_FINAL
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.PanelInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.PanelInicio.Size = new System.Drawing.Size(800, 450);
            this.PanelInicio.TabIndex = 2;
            this.PanelInicio.Text = "iViaje";
            this.PanelInicio.UseCompatibleTextRendering = true;
            this.PanelInicio.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PanelInicio;
    }
}