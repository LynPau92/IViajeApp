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
    public partial class PaqueteInternacionalGrupo : Form
    {
        public PaqueteInternacionalGrupo()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R1_Click(object sender, EventArgs e)
        {
            Reservas_1 formularioreservas_1 = new Reservas_1();
            formularioreservas_1.Show();
            this.Close();
        }
    }
}
