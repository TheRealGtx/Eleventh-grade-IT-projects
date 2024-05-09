/* programma di Giuliano Manzi 3i, consegnato il 13/10/2021.
 * Il programma è un timer digitale in ascii art.
 */
using System;
using System.Threading;

namespace timerConDigitSuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            #region titolo programma
            Console.Title = "Timer Digitale";
            Console.WriteLine("Programma di Manzi Giuliano 3i");
            #endregion

            #region dichiarazioni
            string stInput;
            bool inputOk;
            int tempoMinuti;
            int tempoSecondi;
            bool fineProgramma = false;
            int cifra;
            int riga = 0;
            int colonna = 0;
            #endregion

            #region input minuti
            do
            {
                //chiede i minuti
                Console.Write("Inserisci il tempo in minuti: ");
                stInput = Console.ReadLine();
                inputOk = int.TryParse(stInput, out tempoMinuti);

                //verifica che l'input vada bene
                if (!inputOk)
                {
                    Console.WriteLine("Inserire un input valido");
                }
                else if (tempoMinuti < 0 || tempoMinuti > 59)
                {
                    Console.WriteLine("Inserire un numero compreso tra 0 e 59");
                    inputOk = false;
                }
            } while (!inputOk);
            #endregion

            #region input secondi
            do
            {
                //chiede i secondi
                Console.Write("Inserisci il tempo in secondi: ");
                stInput = Console.ReadLine();
                inputOk = int.TryParse(stInput, out tempoSecondi);

                //verifica che l'input vada bene
                if (!inputOk)
                {
                    Console.WriteLine("Inserire un input valido");
                }
                else if (tempoMinuti == 0 && tempoSecondi <= 0 || tempoSecondi > 59)
                {
                    Console.WriteLine("Inserire un numero compreso tra 0 e 59");
                    inputOk = false;
                }
                else if (tempoMinuti != 0 && tempoSecondi < 0 || tempoSecondi > 59)
                {
                    Console.WriteLine("Inserire un numero compreso tra 0 e 59");
                    inputOk = false;
                }

            } while (!inputOk);
            #endregion

            #region generali
            //preparazione della console
            Console.Clear();
            Console.CursorVisible = false;
            #endregion

            #region business logic

            while (!fineProgramma)
            {
                //controlla la cifra da stampare in quel momento e chiama la funzione che la stampa
                cifra = tempoMinuti / 10;
                riga = 30;
                colonna = 10;
                numeri(cifra, riga, colonna);

                cifra = tempoMinuti % 10;
                riga = 42;
                colonna = 10;
                numeri(cifra, riga, colonna);

                //chiama la funzione per aggiungere i punti
                riga = 56;
                colonna = 14;
                punti(riga, colonna);

                cifra = tempoSecondi / 10;
                riga = 64;
                colonna = 10;
                numeri(cifra, riga, colonna);

                cifra = tempoSecondi % 10;
                riga = 76;
                colonna = 10;
                numeri(cifra, riga, colonna);

                //calcolo tempo
                if (tempoSecondi >= 0)
                {
                    tempoSecondi -= 1;
                }
                else if (tempoSecondi <= 0 && tempoMinuti > 0)
                {
                    tempoSecondi = 59;
                    tempoMinuti -= 1;
                }
                else if (tempoSecondi <= 0 && tempoMinuti == 0)
                {
                    fineProgramma = true;
                }
                Thread.Sleep(1000);
            }
            #endregion

            #region fine programma

            //beep e termine programma
            Console.Clear();
            Console.SetCursorPosition(54, 16);
            Console.WriteLine("Tempo scaduto!");
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
            Console.SetCursorPosition(33, 16);
            Console.WriteLine("(Premere invio per terminare il programma)");
            Console.ReadLine();
            #endregion

        }

        static void numeri(int cifra, int riga, int colonna)
        {
            switch (cifra)
            {
                //a seconda del caso stampa cifre diverse
                case 0:
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);


                    break;
                case 1:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");

                    break;
                case 2:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██        ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██        ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██        ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██        ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");

                    break;

                case 3:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");

                    break;
                case 4:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");

                    break;
                case 5:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");

                    break;
                case 6:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██          ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");

                    break;
                case 7:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");


                    break;
                case 8:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);

                    break;
                case 9:

                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██      ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("  ██████████  ");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");
                    colonna++;
                    Console.SetCursorPosition(riga, colonna);
                    Console.Write("          ██");

                    break;
            }
        }

        static void punti(int riga, int colonna)
        {
            //stampa i punti
            Console.SetCursorPosition(riga, colonna);
            Console.Write("   ██   ");
            colonna += 2;
            Console.SetCursorPosition(riga, colonna);
            Console.Write("   ██   ");
        }

        
    }


}
