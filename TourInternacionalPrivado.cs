using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PROYECTO_FINAL
{
    public partial class TourInternacionalPrivado: Form
    {
        public TourInternacionalPrivado()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void R2_Click(object sender, EventArgs e)
        {
            Reservas_1 formularioreservas_1 = new Reservas_1();
            formularioreservas_1.Show();
            this.Close();
        }
    }
}
