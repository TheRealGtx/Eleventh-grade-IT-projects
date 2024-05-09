//Calcolo aree di due triangoli
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areaTriangoli
{
    public partial class Form1 : Form
    {
        double base1, base2, altezza1, altezza2, area1, area2 = 0;

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPrimaBase.Text = "";
            textBoxPrimaAltezza.Text = "";
            textBoxSecondaBase.Text = "";
            textBoxSecondaAltezza.Text = "";
            outout2.Text = "";
            Output1.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                base1 = double.Parse(textBoxPrimaBase.Text);
                altezza1 = double.Parse(textBoxPrimaAltezza.Text);
                base2 = double.Parse(textBoxSecondaBase.Text);
                altezza2 = double.Parse(textBoxSecondaAltezza.Text);
            }
            catch
            {
                MessageBox.Show(
                    "Uno degli input inseriti non è valido",
                    "ERRORE",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            area1 = primaArea(base1, altezza1, area1);
            area2 = secondaArea(base2, altezza2, area2);

            Output1.Text = "Area del primo triangolo: " + area1;
            outout2.Text = "Area del secondo triangolo: " + area2;
        }

        double primaArea(double base1, double altezza1, double area1)
        {
            area1 = (base1 * altezza1) / 2;
            return area1;
        }

        double secondaArea(double base2, double altezza2, double area2)
        {
            area2 = (base2 * altezza2) / 2;
            return area2;
        }
    }
}
