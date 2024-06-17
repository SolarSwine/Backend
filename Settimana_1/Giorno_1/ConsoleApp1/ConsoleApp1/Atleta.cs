using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {
        private string nome;
        private string cognome;
        private string sport;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }

        public void Descriviti()
        {
            Console.WriteLine($"Sono {nome} {cognome}, faccio {sport}.");
        }
    }
}

