using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    class Livro
    {
        public string Nome { get; set; } // ele aparece 
        private string Descricao { get; set; }
        protected string Autor { get; set; }
        internal string Versao { get; set; } // ele aparece 
    }
}
