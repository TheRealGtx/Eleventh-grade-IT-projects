/* Manzi Giuliano 3i, il programma converte un numero esadecimale di massimo 2 cifre in un numero binario e in uno decimale
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace conversioneNumeriEsadecimali
{
    class Program
    {
        static void Main(string[] args)
        {
            #region titolo
            Title = "Conversione numeri esadecimnali";
            WriteLine("Programma di Manzi Giuliano 3i");
            #endregion

            #region dichiarazioni
            bool inOk = true;
            string numeroEsadecimale;   //I numeri esadecimali presentano anche caratteri quindi la variabile di input non può essere intera
            int lunghezzaNumero;
            int risultato;
            string carattere;
            int numero;
            int i = 0;
            int numeroBaseDieci;
            int numeroBaseDieciFinale;
            int moltiplicazione = 0;
            int moltiplicazioneDue = 0;
            string numeroBaseDue = "0"; //richiede per forza un inizializzazione ma questo 0 non verrà stampato alla fine
            #endregion

            #region input
            do
            {
                Write("Insersci un numero esadecimale di massimo 2 cifre: ");
                numeroEsadecimale = ReadLine();
                numeroEsadecimale = numeroEsadecimale.ToLower();
                lunghezzaNumero = numeroEsadecimale.Length;     //conta i caratteri della stringa e li salva nella variabile lunghezzaNumero
                if (lunghezzaNumero != 2 || numeroEsadecimale == "")
                {
                    WriteLine("Inserisci un numero di 2 cifre o aggiungi uno zero all'inizio");
                    inOk = false;
                }
                else
                {
                    do
                    {
                        carattere = numeroEsadecimale.Remove(i, 1);
                            risultato = (int)Convert.ToChar(carattere);
                        if (risultato >= 48 && risultato <= 57 || risultato >= 65 && risultato <= 70 || risultato >= 97 && risultato <= 102)
                        {
                            inOk = true;
                        }
                        else
                        {
                            inOk = false;
                        }
                        i++;
                    } while (i < 2 && inOk == true);
                    if (!inOk)
                    {
                        WriteLine("è stato inserito un carattere errato");
                    }
                }
            } while (!inOk);
            #endregion

            #region da base 16 a base 10
            //controlla se ci sono lettere nella prima cifra
            i = 0;
            int j = 1;
            do
            {
                carattere = numeroEsadecimale.Substring(j, 1);
                switch (carattere)
                {
                    case "a":
                        numero = 10;
                        break;
                    case "b":
                        numero = 11;
                        break;
                    case "c":
                        numero = 12;
                        break;
                    case "d":
                        numero = 13;
                        break;
                    case "e":
                        numero = 4;
                        break;
                    case "f":
                        numero = 15;
                        break;
                    default:
                        numero = int.Parse(carattere);
                        break;
                }
                i++;
                j--;
                if (i == 1)
                {
                    moltiplicazione = 1 * numero;
                } else
                {
                    moltiplicazioneDue = 16 * numero;
                }
            } while (i < 2);

            numeroBaseDieciFinale = moltiplicazione + moltiplicazioneDue;
            numeroBaseDieci = numeroBaseDieciFinale;
            #endregion
            i = 0;
            #region da base 10 a base 2
            do
            {
                if (numeroBaseDieci % 2 == 0)   //se il resto è 0 concatena "0" alla stringa del numero binario, poi divide il numero per 2
                {
                    numeroBaseDue += "0";
                    numeroBaseDieci /= 2;
                }
                else    //se il resto è 1 concatena "1" alla stringa del numero binario, poi divide il numero per 2                
                {
                    numeroBaseDue += "1";
                    numeroBaseDieci /= 2;
                }
                i++;
            } while (numeroBaseDieci > 0);  //Il ciclo viene eseguito finchè il numero decimale è maggiore di 0
            j = 0;
            Write("Il numero in base 2 è: ");
            do
            {
                Write(numeroBaseDue[i - j]);    //inverte la posizione dei numeri dato che nel ciclo precedente vengono salvati al contrario
                j++;
            } while (j < i);
            #endregion

            WriteLine(" e il numero in base 10 è: " + numeroBaseDieciFinale);
            WriteLine("Premere invio per terminare il programma");
            ReadLine();
        }
    }
}
