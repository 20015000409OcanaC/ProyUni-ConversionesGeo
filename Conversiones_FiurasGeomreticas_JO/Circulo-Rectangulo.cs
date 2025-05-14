using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversiones_FiurasGeomreticas_JO
{
    public partial class cuadrado : Form
    {
        public cuadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio, baseFigura, Altura, resultado= 0;
            if (rbCirculo.Checked)
            {
                radio = Convert.ToDouble(txtRadio.Text);
                resultado = Math.PI * radio * radio;
            }


            else if (rbRectangulo.Checked)
            {
                baseFigura = Convert.ToDouble(txtBase.Text);
                Altura = Convert.ToDouble(txtAltura.Text);
                resultado = baseFigura * Altura;
            }
            txtResultado.Text = resultado.ToString();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void trianguloCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
            v1.Visible = true;
        }

        private void circuloRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pentagonoHexagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pentagono_Hexagono v2 = new Pentagono_Hexagono();
            v2.Visible = true;
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
