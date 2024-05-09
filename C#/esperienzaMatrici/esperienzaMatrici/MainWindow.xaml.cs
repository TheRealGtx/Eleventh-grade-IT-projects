/*Manzi Giuliano 3i, 27/04/2022. Date delle matrici in input in dei file di teso, è possibile calcolare la somma e la
 * moltiplicazione degli elementi.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace esperienzaMatrici
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool esistenzaSecondaMatrice = false;
        int numeroMatrici = 1;
        int numeroColonnePrimaMatrice = 0;
        int numeroColonneSecondaMatrice = 0;
        int numeroRighePrimaMatrice = 0;
        int numeroRigheSecondaMatrice = 0;
        double[,] matriceUno;
        double[,] matriceDue;
        double[,] risultato;
        bool operazionePossibile = false;
        private void btnSomma_Click(object sender, RoutedEventArgs e)
        {
            bool sommaPossibile = false;
            sommaPossibile = pariDimensione(sommaPossibile);
            if (sommaPossibile)
            {
                somma();
                stampa();

                MessageBox.Show(
                    "Operazione avvenuta con successo",
                    "Progresso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(
                    "Le matrici sono di dimensione diversa, non è stato possibile effettuare la somma",
                    "Errore",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

        }

        private void inizializzaMatici()
        {
            StreamReader matrici = new StreamReader("../../../Matrici.txt");
            matriceUno = new double[numeroRighePrimaMatrice, numeroColonnePrimaMatrice];
            matriceDue = new double[numeroRigheSecondaMatrice, numeroColonneSecondaMatrice];

            string riga;
            int ir = -1, ic = 0, i = 0;
            riga = matrici.ReadLine();
            try
            {
                do
                {
                    if (riga != "")
                    {
                        string[] numeri = riga.Split(' ');
                        i = 0;
                        ic = 0;
                        ir++;
                        do
                        {
                            if (numeri[i] != "")
                            {
                                matriceUno[ir, ic] = double.Parse(numeri[i]);
                                ic++;
                            }
                            i++;
                        } while (i < numeri.Length);
                    }
                    riga = matrici.ReadLine();
                } while (riga != "");


                if (esistenzaSecondaMatrice && riga == "")
                {
                    ir = -1;
                    riga = matrici.ReadLine();
                    do
                    {
                        if (riga != "")
                        {
                            string[] numeri = riga.Split(' ');
                            i = 0;
                            ic = 0;
                            ir++;
                            do
                            {
                                if (numeri[i] != "")
                                {
                                    matriceDue[ir, ic] = double.Parse(numeri[i]);
                                    ic++;
                                }
                                i++;
                            } while (i < numeri.Length);
                        }
                        riga = matrici.ReadLine();
                    } while (riga != "" && riga != null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Errore nell'inizializzazione della matrice",
                    "Errore",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

            matrici.Close();

            
        }

        private bool pariDimensione(bool sommabili)
        {
            if (numeroRighePrimaMatrice == numeroRigheSecondaMatrice)
            {
                if (numeroColonnePrimaMatrice == numeroColonneSecondaMatrice)
                {
                    return sommabili = true;
                }
                else
                {
                    return sommabili = false;
                }
            }
            else
            {
                return sommabili = false;
            }
        }

        private void somma()
        {
            risultato = new double[matriceUno.GetLength(0), matriceUno.GetLength(1)];
            int ir = 0, ic = 0;
            for (ir = 0, ic = 0; ir < risultato.GetLength(0); ir++)
            {
                for (ic = 0; ic < risultato.GetLength(1); ic++)
                {
                    risultato[ir, ic] = matriceUno[ir, ic] + matriceDue[ir, ic];
                }
            }
        }

        private void stampa()
        {
            StreamWriter output = new StreamWriter("../../../Risultato.txt", false);

            for (int ir = 0, ic = 0; ir < risultato.GetLength(0); ir++)
            {
                for (ic = 0; ic < risultato.GetLength(1); ic++)
                {
                    output.Write(risultato[ir, ic] + " ");
                }
                output.WriteLine(" ");
            }
            output.Close();

            string riga = "";

            for (int ir = 0, ic = 0; ir < risultato.GetLength(0); ir++)
            {
                for (ic = 0; ic < risultato.GetLength(1); ic++)
                {
                    riga += risultato[ir, ic] + " ";
                }
                txtblRisultato.Text += riga + "\n";
                riga = "";
            }
        }

        private void trovaColonne()
        {
            //salva ogni elemento della prima riga in un array e ne conta il numero che è uguale al numero di colonne
            StreamReader matrici = new StreamReader("../../../Matrici.txt");

            string riga;
            int i = 0;

            riga = matrici.ReadLine();
            string[] numeri = riga.Split(' ');

            i = 0;

            do
            {
                if (numeri[i] != "")
                {
                    numeroColonnePrimaMatrice++;
                }
                i++;
            } while (i < numeri.Length);

            matrici.Close();


            if (esistenzaSecondaMatrice)
            {
                StreamReader matriciDue = new StreamReader("../../../Matrici.txt");
                do
                {
                    riga = matriciDue.ReadLine();
                } while (riga != "");

                riga = matriciDue.ReadLine();
                string[] numeriDue = riga.Split(' ');
                i = 0;


                do
                {
                    if (numeriDue[i] != "")
                    {
                        numeroColonneSecondaMatrice++;
                    }
                    i++;
                } while (i < numeriDue.Length);

                matriciDue.Close();
            }
            inizializzaMatici();
        }

        private void trovaRighe()
        {
            StreamReader matrici = new StreamReader("../../../Matrici.txt");

            string riga;
            int i = 0;
            int numeroRighe = 0;
            do
            {
                riga = matrici.ReadLine();
                numeroRighe++;
            } while (!matrici.EndOfStream);

            string[] righe = new string[numeroRighe];
            matrici.Close();
            StreamReader matriciDue = new StreamReader("../../../Matrici.txt");
            do
            {
                righe[i] = matriciDue.ReadLine();
                i++;
            } while (!matriciDue.EndOfStream);

            i = 0;
            numeroRighe = 0;
            do
            {
                if (righe[i] != "")
                {
                    numeroRighe++;
                    if (esistenzaSecondaMatrice == false)
                        righe[i] = "n";
                }
                if (righe[i] == "")
                {
                    numeroRighePrimaMatrice = numeroRighe;
                    esistenzaSecondaMatrice = true;

                }
                i++;
            } while (i < righe.Length);

            i = 0;
            if (esistenzaSecondaMatrice)
            {
                do
                {
                    if (righe[i] != "n" && righe[i] != "")
                    {
                        numeroRigheSecondaMatrice++;
                    }
                    i++;
                } while (i < righe.Length);
            }

            matrici.Close();
            trovaColonne();
        }

        private void moltiplicazione()
        {
            risultato = new double[matriceUno.GetLength(0), matriceUno.GetLength(1)];
            int ir = 0, ic = 0;
            for (ir = 0, ic = 0; ir < risultato.GetLength(0); ir++)
            {
                for (ic = 0; ic < risultato.GetLength(1); ic++)
                {
                    risultato[ir, ic] = matriceUno[ir, ic] * matriceDue[ic, ir];
                }
            }
        }

        private void btnMoltiplicazione_Click(object sender, RoutedEventArgs e)
        {
            bool moltiplicazionePossibile = false;
            moltiplicazionePossibile = pariDimensione(moltiplicazionePossibile);
            if (moltiplicazionePossibile)
            {
                moltiplicazione();
                stampa();

                MessageBox.Show(
                    "Operazione avvenuta con successo",
                    "Progresso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(
                    "Le matrici sono di dimensione diversa, non è stato possibile effettuare la moltiplicazione",
                    "Errore",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        double trovaDeterminante(double[] matriceUno)
        {
            int dimensione = Convert.ToInt32(Math.Sqrt((double)matriceUno.Length));
            double Determinante = 0;

            if (dimensione == 2)
            {
                Determinante = matriceUno[0] * matriceUno[3] - matriceUno[1] * matriceUno[2];
            }
            else
            {
                int riga = 0;
                int segno = 0; 

                for (int colonna = 0; colonna < dimensione; colonna++)
                {
                    if ((riga + colonna) % 2 == 0)
                        segno = 1;
                    else
                        segno = -1;
                    Determinante += segno * matriceUno[riga * dimensione + colonna] * trovaDeterminante(sottomarice(matriceUno, riga, colonna));
                }
            }

            return Determinante;
        }

        double[] sottomarice(double[] matriceUno, int riga, int colonna)
        {

            int dimensioneMatrice = Convert.ToInt32(Math.Sqrt((double)matriceUno.Length));
            double[] determinanteMomentaneo = new double[(dimensioneMatrice - 1) * (dimensioneMatrice - 1)];
            int i = 0;

            if (riga < 0 || riga > (dimensioneMatrice - 1))
            {
                throw new Exception("Errore");
            }

            if (colonna < 0 || colonna > (dimensioneMatrice - 1))
            {
                throw new Exception("Errore");
            }

            for (int j = 0; j < dimensioneMatrice * dimensioneMatrice; j++)
            {
                if (j < (riga * dimensioneMatrice) || (j >= (riga + 1) * dimensioneMatrice))
                {
                    if (j % dimensioneMatrice != colonna)
                    {
                        determinanteMomentaneo[i] = matriceUno[j];
                        i++;
                    }
                }
            }

            return determinanteMomentaneo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string riga = "";
            trovaRighe();
            int ir, ic;
            for (ir = 0, ic = 0; ir < matriceUno.GetLength(0); ir++)
            {
                for (ic = 0; ic < matriceUno.GetLength(1); ic++)
                {
                    riga += matriceUno[ir, ic] + " ";
                }
                txtblUno.Text += riga + "\n";
                riga = "";
            }

            riga = "";

            for (ir = 0, ic = 0; ir < matriceDue.GetLength(0); ir++)
            {
                for (ic = 0; ic < matriceDue.GetLength(1); ic++)
                {
                    riga += matriceDue[ir, ic] + " ";
                }
                txtblDue.Text += riga + "\n";
                riga = "";
            }
            btnSomma.IsEnabled = true;
            btnMoltiplicazione.IsEnabled = true;
        }
    }
}
