using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO
{
     class Receita
     {
        public Receita(string nome = "") //construtor com req. - podemos tbm usar "" para substituir o vazio como padrao
        {
            this.Nome = nome;
        }
        //public Receita() { } // vazio
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }

        public void Salvar ()
        {

        }

        public void Mostrar()
        {

        }
     }
}
