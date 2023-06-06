using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class ListaConsultas
    {
        List<Consulta> ListaDeConsultas;

        public ListaConsultas()
        {
            ListaDeConsultas = new List<Consulta>();
        }

        public List<Consulta> ObterListaDeConsultas()
        {
            return ListaDeConsultas;
        }


        public void Adicionar(Consulta consulta)
        {
            ListaDeConsultas.Add(consulta);
        }





    }
}
