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
    public partial class Heptagono_Octagono : Form
    {
        public Heptagono_Octagono()
        {
            InitializeComponent();
        }

        private void circuloRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
            v1.Visible = true;
        }

        private void circuloRectanguloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cuadrado v2 = new cuadrado();
            v2.Visible = true;
        }

        private void pentagonoHexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pentagono_Hexagono v3 = new Pentagono_Hexagono();
            v3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double perimetro, apotema, longitud, resultado = 0;
            double numero = 2;
            double raiz = Math.Sqrt(numero);
            if (rbHeptagono.Checked)
            {
                perimetro = Convert.ToDouble(txtPerimetro.Text);
                apotema = Convert.ToDouble(txtApotema.Text);
                resultado = (perimetro * apotema)/2;
            }


            else if (rboctogono.Checked)
            {
                longitud = Convert.ToDouble(txtLongitud.Text);
                resultado = (2 * (longitud * longitud)) * (1 + raiz);
            }
            txtResultado.Text = resultado.ToString();
        }

        private void ovaloPoligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ovalo_Poligono v4 = new Ovalo_Poligono();
            v4.Visible = true;
        }
    }
    }

