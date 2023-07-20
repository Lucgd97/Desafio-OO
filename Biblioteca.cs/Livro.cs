using System;

namespace Biblioteca
{
    
        class Livro
        {
            public string Nome { get; set; } // ele aparece 
            private string Descricao { get; set; }
            protected string Autor { get; set; }
            internal string Versao { get; set; } // ele aparece 
        }
    
}
