using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF_Console.Negocio
{
    public class Pesquisador
    {
        

        public int Id { get; set; }
        public Departamento Departamento { get; set; }
        public string Nome { get; set; }
        public IList<Contato> Contatos { get; set; }        
        public IList<Artigo> Artigos { get; set; }

        public Pesquisador()
        {
            Contatos = new List<Contato>();
            Artigos = new List<Artigo>();
        }

        public override string ToString()
        {
            return $"Pesquisador: {this.Id}, {this.Nome}";
        }
    }
}
