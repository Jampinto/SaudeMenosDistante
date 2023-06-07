using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class ConsultasMedicas
    {
        //PROPRIEDADES
        public int Id { get; set; }
        public string Recomendacao { get; set; }

        public string Dosagem { get; set; }

        public string Periodicidade { get; set; }

        //CONSTRUTORES
        public ConsultasMedicas(int id, string recomendacao)
        {
            Id = id;
            Recomendacao = recomendacao;
        }

        public ConsultasMedicas(int id, string recomendacao, string dosagem, string periodicidade)
        {
            Id = id;
            Recomendacao = recomendacao;
            Dosagem = dosagem;
            Periodicidade = periodicidade;
        }

        public override string ToString()
        {
            
            if (Dosagem == null) //CONDIÇÃO CASO NÃO SE VERIFIQUE A NECESSIDADE DE PRESCRIÇÃO TERAPÊUTICA
            {
                return "#MEDICINA" + "\n" + "ID: " + Id + "\n" + "Recomendação: " + Recomendacao;
            }
            else //CONDIÇÃO CASO SE VERIFIQUE NECESSIDADE DE PRESCRIÇÃO TERAPÊUTICA
            {
                return "#MEDICINA" + "\n" + "ID: " + Id + "\n" + "Recomendação: " + Recomendacao + "\n"
                + "Dosagem: " + Dosagem + "\n"
                + "Periodicidade: " + Periodicidade;
            }
           

        }

    }
}
