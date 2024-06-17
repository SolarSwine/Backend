namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione delle istanze di Atleta
            Atleta atleta = new Atleta
            {
                Nome = "Salti",
                Cognome = "Mbanco",
                Sport = "lenze"
            };
            atleta.Descriviti();

            // Creazione delle istanze di Dipendente
            Dipendente dipendente = new Dipendente
            {
                Nome = "Anna",
                Cognome = "Bianchi",
                Posizione = "Ingegnere"
            };
            dipendente.Descriviti();

            // Creazione delle istanze di Animale
            Animale animale = new Animale
            {
                Nome = "Fido",
                Specie = "Cane",
                Eta = 5
            };
            animale.Descriviti();

            // Creazione delle istanze di Veicolo
            Veicolo veicolo = new Veicolo
            {
                Marca = "Fiat",
                Modello = "Panda",
                Anno = 2020
            };
            veicolo.Descriviti();

            // Attesa per vedere il risultato in console
            Console.ReadLine();
        }
    }
}
