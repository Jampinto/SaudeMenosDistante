using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class EquipamentoDeServico: Equipamento
    {
        //PROPRIEDADES
        public DateTime DataCompra { get; set; }
        public int Referencia { get; set; }
        public string Fabricante { get; set; }
        public string Tipo { get; set; }

        List<EquipamentoDeServico> Equipamentos { get; set; } = new List<EquipamentoDeServico>();


        //CONSTRUTOR
        public EquipamentoDeServico(string artigo, string descritivo, int quantidade, DateTime dataCompra, int referencia, string fabricante, string tipo)
            : base(artigo, descritivo, quantidade)
        {
            DataCompra = dataCompra;
            Referencia = referencia;
            Fabricante = fabricante;
            Tipo = tipo;
        }


        


    }
}
