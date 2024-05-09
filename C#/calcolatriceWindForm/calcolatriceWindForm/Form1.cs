/* Manzi Giuliano, 3i, calcolatrice bit in Windows Forms
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace calcolatriceWindForm
{
    public partial class Form1 : Form
    {
        int numeriInseriti = 0, operatoriUsati = 0;
        string operando, primoNumero, secondoNumero, risultatoBinario;
        bool creditiUsed = false;
        public Form1()
        {
            InitializeComponent();
            comparsaNumeri.ReadOnly = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numeriInseriti < 8)
            {
                comparsaNumeri.Text += "1";
                numeriInseriti++;
            }
            crediti.Enabled = false;
        }

        private void comparsaNumeri_Click(object sender, EventArgs e)
        {

        }

        private void bottoneZero_Click(object sender, EventArgs e)
        {
            if (numeriInseriti < 8)
            {
                comparsaNumeri.Text += "0";
                numeriInseriti++;
            }
            crediti.Enabled = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cancellaUnElemento_Click(object sender, EventArgs e)
        {
            if (numeriInseriti >= 1)
            {
                comparsaNumeri.Text = comparsaNumeri.Text.Substring(0, comparsaNumeri.Text.Length - 1);
                numeriInseriti -= 1;
            }
        }

        private void cancellaTutto_Click(object sender, EventArgs e)
        {
            if (creditiUsed)
            {
                creditiUsed = false;
                Font font = new Font("Microsoft Sans Serif", 36.0f);
                comparsaNumeri.Font = font;
                comparsaNumeri.Text = "";

                bottoneUno.Enabled = true;
                bottoneZero.Enabled = true;
                or.Enabled = true;
                and.Enabled = true;
                xor.Enabled = true;
                not.Enabled = true;
                addZeroFine.Enabled = true;
                addZeroinizio.Enabled = true;
                cancellaUnElemento.Enabled = true;
            }
            comparsaNumeri.Text = "";
            numeriInseriti = 0;
            operatoriUsati = 0;
            operatore.Text = "";
            if (operatoriUsati == 1)
            {
                Risultato.Enabled = true;
                crediti.Enabled = false;
            }
            else
            {
                Risultato.Enabled = false;
                crediti.Enabled = true;
            }
        }

        private void or_Click(object sender, EventArgs e)
        {
            if (operatoriUsati == 0)
            {
                operando = "or";
                operatoriUsati = 1;
                numeriInseriti = 0;
                primoNumero = comparsaNumeri.Text;
                comparsaNumeri.Text = "";
                operatore.Text = "OR";
                Risultato.Enabled = true;
                crediti.Enabled = false;
            }
        }

        private void and_Click(object sender, EventArgs e)
        {
            if (operatoriUsati == 0)
            {
                operando = "and";
                primoNumero = comparsaNumeri.Text;
                comparsaNumeri.Text = "";
                operatoriUsati = 1;
                numeriInseriti = 0;
                operatore.Text = "AND";
                Risultato.Enabled = true;
                crediti.Enabled = false;
            }
        }

        private void xor_Click(object sender, EventArgs e)
        {
            if (operatoriUsati == 0)
            {
                operando = "xor";
                primoNumero = comparsaNumeri.Text;
                comparsaNumeri.Text = "";
                operatoriUsati = 1;
                numeriInseriti = 0;
                operatore.Text = "XOR";
                Risultato.Enabled = true;
                crediti.Enabled = false;
            }
        }


        private void not_Click(object sender, EventArgs e)
        {
            if (operatoriUsati == 0)
            {
                operatore.Text = "NOT";
                int i = 0;
                primoNumero = comparsaNumeri.Text;
                operatoriUsati = 1;
                risultatoBinario = "";
                comparsaNumeri.Text = "";
                do
                {
                    if (primoNumero.Substring(i, 1) == "0")
                    {
                        risultatoBinario += "1";
                    }
                    else if (primoNumero.Substring(i, 1) == "1")
                    {
                        risultatoBinario += "0";
                    }
                    i++;
                } while (i < numeriInseriti);
                comparsaNumeri.Text = risultatoBinario;

                crediti.Enabled = false;
            }
        }

        private void crediti_Click(object sender, EventArgs e)
        {
            creditiUsed = true;
            Font font = new Font("Microsoft Sans Serif", 12.0f);
            comparsaNumeri.Font = font;
            comparsaNumeri.Text = "Programma di Manzi Giuliano 3i";

            bottoneUno.Enabled = false;
            bottoneZero.Enabled = false;
            or.Enabled = false;
            and.Enabled = false;
            xor.Enabled = false;
            not.Enabled = false;
            addZeroFine.Enabled = false;
            addZeroinizio.Enabled = false;
            cancellaUnElemento.Enabled = false;
        }

        private void addZeroinizio_Click(object sender, EventArgs e)
        {
            if (numeriInseriti < 8)
            {
                comparsaNumeri.Text += "0";
                numeriInseriti++;
            }
            crediti.Enabled = false;
        }

        private void addZeroFine_Click(object sender, EventArgs e)
        {
            if (numeriInseriti < 8)
            {
                comparsaNumeri.Text = "0" + comparsaNumeri.Text;
                numeriInseriti++;
            }
            crediti.Enabled = false;
        }

        private void Risultato_Click(object sender, EventArgs e)
        {
            

            secondoNumero = comparsaNumeri.Text;
            comparsaNumeri.Text = "";
            operatore.Text = "";

            int primoNumeroIntero = 0;
            int secondoNumeroIntero = 0;
            int risultato = 0;
            int unoOZero;
            int exNumeriInseriti = numeriInseriti;
            string numeroUnoBinario = "";
            string numeroDueBinario = "";
            string risultatoBinario = "";
            int i = 0;
            int resto = 0;

            //inverti numeri
            do
            {
                numeroUnoBinario += primoNumero.Substring(numeriInseriti -1, 1);
                numeroDueBinario += secondoNumero.Substring(numeriInseriti -1, 1);
                numeriInseriti--;
            } while (numeriInseriti > 0);

            numeriInseriti = exNumeriInseriti;
            
            //conversione da base 2 a base 10
            do
            {
                unoOZero = int.Parse(numeroUnoBinario.Substring(numeriInseriti - 1, 1));
                primoNumeroIntero += (int)Math.Pow(2, numeriInseriti - 1) * unoOZero;
                numeriInseriti -= 1;
            } while (numeriInseriti > 0);

            numeriInseriti = exNumeriInseriti;

            do
            {
                unoOZero = int.Parse(numeroDueBinario.Substring(numeriInseriti - 1, 1));
                secondoNumeroIntero += (int)Math.Pow(2, numeriInseriti - 1) * unoOZero;
                numeriInseriti -= 1;
            } while (numeriInseriti > 0);
           
            switch (operando)
            {
                case "or":
                     risultato = primoNumeroIntero | secondoNumeroIntero;
                    risultatoBinario = conversione(i, risultato, exNumeriInseriti); //chiama il metodo per la conversione da base 2 a base 10
                    comparsaNumeri.Text += risultatoBinario;
                    numeriInseriti = comparsaNumeri.Text.Length;
                    break;
                case "and":
                    risultato = primoNumeroIntero & secondoNumeroIntero;
                    risultatoBinario = conversione(i, risultato, exNumeriInseriti);
                    comparsaNumeri.Text += risultatoBinario;
                    numeriInseriti = comparsaNumeri.Text.Length;
                    break;
                case "xor":
                    risultato = primoNumeroIntero^secondoNumeroIntero;
                    risultatoBinario = conversione(i, risultato, exNumeriInseriti);
                    comparsaNumeri.Text += risultatoBinario;
                    break;
            }
            numeriInseriti = exNumeriInseriti;
            i = 0;
            

            //reset variabili
            operatoriUsati = 0;
            numeriInseriti = 0;

            Risultato.Enabled = false;
            
        }

        private string conversione(int i, int risultato, int exNumeriInseriti)
        {
            numeriInseriti = exNumeriInseriti;
            string resto = "";
            i = 0;

            //conversione da base 2 a base 10
            //distinzione tra pari e dispari o non viene aggiunto uno zero alla fine nei pari
            if (risultato % 2 == 0)
            {
                do
                {
                    resto += risultato % 2;
                    risultato /= 2;
                } while (risultato > 0);
                resto += risultato % 2;
            }
            else
            {
                do
                {
                    resto += risultato % 2;
                    risultato /= 2;
                } while (risultato > 0);
            }

            numeriInseriti = resto.Length;

            //aggiunta zeri
            if (resto.Length < 8)
            {
                do
                {
                    resto = "0" + resto;
                    i++;
                } while (i < 8 - numeriInseriti);
            }

            //Inverti numeri post conversione
            do
            {
                risultatoBinario += resto.Substring(numeriInseriti - 1, 1);
                numeriInseriti--;
            } while (numeriInseriti > 0);
            risultatoBinario = resto;
            
            return risultatoBinario;
        }
    }
}
