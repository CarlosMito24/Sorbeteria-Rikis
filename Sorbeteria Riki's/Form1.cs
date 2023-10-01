﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorbeteria_Riki_s
{
    public partial class FormulariodeCompra : Form
    {
        public FormulariodeCompra()
        {
            InitializeComponent();
        }

        private void BotonEfectuarCompra_Click(object sender, EventArgs e)
        {
            double total;
            double cantidad = Convert.ToDouble(TextBoxCantidad.Text);
            total = cantidad * 20;
            LabelTotal.Text = "El Total de su orden es de: $ " + total;
        }

        private void BotónRegistroDeVentas_Click(object sender, EventArgs e)
        {
            FormularioRegistroDeVentas formularioRegistroDeVentas = new FormularioRegistroDeVentas();
            formularioRegistroDeVentas.Show();
            this.Hide();
        }

        private void FormulariodeCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
