using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PROYECTO_FINAL
{
    class ReservaCliente
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int CantidadPersonas { get; set; } 
        public string TipoViaje { get; set; }
        public string Destino { get; set; }

        private SqlConnection cn;

        public ReservaCliente(string nombre, string pais, string telefono, string correo, int cantidadPersonas, string tipoViaje, string destino)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.Telefono = telefono;
            this.Correo = correo;
            this.CantidadPersonas = cantidadPersonas;
            this.TipoViaje = tipoViaje;
            this.Destino = destino;

            cn = new SqlConnection("Data Source=DESKTOP-URDRB0N\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False");
        }

        public int AgregarCliente()
        {
            int filasAfectadas = 0;

            try
            {
                cn.Open();

                string consultaSql = "INSERT INTO Cliente (Nombre, Pais, Telefono, Correo, CantidadPersonas, TipoViaje, Destino) VALUES (@Nombre, @Pais, @Telefono, @Correo, @CantidadPersonas, @TipoViaje, @Destino)";

                using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                {
                    consulta.Parameters.AddWithValue("@Nombre", this.Nombre);
                    consulta.Parameters.AddWithValue("@Pais", this.Pais);
                    consulta.Parameters.AddWithValue("@Telefono", this.Telefono);
                    consulta.Parameters.AddWithValue("@Correo", this.Correo);
                    consulta.Parameters.AddWithValue("@CantidadPersonas", this.CantidadPersonas);  
                    consulta.Parameters.AddWithValue("@TipoViaje", this.TipoViaje);
                    consulta.Parameters.AddWithValue("@Destino", this.Destino);

                    filasAfectadas = consulta.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return filasAfectadas;
        }
    }
}
