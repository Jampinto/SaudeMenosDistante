using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaudeMenosDistante.Entities.Enum;

namespace SaudeMenosDistante.Entities
{
    internal class Consulta
    {
        //PROPRIEDADES
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public EstadoConsulta Estado { get; set; }
        public Utente Utente { get; set; }

        // Construtores
        public Consulta(int id, DateTime moment, EstadoConsulta estado, Utente utente) 
        {
            Id = id;
            Moment = moment;
            Estado = estado;
            Utente = utente;
        }

        // Métodos
        public override string ToString()
        {

            return "\n" + "\n" + "-------------------" + "\n" + " #UTENTE" + "\n" + "ID: " + Id + "\n" + "Nome: " + Utente.Nome + "\n" + "Data de Nascimento: " + Utente.DataNascimento.ToString("dd/MM/yyyy") + "\n" + "Sexo: " + Utente.Sexo + "\n" + "N. utente: " + Utente.Nutente + 
                "\n" +"Data da Consulta: " + Moment.ToString("dd/MM/yyyy hh:mm:ss");
        }








  






    }
}
