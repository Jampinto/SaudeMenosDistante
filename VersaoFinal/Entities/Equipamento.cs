using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Equipamento
    {
        //PROPRIEDADES
        public string Artigo { get; set; }
        public string Descritivo { get; set; }
        public int Quantidade { get; set; }


        //CONSTRUTORES
        public Equipamento(string artigo, string descritivo, int quantidade)
        {
            Artigo = artigo;
            Descritivo = descritivo;
            Quantidade = quantidade;
        }

       
 

        
    }
}
