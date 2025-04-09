using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace PROYECTO_FINAL
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void Informacion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Información());
        }

        private void Paquetes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Paquetes());
        }

        private void Ofertas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ofertas());
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void Sistema_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Admin());
        }

        private void Administracion_Click(object sender, EventArgs e)
        {
            string usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su usuario:", "Acceso a Administración", "");

            if (usuario == "Lyn")
            {
                string password = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña:", "Acceso a Administración", "");

                if (password == "1234")
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
