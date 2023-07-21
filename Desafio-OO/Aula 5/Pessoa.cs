using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO.Aula_5
{
    public class Pessoa // classe pai
    {
        public Pessoa() { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public virtual string NomePersonalizado() // alterar protected para public
        {
            return $"{this.Nome} - Aula Torne-se um programador";
        }
    }
}
