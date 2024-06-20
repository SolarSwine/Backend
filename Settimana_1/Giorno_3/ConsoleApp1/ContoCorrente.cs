using System;

namespace ConsoleApplication
{
    internal class ContoCorrente
    {
        // Proprietà del conto
        public string NumeroConto { get; private set; }
        public string Intestatario { get; private set; }
        public decimal Saldo { get; private set; }
        private bool IsAperto { get; set; }

        // Costruttore per inizializzare il conto
        public ContoCorrente(string numeroConto, string intestatario)
        {
            NumeroConto = numeroConto;
            Intestatario = intestatario;
            Saldo = 0;
            IsAperto = false;
        }

        // Metodo per aprire il conto con un versamento minimo di 1000 euro
        public void ApriConto(decimal versamentoIniziale)
        {
            if (IsAperto)
            {
                Console.WriteLine("Il conto è già aperto.");
                return;
            }

            if (versamentoIniziale < 1000)
            {
                Console.WriteLine("L'importo minimo per aprire il conto è di 1000 euro.");
                return;
            }

            Saldo = versamentoIniziale;
            IsAperto = true;
            Console.WriteLine($"Conto aperto con successo. Saldo iniziale: {Saldo:C}");
        }

        // Metodo per fare un versamento
        public void Versa(decimal importo)
        {
            if (!IsAperto)
            {
                Console.WriteLine("Il conto non è ancora aperto.");
                return;
            }

            if (importo <= 0)
            {
                Console.WriteLine("L'importo del versamento deve essere positivo.");
                return;
            }

            Saldo += importo;
            Console.WriteLine($"Versamento effettuato. Nuovo saldo: {Saldo:C}");
        }

        // Metodo per fare un prelevamento
        public void Preleva(decimal importo)
        {
            if (!IsAperto)
            {
                Console.WriteLine("Il conto non è ancora aperto.");
                return;
            }

            if (importo <= 0)
            {
                Console.WriteLine("L'importo del prelevamento deve essere positivo.");
                return;
            }

            if (importo > Saldo)
            {
                Console.WriteLine("Saldo insufficiente per effettuare il prelevamento.");
                return;
            }

            Saldo -= importo;
            Console.WriteLine($"Prelevamento effettuato. Nuovo saldo: {Saldo:C}");
        }
    }
}