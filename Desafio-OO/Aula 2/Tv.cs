using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO
{
     class Tv
     {
        public Tv(string marca = "") //construtor com req. - podemos tbm usar "" para substituir o vazio como padrao
        {
            this.Marca = marca;
        }
        //public Receita() { } // vazio
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Tamanho { get; set; }

        public void Salvar ()
        {

        }

        public void Mostrar()
        {

        }
     }
}
