using System;

namespace Biblioteca
{
    public class Livro
    {
        public string Nome { get; set; } // ele aparece 
        private string Descricao { get; set; }
        protected string Autor { get; set; }
        public string Versao { get; set; } // internal - ele aparece,apenas dentro do proprio namespace dele.
    }
}
