using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF_Console.Negocio
{
    public class Idioma
    {

        /// <summary>
        /// USE PASCAL CASE
        /// </summary>

        public int Id { get; set; }
        public string Descricao { get; set; }

        public IList<Artigo> ArtigoOriginal { get; set; }
        public IList<Artigo> ArtigoTraduzido { get; set; }

        public Idioma()
        {
            ArtigoOriginal = new List<Artigo>();
            ArtigoTraduzido = new List<Artigo>();
        }

        public override string ToString()
        {
            return $"Artigo: {this.Id}, {this.Descricao}";
        }



    }
}
