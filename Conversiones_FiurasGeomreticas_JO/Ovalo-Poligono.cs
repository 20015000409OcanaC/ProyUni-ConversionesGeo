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
    public partial class Ovalo_Poligono : Form
    {
        public Ovalo_Poligono()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio1, radio2, longitud, perimetro, resultado = 0;
            if (rbOvalo.Checked)
            {
                radio1 = Convert.ToDouble(txtRadio1.Text);
                radio2 = Convert.ToDouble(txtRadio2.Text);
                resultado = radio1 * radio2 * Math.PI;
            }


            else if (rbPoligono.Checked)
            {
                longitud = Convert.ToDouble(txtLongitud.Text);
                perimetro = Convert.ToDouble(txtPerimetro.Text);
                resultado = (longitud * perimetro) / 2;
            }
            txtResultado.Text = resultado.ToString();
        }

        private void trianguloCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
            v1.Visible = true;
        }

        private void circuloRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadrado v2 = new cuadrado();
            v2.Visible = true;
        }

        private void pentagonoHexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pentagono_Hexagono v3 = new Pentagono_Hexagono();
            v3.Visible = true;
        }

        private void heptagonoOctagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Heptagono_Octagono v4 = new Heptagono_Octagono();
            v4.Visible = true;
        }
    }
}
