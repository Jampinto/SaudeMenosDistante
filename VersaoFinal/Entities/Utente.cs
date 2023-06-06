using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Utente : Pessoa
    {

        // PROPRIEDADE
        public int Nutente { get; set; }


        // MÉTODOS

        public Utente(string nome, DateTime datanascimento, string morada, char sexo, string email, int nutente)
    : base(nome, datanascimento, morada, sexo, email)
        {
            Nutente = nutente; // NÚMERO DE UTENTE
        }


        public override string ToString()
        {

            return "#UTENTE" + "\n" + "Nome: " + Nome + "\n" + "Data de Nascimento: " + DataNascimento.ToString("dd/MM/yyyy") + "\n" + "Sexo: " + Sexo + "\n"+ "N. utente: " + Nutente;
        }
    }
}
