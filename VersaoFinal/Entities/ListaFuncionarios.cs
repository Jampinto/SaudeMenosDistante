using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class ListaFuncionarios
    {


        List<Funcionario> ListaDeFuncionarios;



        //MÉTODOS
        public ListaFuncionarios()
        {
            ListaDeFuncionarios = new List<Funcionario>();
        }

        public List<Funcionario> ObterListaDeFuncionarios() // LISTA DE FUNCIONÁRIOS
        {
            return ListaDeFuncionarios;
        }
        
        public void Adicionar(Funcionario funcionario) // ADICIONAR FUNCIONÁRIO
        {
            ListaDeFuncionarios.Add(funcionario);
        }
        
    }
}
