using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PROYECTO_FINAL
{
    public partial class ReservasClientes : Form
    {
        public ReservasClientes()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-URDRB0N\\SQLEXPRESS; Initial Catalog=IVIAJE");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxDestinoGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btnCargarGrp_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-URDRB0N\\SQLEXPRESS;Database=IVIAJE;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("¡Conexión exitosa!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            conexion.Open();
            string consulta = "select * from DestinoInternacionalPorGrupo";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                comboBoxDestinoGrupo.Items.Add(lector.GetSqlString(1));
            }
            conexion.Close();
        }
    }
}
