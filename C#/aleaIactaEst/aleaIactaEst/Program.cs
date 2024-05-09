/* Manzi Giuliano 3i, iniziato il 20/10/2021, gioco dei dadi romano. Usare la console in full screen per una
 * migliore esperienza.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace aleaIactaEst
{
    class Program
    {
        static void Main(string[] args)
        {
            #region titolo programma
            Title = "Alea Iacta Est";
            WriteLine("Programma di Manzi Giuliano 3i");
            #endregion

            #region dichiarazione
            int sesterziUtente = 50;
            bool inputOk;
            int puntata;
            int numeroPuntato;
            int numeroDado1;
            int numeroDado2;
            int somma;
            const int MOLTIPLICATORE = 10;
            string risposta;
            bool continuaGioco = false;
            int colonna = 7;
            int riga = 5;
            int colonnaDiInizio = 7;
            #endregion

            WriteLine("Benvenuto al gioco dei dadi. Iniziamo!");
            WriteLine("Per inizare hai 50 sesterzi. Dovrai puntarne una parte su un numero che è il risultato della somma dei numeri di 2 dadi.Se indovini vincerai 10 volte la tua puntata, se non indovini perderai la tua puntata.");

            #region puntata
            do
            {
                do
                {
                    Write("Quanto vuoi puntare? puntata = ");
                    inputOk = int.TryParse(ReadLine(), out puntata);
                    if (!inputOk)
                    {
                        WriteLine("Inserisci un numero valido");
                        colonna += 2;
                    }
                    else if (puntata <= 0 || puntata > sesterziUtente)
                    {
                        WriteLine("Fai una puntata compresa tra 1 e il tuo numero di sesterzi!");
                        inputOk = false;
                        colonna += 2;
                    }
                } while (!inputOk);
                #endregion

                #region numero su cui puntare
                do
                {
                    Write("Su quale numero vuoi puntare? numero = ");
                    inputOk = int.TryParse(ReadLine(), out numeroPuntato);
                    if (!inputOk)
                    {
                        WriteLine("Inserisci un numero valido");
                        colonna += 2;
                    }
                    else if (numeroPuntato <= 0 || numeroPuntato > 12)
                    {
                        WriteLine("Punta su un numero compreso tra 1 e 12!");
                        inputOk = false;
                        colonna += 2;
                    }
                } while (!inputOk);
                #endregion

                #region business logic
                //estrazione numeri
                Random r = new Random();
                numeroDado1 = r.Next(1, 7);
                numeroDado2 = r.Next(1, 7);
                //confronto
                WriteLine("Dal primo dado è uscito " + numeroDado1 + " e dal secondo dado è uscito " + numeroDado2 + ".");
                dadi(numeroDado1, colonna, riga, numeroDado2, colonnaDiInizio);
                somma = numeroDado1 + numeroDado2;
                WriteLine("La somma dei numeri è " + somma + "...");
                //vincita o perdita
                if (somma == numeroPuntato)
                {
                    sesterziUtente += puntata * MOLTIPLICATORE;
                    WriteLine("Quindi hai indovinato! " + puntata * MOLTIPLICATORE + " sesterzi sono stati aggiunti al tuo conto");
                }
                else
                {
                    sesterziUtente -= puntata;
                    WriteLine("Quindi hai perso! " + puntata + " sesterzi sono stati tolti dal tuo conto");
                }
                //chiedere se vuole continuare
                inputOk = true;
                if (sesterziUtente > 0)
                {
                    do
                    {
                        WriteLine("Il tuo conto è di " + sesterziUtente + ". Vuoi continuare a giocare?");
                        Write("S = Sì, N = No. ");
                        risposta = ReadLine();
                        switch (risposta.ToLower())
                        {
                            case "s":
                                WriteLine("Fantastico! Continuiamo");
                                continuaGioco = true;
                                inputOk = true;
                                colonna += 15;
                                break;

                            case "n":
                                WriteLine("Peccato! Ci spiace che tu te ne vada. Ecco a te i tuoi " + sesterziUtente + " sesterzi!");
                                continuaGioco = false;
                                inputOk = true;
                                break;

                            default:
                                WriteLine("inserisci una risposta valida");
                                inputOk = false;
                                colonna += 3;
                                break;
                        }
                    } while (!inputOk);
                }
                else
                {
                    WriteLine("Hai terminato i sesterzi! Torna quando ne avrai altri.");
                    continuaGioco = false;
                }
            } while (continuaGioco);
            #endregion

            #region fine programma
            WriteLine("Premi invio per terminare il programma");
            ReadLine();
            #endregion
        }

        static void dadi(int numeroDado1, int colonna, int riga, int numeroDado2, int colonnaDiInizio)
        {
            riga = 5;
            colonnaDiInizio = colonna;
            switch (numeroDado1)
            {
                case 1:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███▓███");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 2:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("█▓█████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("████▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 3:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███▓███");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("████▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 4:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 5:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███▓███");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 6:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;
            }

            riga = 17;
            colonna = colonnaDiInizio;
            switch (numeroDado2)
            {
                case 1:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███▓███");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 2:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("█▓█████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("████▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 3:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███▓███");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("████▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 4:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 5:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███▓███");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;

                case 6:
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("██▓█▓██");
                    colonna++;
                    SetCursorPosition(riga, colonna);
                    WriteLine("███████");
                    break;
            }







        }
    }
}
