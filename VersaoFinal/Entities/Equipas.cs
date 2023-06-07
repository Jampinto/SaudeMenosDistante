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
        //PROPRIEDADES
        public string NomeEquipa { get; set; }
        public string Localidade { get; set; }

        //CONSTRUTOR
        public Equipas(string nomeEquipa, string localidade)
        {
            NomeEquipa = nomeEquipa;
            Localidade = localidade;
        }
        
        //MÉTODOS
        public override string ToString()
        {
            return "Nome da Equipa: " + NomeEquipa + "\n" + "Localidade: " + Localidade;
        }
        

    }
}
