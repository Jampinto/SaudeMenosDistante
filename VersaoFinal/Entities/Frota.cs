using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Frota : Equipamento
    {
        //PROPRIEDADES
        public string Marca { get; set; }
        public string Matricula { get; set; }
        public DateTime IPO { get; set; }
        public DateTime Revisao { get; set; }
        public int IUC { get; set; }
        List<Frota> frotaList { get; set;} = new List<Frota>();
        List<RegistoViatura> listaregistos { get; set; } = new List<RegistoViatura>();



        //CONSTRUTORES
        public Frota(string artigo, string descritivo, int quantidade, string marca, string matricula, DateTime ipo, DateTime revisao, int iuc)

           :base(artigo, descritivo, quantidade)

        {
            Marca = marca;
            Matricula = matricula;
            IPO = ipo;
            Revisao = revisao;
            IUC = iuc;
        }


        //MÉTODOS
        public void AdicionarItem (RegistoViatura item) // ADICIONAR REGISTOS DIÁRIOS À VIATURA
        {
            listaregistos.Add(item);
        }

        public void AdicionarViatura (Frota item) // ADICIONAR VIATURA
        {
            frotaList.Add(item);
        }



        
    }
}
