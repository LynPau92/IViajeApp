using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class ReservasPaqInt: Form
    {
        public ReservasPaqInt()
        {
            InitializeComponent();
        }

        public class Reserva
        {
            public string NombreCliente { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }
            public DateTime FechaLlegada { get; set; }
            public string Destino { get; set; }
            public int NumeroPersonas { get; set; }
        }

        private BindingList<Reserva> reservas = new BindingList<Reserva>();

        private void Form1_Load(object sender, EventArgs e)
        {
            destinoComboBox.Items.Add("Colombia (Medellín-Bogotá)");
            destinoComboBox.Items.Add("Ecuador(Quito - Quilotoa - Baños de Agua Santa)");
            destinoComboBox.Items.Add("Perú(Lima - Cusco)");
            destinoComboBox.Items.Add("Guatemala");
            destinoComboBox.Items.Add("El Salvador");
            destinoComboBox.Items.Add("Disney");

            personasComboBox.Items.Add(1);
            personasComboBox.Items.Add(2);
            personasComboBox.Items.Add(3);
            personasComboBox.Items.Add(4);
            personasComboBox.Items.Add(5);
            personasComboBox.Items.Add(6);
            personasComboBox.Items.Add(7);
            personasComboBox.Items.Add(8);
            personasComboBox.Items.Add(9);
            personasComboBox.Items.Add(10);
            personasComboBox.Items.Add(11);
            personasComboBox.Items.Add(12);
            personasComboBox.Items.Add(13);
            personasComboBox.Items.Add(14);
            personasComboBox.Items.Add(15);
            personasComboBox.Items.Add(16);
            personasComboBox.Items.Add(17);
            personasComboBox.Items.Add(18);
            personasComboBox.Items.Add(19);
            personasComboBox.Items.Add(20);

            reservasDataGridView.DataSource = reservas;


        }
        private void guardarReservaButton_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de agregar la reserva
            if (string.IsNullOrEmpty(nombreClienteTextBox.Text) ||
                string.IsNullOrEmpty(emailTextBox.Text) ||
                string.IsNullOrEmpty(telefonoTextBox.Text) ||
                destinoComboBox.SelectedItem == null ||
                personasComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear una nueva reserva
            Reserva nuevaReserva = new Reserva
            {
                NombreCliente = nombreClienteTextBox.Text,
                Email = emailTextBox.Text,
                Telefono = telefonoTextBox.Text,
                FechaLlegada = fechaLlegadaDateTimePicker.Value,
                Destino = destinoComboBox.SelectedItem.ToString(),
                NumeroPersonas = (int)personasComboBox.SelectedItem
            };

            // Agregar la reserva a la lista
            reservas.Add(nuevaReserva);

            // Limpiar los campos después de guardar
            nombreClienteTextBox.Clear();
            emailTextBox.Clear();
            telefonoTextBox.Clear();
            destinoComboBox.SelectedIndex = -1;
            personasComboBox.SelectedIndex = -1;
        }
    }
}
