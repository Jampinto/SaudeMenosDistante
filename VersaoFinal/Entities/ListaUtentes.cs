using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class ListaUtentes
    {

        List<Utente> ListaDeutentes;


        // INSTANCIAÇÃO DE LISTA DE UTENTES
        public ListaUtentes() 
        {
            ListaDeutentes = new List<Utente>();
        }

        public List<Utente> obterListaDeutentes() // LISTA DE UTENTES
        {
            return ListaDeutentes;
        }

        public void Adicionar(Utente utente) // ADICIONAR UTENTE
        {
            ListaDeutentes.Add(utente);
        }
    }
}
