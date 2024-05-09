/*Manzi Giuliano 3i, conversione numeri da base 10 a base 2 e 16
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace conversioneNumeri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region titolo programma
            Title = "Conversione numeri";
            WriteLine("Programma di Manzi Giuliano 3i");
            #endregion

            #region dichiarazione
            int numeroBaseDieci;
            bool inputOk;
            string numeroBaseDue = "0"; //richiede per forza un inizializzazione ma questo 0 non verrà stampato alla fine
            int i = 0;
            int resto;
            int numeroBaseDieciOriginale;
            string numeroBaseSedici = "0"; //richiede per forza un inizializzazione ma questo 0 non verrà stampato alla fine
            #endregion

            #region input
            do
            {
                Write("Inserisci il numero in base 10 da convertire (compreso tra 0 e 255): ");
                inputOk = int.TryParse(ReadLine(), out numeroBaseDieci);
                if (!inputOk)
                {
                    WriteLine("Insersci un inout valido");
                }
                else if (numeroBaseDieci < 0 || numeroBaseDieci > 256)  //controlla che l'input sia valido e che il numero sia compreso tra 0 e 255
                {
                    WriteLine("Inserisci un numero compreso tra 0 e 255");
                    inputOk = false;
                }
            } while (!inputOk);
            numeroBaseDieciOriginale = numeroBaseDieci;     //salva in un ulteriore variabile il numero decimale che ci servirà più avanti
            #endregion

            #region business logic base 2
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
            int j = 0;
            Write("Il numero in base 2 è: ");
            do
            {
                Write(numeroBaseDue[i - j]);    //inverte la posizione dei numeri dato che nel ciclo precedente vengono salvati al contrario
                j++;
            } while (j < i);
            #endregion

            numeroBaseDieci = numeroBaseDieciOriginale;     //riporta il numero decimale all'origine dato che dopo la prima conversione è uguale a 0
            i = 0;
            j = 0;
            #region business logic base 16
            do
            {
                resto = numeroBaseDieci % 16;   //calcola il resto della divisione poi divide il numero decimale per 16
                numeroBaseDieci /= 16;
                switch (resto)  //confronta il resto in modo da dare ai valori maggiori di 10 la corrsipondente lettera
                {
                    case 10:
                        numeroBaseSedici += "A";
                        break;
                    case 11:
                        numeroBaseSedici += "B";
                        break;
                    case 12:
                        numeroBaseSedici += "C";
                        break;
                    case 13:
                        numeroBaseSedici += "D";
                        break;
                    case 14:
                        numeroBaseSedici += "E";
                        break;
                    case 15:
                        numeroBaseSedici += "F";
                        break;
                    default:    //nel caso il numero sia minore di 10 concatena al numero esadecimale semplicemente la cifra del resto
                        resto.ToString();   //converte il numero in string in modo da poter essere concatenato
                        numeroBaseSedici += resto;
                        break;
                }
                i++;
            } while (numeroBaseDieci > 0);  //il ciclo viene eseguito fino a che il numero decimale è maggiore di 10

            Write(" e il numero in base 16 è: ");
            do
            {
                Write(numeroBaseSedici[i - j]);     //inverte la posizione dei numeri dato che nel ciclo precedente vengono salvati al contrario
                j++;
            } while (j < i);
            #endregion

            ReadLine();

        }
    }
}
