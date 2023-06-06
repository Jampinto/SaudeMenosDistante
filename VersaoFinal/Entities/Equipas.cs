using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Equipas
    {
        public string NomeEquipa { get; set; }
        public string Localidade { get; set; }

        public Equipas() { }

        public Equipas(string nomeEquipa, string localidade)
        {
            NomeEquipa = nomeEquipa;
            Localidade = localidade;
        }
        
        public override string ToString()
        {
            return "Nome da Equipa: " + NomeEquipa + "\n" + "Localidade: " + Localidade;
        }
        

    }
}
