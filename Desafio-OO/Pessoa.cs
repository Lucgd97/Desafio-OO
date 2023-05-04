using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO
{
    public class Pessoa
    {
        public Pessoa() { } // construtor pois tem mesmo nome da classe

        //atributos
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Endereco { get; set; }

    }
}
