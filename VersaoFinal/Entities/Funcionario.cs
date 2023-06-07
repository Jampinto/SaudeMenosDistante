using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Funcionario : Pessoa
    {

        // PROPRIEDADES
        public string Funcao { get; set; }
        public double Vencimento { get; set; }
        public string Equipa { get; set; }

        private Conta Registo;


        //CONSTRUTORES
        public Funcionario()
        {
        }

        public Funcionario(string nome, DateTime datanascimento, string morada, char sexo, string email, string funcao, double vencimento, string equipa)
            : base(nome, datanascimento, morada, sexo, email)
        {
            Funcao = funcao;
            Vencimento = vencimento;
            Equipa = equipa;
        }

        //MÉTODOS
        public Conta ObterConta() //CONTA FUNCIONÁRIO
        {
            return Registo;
        }

        public void Registar(string username, string password) // REGISTAR CONTA DE ACESSO FUNCIONÁRIO
        {
            Registo = new Conta(username, password);
        }

        public bool Login(string username, string password) //LOGIN FUNCIONÁRIO
        {
            if (Registo.login(username, password))
            {
                Console.WriteLine(Nome + ", " + Funcao);
                return true;

            }
            else
            {
                Console.WriteLine("Dados inválidos!");
                return false;
            }
        }

        public override string ToString()
        {
            return "Funcionário: " + Nome + " - "  + "Vencimento: " + Vencimento + " - " + "Função: " + Funcao;
        }
    }
}
