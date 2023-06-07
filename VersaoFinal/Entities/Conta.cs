using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Conta
    {
        //PROPRIEDADES
        private string Username;

        private string Password;


        //CONSTRUTOR
        public Conta(string username, string password)
        {
            Username = username;
            Password = password;
        }


        //MÉTODOS
        public string ObterUsername() //OBTER USERNAME DA CONTA DE ACESSO AO PROGRAMA 
        {
            return Username;
        }

        public bool login(string username, string password) //CONDIÇÃO PARA LOGIN DA CONTA INDIVIDUAL DE CADA FUNCIONARIO
        {
            return username == Username && password == Password;
        }
    }
}
