using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO___Trilha_.NET___Explorando_a_linguagem_C_.Models
{
    public class Suite
    {
         public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}