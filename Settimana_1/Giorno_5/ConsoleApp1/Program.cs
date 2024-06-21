using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Richiede i dati del contribuente
            Console.Write("Inserisci il nome: ");
            string nome = Console.ReadLine();
            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci la data di nascita (gg/mm/aaaa): ");
            DateTime dataNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Inserisci il codice fiscale: ");
            string codiceFiscale = Console.ReadLine();
            Console.Write("Inserisci il sesso (M/F): ");
            string sesso = Console.ReadLine();
            Console.Write("Inserisci il comune di residenza: ");
            string comuneResidenza = Console.ReadLine();
            Console.Write("Inserisci il reddito annuale: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

            // Crea un'istanza del contribuente
            Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

            // Calcola l'imposta
            decimal imposta = contribuente.CalcolaImposta();

            // Stampa il risultato
            Console.WriteLine("==================================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
            Console.WriteLine($"nato il {contribuente.DataNascita.ToString("dd/MM/yyyy")} ({contribuente.Sesso}),");
            Console.WriteLine($"residente in {contribuente.ComuneResidenza},");
            Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale}");
            Console.WriteLine($"IMPOSTA DA VERSARE: {imposta}");
            Console.WriteLine("==================================================");
        }
    }
}
