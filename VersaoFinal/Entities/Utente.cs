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


        // CONSTRUTORES

        public Utente(string nome, DateTime datanascimento, string morada, char sexo, string email, int nutente)
    : base(nome, datanascimento, morada, sexo, email)
        {
            Nutente = nutente; // NÚMERO DE UTENTE
        }


        //MÉTODOS
        public override string ToString()
        {

            return "\n" + "\n" + "-------------------" + "\n" + "#UTENTE" + "\n" + "Nome: " + Nome + "\n" + "Data de Nascimento: " + DataNascimento.ToString("dd/MM/yyyy") + "\n" + "Sexo: " + Sexo + "\n"+ "N. utente: " + Nutente;
        }
    }
}
