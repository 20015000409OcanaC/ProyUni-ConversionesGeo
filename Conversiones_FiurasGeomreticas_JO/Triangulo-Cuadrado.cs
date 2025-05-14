using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversiones_FiurasGeomreticas_JO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseFigura, altura, resultado = 0;
            if (rbTriangulo.Checked)
            {
                baseFigura = Convert.ToDouble(txtAltura.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                resultado = (baseFigura * altura) / 2;
            }
            else if (rbCuadrado.Checked)
            {
                baseFigura = Convert.ToDouble(txtAltura.Text);
                resultado = baseFigura * baseFigura;
            }
            txtResultado.Text = resultado.ToString();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadrado v1 = new cuadrado();
            v1.Visible = true;
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pentagono_Hexagono v3 = new Pentagono_Hexagono();
            v3.Visible = true;
        }

        private void heptagonoOctagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Heptagono_Octagono v3 = new Heptagono_Octagono();
            v3.Visible = true;
        }

        private void ovaloPoligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ovalo_Poligono v4 = new Ovalo_Poligono();
            v4.Visible = true;
        }
    }
}

