using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF_Console.Negocio
{
    public class Artigo
    {

        public int Id { get; set; }
        public Idioma idiomaOriginal { get; set; }
        public Idioma idiomaTraduzido { get; set; }
        public Veiculo_Publicacao veiculo_publicacao { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public Pesquisador Pesquisador { get; set; }
        public DateTime dataPublicacao { get; set; }
        public string ISBN { get; set; }

        public Artigo()
        {
        }

        public override string ToString()
        {
            return $"Artigo: {this.Id}, {this.titulo},{this.dataPublicacao},{this.ISBN},{this.Pesquisador},{this.veiculo_publicacao},{this.idiomaOriginal},{this.idiomaTraduzido}";
        }

    }
}
