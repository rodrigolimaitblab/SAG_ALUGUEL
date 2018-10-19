using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF_Console.Negocio
{
    public class Departamento
    {

        /// <summary>
        /// USE PASCAL CASE
        /// </summary>

        public int Id { get; set; }
        public string Descricao { get; set; }
        public IList<Pesquisador> Pesquisadores { get; set; }

        public Departamento()
        {
            Pesquisadores = new List<Pesquisador>();
        }

        public override string ToString()
        {
            return $"Departamento: {this.Id}, {this.Descricao}";
        }

    }
}
