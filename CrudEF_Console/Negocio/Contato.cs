using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF_Console.Negocio
{
    public class Contato
    {

        /// <summary>
        /// USAR PASCAL CASE
        /// </summary>

        public int Id { get; set; }
        public string tipo { get; set; }
        public string texto { get; set; }

        public override string ToString()
        {
            return $"Contato: {this.tipo}, {this.texto}";
        }

    }
}
