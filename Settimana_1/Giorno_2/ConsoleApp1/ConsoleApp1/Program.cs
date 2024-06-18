namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                       
            Persona persona = new Persona
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Eta = 30
            };

             
            Console.WriteLine("Dettagli della persona:");
            Console.WriteLine(persona.GetDettagli());
             
            Console.WriteLine("\nProprietà singole:");
            Console.WriteLine($"Nome: {persona.GetNome()}");
            Console.WriteLine($"Cognome: {persona.GetCognome()}");
            Console.WriteLine($"Età: {persona.GetEta()}");

        }
    }
}
