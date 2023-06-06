using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Pessoa
    {

        //PROPRIEDADES
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Morada { get; set; }

        public char Sexo { get; set; }

        public string Email { get; set; }



        // CONSTRUTORES
        public Pessoa()
        {
        }

        public Pessoa(string nome, DateTime datanascimento, string morada, char sexo, string email)
        {
            Nome = nome;
            DataNascimento = datanascimento;
            Morada = morada;
            Sexo = sexo;
            Email = email;

        }


    }
}
