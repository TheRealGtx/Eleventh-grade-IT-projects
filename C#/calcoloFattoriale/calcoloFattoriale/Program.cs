/* Manzi Giuliano 3i, calcolo del fattoriale di un numero
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace calcoloFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            #region titolo
            Title = "Calcolo fattoriale";
            WriteLine("Programma di Manzi Giuliano 3i");
            #endregion

            #region dichiarazione
            string stInput;
            bool inputOk;
            int n;
            int fattoriale = 1;
            #endregion

            #region input
            //Lettura input
            do
            {
                Write("insersci il numero di cui calcolare il fattoriale: ");
                stInput = ReadLine();
                inputOk = int.TryParse(stInput, out n);
                if (!inputOk)
                {
                    WriteLine("Inserisci un input valido");
                }
                else if(n < 0)
                {
                    WriteLine("Inserisci un numero maggiore o uguale a 0");
                    inputOk = false;
                }
            } while (!inputOk);
            #endregion

            #region business logic
            int i = 1;
            //Nel caso in cui venga inserito 0
            if (n == 0)
            {
                WriteLine("Il fattoriale di 0 è 1");
            }
            else
            {
                do
                {
                    fattoriale = fattoriale * ++i;      //calcola il fattoriale eseguendo il calcolo al contrario (partendo da 1) incrementando il numero per cui moltiplicare
                } while (i < n);    //Il ciclo finisce quando vengono eseguite il numero necessario di moltiplicazioni per determinare il fatoriale di un numero
                WriteLine($"Il fattoriale di {n} è {fattoriale}");
            }
            #endregion
            Write("Premere un tasto per terminare il programma");
            ReadLine();

        }
    }
}
