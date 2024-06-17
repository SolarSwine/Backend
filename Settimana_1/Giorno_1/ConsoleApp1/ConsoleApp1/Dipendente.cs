using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendente
    {
        private string nome;
        private string cognome;
        private string posizione;

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

        public string Posizione
        {
            get { return posizione; }
            set { posizione = value; }
        }

        public void Descriviti()
        {
            Console.WriteLine($"Sono {nome} {cognome}, lavoro come {posizione}.");
        }
    } 
}
