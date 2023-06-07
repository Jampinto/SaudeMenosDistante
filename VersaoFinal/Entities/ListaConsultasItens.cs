using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class ListaConsultasItens
    {
        List<ConsultaItens> ListaDeConsultasItens;


        //INSTANCIAÇÃO DE LISTA DE CONSULTAS ITENS
        public ListaConsultasItens()
        {
            ListaDeConsultasItens = new List<ConsultaItens>();
        }

        //MÉTODOS
        public List<ConsultaItens> ObterListaDeConsultasItens()
        {
            return ListaDeConsultasItens;
        }

        public void Adicionar(ConsultaItens consultaItens)
        {
            ListaDeConsultasItens.Add(consultaItens);
        }

    }
}
