using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animale
    {
        private string nome;
        private string specie;
        private int eta;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }

        public void Descriviti()
        {
            Console.WriteLine($"Sono {nome}, un {specie} di {eta} anni.");
        }
    }
}
