using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Veicolo
    {
        private string marca;
        private string modello;
        private int anno;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modello
        {
            get { return modello; }
            set { modello = value; }
        }

        public int Anno
        {
            get { return anno; }
            set { anno = value; }
        }

        public void Descriviti()
        {
            Console.WriteLine($"Sono un {marca} {modello} del {anno}.");
        }
    }
}
