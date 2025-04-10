﻿using System;
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
    public partial class Reservas_1 : Form
    {
        public Reservas_1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string pais = txtpais.Text;
            string telefono = txttelefono.Text;
            string correo = txtcorreo.Text;
            string tipoViaje = cmbtipoViaje.Text;
            string destino = cmbDestino.Text;
            int cantidadPersonas;
            bool isValid = int.TryParse(txtcantidadPersonas.Text, out cantidadPersonas);

            if (nombre == "" || pais == "" || telefono == "" || correo == "" || cantidadPersonas == 0
                || tipoViaje == "Seleccione el tipo de viaje" || destino == "Seleccione su destino")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                ReservaCliente nuevoCliente = new ReservaCliente(nombre, pais, telefono, correo, cantidadPersonas, tipoViaje, destino);
                int fila = nuevoCliente.AgregarCliente();

                if (fila == 1) 
                {
                    MessageBox.Show("La reserva se agregó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnombre.Text = "";
                    txtpais.Text = "";
                    txttelefono.Text = "";
                    txtcorreo.Text = "";
                    cmbtipoViaje.Text = "Seleccione el tipo de viaje";
                    cmbDestino.Text = "Seleccione su destino";
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
