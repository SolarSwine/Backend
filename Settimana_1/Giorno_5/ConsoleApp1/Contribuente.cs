﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contribuente
    {
        // Proprietà del contribuente
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public decimal RedditoAnnuale { get; set; }

        // Costruttori
        public Contribuente() { }

        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, string sesso, string comuneResidenza, decimal redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        // Metodo per calcolare l'imposta da pagare
        public decimal CalcolaImposta()
        {
            decimal imposta = 0;

            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m;
            }
            else if (RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
            }
            else if (RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
            }
            else if (RedditoAnnuale <= 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
            }
            else
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;
            }

            return imposta;
        }
    }
}