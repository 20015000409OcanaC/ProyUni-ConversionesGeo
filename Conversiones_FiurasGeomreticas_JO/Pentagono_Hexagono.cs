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
    public partial class Pentagono_Hexagono : Form
    {
        public Pentagono_Hexagono()
        {
            InitializeComponent();
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double longitud, perimetro, apotema, resultado = 0;
            double numero = 3;
            double raiz = Math.Sqrt(numero);
            if (rbPentagono.Checked)
            {
                perimetro = Convert.ToDouble(txtPerimetro.Text);
                apotema = Convert.ToDouble(txtApotema.Text);
                resultado = perimetro * apotema;
            }


            else if (rbExagono.Checked)
            {
                longitud = Convert.ToDouble(txtLongitud.Text);
                resultado = (3 * raiz * longitud)/2;
            }
            txtResultado.Text = resultado.ToString();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void trianguloCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
        }

        private void ciculoRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadrado v2 = new cuadrado();
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
