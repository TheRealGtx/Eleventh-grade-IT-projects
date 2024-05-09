//Il programma risolve il rompicapo delle torri di Hanoi.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torreDiHanoi
{
    public partial class Form1 : Form
    {
        int paloOrigine = 1;
        int paloDestinazione = 3;
        int paloIntermedio = 2;
        int numeroAnelli;
                
        public Form1()
        {
            InitializeComponent();
            
        }

        private void numeroAnelli_Click(object sender, EventArgs e)
        {

        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            
            bool inOk;

            inOk = int.TryParse(textBoxInput.Text, out numeroAnelli) && numeroAnelli >= 3 && numeroAnelli <= 64;

            if (!inOk)
            {
                MessageBox.Show(
                    "Inserisci un numero maggiore di 3 e minore di 64",
                    "ERRORE",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxInput.Text = "";
            }
            else 
            { 
                businessLogic(numeroAnelli, paloOrigine, paloDestinazione, paloIntermedio);
            } 
                

            
        }

        private void businessLogic(int numeroAnelli, int paloOrigine, int paloDestinazione, int paloIntermedio)
        {
            if (numeroAnelli == 1)
            {
                listBoxOutput.Items.Add("Muovi il disco dal palo " + paloOrigine + " al palo " + paloDestinazione);
            }
            else
            {
                businessLogic(numeroAnelli - 1, paloOrigine, paloIntermedio, paloDestinazione);
                businessLogic(1, paloOrigine, paloDestinazione, paloIntermedio);
                businessLogic(numeroAnelli - 1, paloIntermedio, paloDestinazione, paloOrigine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
        }
    }
}
