
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creazione dell'istanza di ContoCorrente
            ContoCorrente conto = new ContoCorrente("1234567890", "Mario Rossi");

            // Tentativo di apertura del conto con meno di 1000 euro
            conto.ApriConto(500); // Output: L'importo minimo per aprire il conto è di 1000 euro.

            // Apertura del conto con 1000 euro
            conto.ApriConto(1000); // Output: Conto aperto con successo. Saldo iniziale: €1000,00

            // Tentativo di aprire nuovamente il conto
            conto.ApriConto(2000); // Output: Il conto è già aperto.

            // Effettuare un versamento
            conto.Versa(500); // Output: Versamento effettuato. Nuovo saldo: €1500,00

            // Effettuare un prelevamento
            conto.Preleva(200); // Output: Prelevamento effettuato. Nuovo saldo: €1300,00

            // Tentativo di prelevamento con importo maggiore del saldo disponibile
            conto.Preleva(1500); // Output: Saldo insufficiente per effettuare il prelevamento.

            // Richiede il numero di nomi da inserire
            Console.Write("Quanti nomi vuoi inserire? ");
            int numeroNomi = int.Parse(Console.ReadLine());

            // Inizializza l'array per i nomi
            string[] nomi = new string[numeroNomi];

            // Carica l'array con i nomi inseriti dall'utente
            for (int i = 0; i < numeroNomi; i++)
            {
                Console.Write($"Inserisci il nome {i + 1}: ");
                nomi[i] = Console.ReadLine();
            }

            // Richiede il nome da cercare
            Console.Write("Inserisci il nome da cercare: ");
            string nomeDaCercare = Console.ReadLine();

            // Cerca il nome nell'array
            bool nomeTrovato = false;
            foreach (string nome in nomi)
            {
                if (nome.Equals(nomeDaCercare, StringComparison.OrdinalIgnoreCase))
                {
                    nomeTrovato = true;
                    break;
                }
            }

            // Stampa se il nome è stato trovato o meno
            if (nomeTrovato)
            {
                Console.WriteLine($"Il nome '{nomeDaCercare}' è presente nell'array.");
            }
            else
            {
                Console.WriteLine($"Il nome '{nomeDaCercare}' non è presente nell'array.");
            }

            // Richiede la dimensione dell'array
            Console.Write("Inserisci la dimensione dell'array: ");
            int dimensione = int.Parse(Console.ReadLine());

            // Inizializza l'array per i numeri interi
            int[] numeri = new int[dimensione];

            // Carica l'array con i numeri inseriti dall'utente
            for (int i = 0; i < dimensione; i++)
            {
                Console.Write($"Inserisci il numero {i + 1}: ");
                numeri[i] = int.Parse(Console.ReadLine());
            }

            // Calcola la somma di tutti i numeri
            int somma = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }

            // Calcola la media aritmetica di tutti i numeri
            double media = (double)somma / numeri.Length;

            // Stampa la somma e la media
            Console.WriteLine($"La somma di tutti i numeri è: {somma}");
            Console.WriteLine($"La media aritmetica di tutti i numeri è: {media}");

            // Attesa per vedere il risultato in console
            Console.ReadLine();
        }
    }
}