using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF_Console.Negocio
{
    public class Veiculo_Publicacao
    {

        public int Id { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        //public DateTime dataPublicacao { get; set; }
        public IList<Artigo> artigo { get; set; }

        public Veiculo_Publicacao()
        {
            artigo = new List<Artigo>();
        }

        public override string ToString()
        {
            //return $"VeiculoPublicacao: {this.Id}, {this.tipo}, {this.descricao}, {this.dataPublicacao}";
            return $"VeiculoPublicacao: {this.Id}, {this.tipo}, {this.descricao}";
        }

    }
}
