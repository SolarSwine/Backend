using System;
using System.Collections.Generic;

namespace GestioneLogin
{
    static class Utente
    {
        public static bool IsLoggedIn { get; private set; } = false;
        public static DateTime? LoginDateTime { get; private set; }
        public static List<DateTime> Accessi { get; private set; } = new List<DateTime>();
        public static string Username { get; private set; }

        public static void Login(string username, string password, string confermaPassword)
        {
            if (IsLoggedIn)
            {
                Console.WriteLine("Sei già loggato.");
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Il campo username non può essere vuoto.");
                return;
            }

            if (password != confermaPassword)
            {
                Console.WriteLine("Le password non coincidono.");
                return;
            }

            IsLoggedIn = true;
            LoginDateTime = DateTime.Now;
            Username = username;
            Accessi.Add(LoginDateTime.Value);
            Console.WriteLine($"Login effettuato con successo alle {LoginDateTime}.");
        }

        public static void Logout()
        {
            if (!IsLoggedIn)
            {
                Console.WriteLine("Non sei loggato.");
                return;
            }

            IsLoggedIn = false;
            Username = null;
            LoginDateTime = null;
            Console.WriteLine("Logout effettuato con successo.");
        }

        public static void VerificaLogin()
        {
            if (!IsLoggedIn)
            {
                Console.WriteLine("Non sei loggato.");
                return;
            }

            Console.WriteLine($"Sei loggato dall'ora: {LoginDateTime}.");
        }

        public static void ListaAccessi()
        {
            if (Accessi.Count == 0)
            {
                Console.WriteLine("Nessun accesso registrato.");
                return;
            }

            Console.WriteLine("Lista degli accessi:");
            foreach (var accesso in Accessi)
            {
                Console.WriteLine(accesso);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;

            while (continua)
            {
                Console.Clear();
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine();
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.Write("Scelta: ");

                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        EseguiLogin();
                        break;
                    case "2":
                        Utente.Logout();
                        break;
                    case "3":
                        Utente.VerificaLogin();
                        break;
                    case "4":
                        Utente.ListaAccessi();
                        break;
                    case "5":
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }

                if (scelta != "5")
                {
                    Console.WriteLine("Premi un tasto per continuare...");
                    Console.ReadKey();
                }
            }
        }

        static void EseguiLogin()
        {
            Console.Write("Inserisci username: ");
            string username = Console.ReadLine();
            Console.Write("Inserisci password: ");
            string password = Console.ReadLine();
            Console.Write("Conferma password: ");
            string confermaPassword = Console.ReadLine();

            Utente.Login(username, password, confermaPassword);
        }
    }
}
