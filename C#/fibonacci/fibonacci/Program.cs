/*manzi Giuliano 3i, calcolo della sequenza di Fibonacci a partire da un numero della sequenza fino al numero
 * ennesimo della sequenza di fibonacci
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            #region titolo
            Title = "Sequenza di Fibonacci";
            WriteLine("Programma di Manzi Giuliano 3i");
            #endregion

            #region dichiarazione
            int inizio;
            int fine;
            bool inputOk;
            string stInput;
            int numeroSequenza;
           
            #endregion

            #region input inizio
            do
            {
                Write("Inserisci il numero di partenza: ");
                stInput = ReadLine();
                inputOk = int.TryParse(stInput, out inizio);
                if (!inputOk)
                {
                    WriteLine("Inserisci un numero valido");
                }
                else if (inizio < 1)    //la sequenza inizia dal primo valore
                {
                    WriteLine("Inserisci un numero maggiore di 0");
                    inputOk = false;
                }
            } while (!inputOk);
            #endregion

            #region input fine
            do
            {
                Write("Inserisci il numero di arrivo: ");
                stInput = ReadLine();
                inputOk = int.TryParse(stInput, out fine);
                if (!inputOk)
                {
                    WriteLine("Inserisci un numero valido");
                }  
                else if (fine <= inizio)    //la fine non può essere minore dell'inizio
                {
                    WriteLine("Inserisci un numero maggiore di " + inizio);
                    inputOk = false;
                }
            } while (!inputOk);
            #endregion

            #region business logic
            int primoNumeroPrecedente = 1;
            int secondoNumeroPrecedente = 0;
            int i = 0; //3

            //serie dai valori 1 al valore 3 che ha un incremento differente
            if (inizio == 1 && fine == 2)
            {
                Write("sequenza = 1, 1,");
            }
            else if (inizio == 2 && fine == 3)
            {
                Write("sequenza = 1, 2,");
            }
            //calcolo sequenza di fibonacci
            else
            {
                do
                {
                    numeroSequenza = primoNumeroPrecedente + secondoNumeroPrecedente;
                    primoNumeroPrecedente = secondoNumeroPrecedente;
                    secondoNumeroPrecedente = numeroSequenza;
                    i++;
                } while (i < inizio - 1);
                //una volta arrivato al nostro inizio esce dal ciclo
                Write("Sequenza = ");

                do
                {
                    numeroSequenza = primoNumeroPrecedente + secondoNumeroPrecedente;
                    primoNumeroPrecedente = secondoNumeroPrecedente;
                    secondoNumeroPrecedente = numeroSequenza;
                    Write(numeroSequenza + ", ");
                    i++;
                } while (i < fine);
                //una volta arrivato al numero finale esce dal ciclo
            }
            #endregion

            WriteLine("premi invio per terminare il programma");
            ReadLine();


        }
    }
}
