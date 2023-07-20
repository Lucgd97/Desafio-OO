using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO
{
     class Carro
     {
        public Carro(string modelo = "") //construtor com req. - podemos tbm usar "" para substituir o vazio como padrao
        {
            this.Modelo = modelo;
        }
        //public Receita() { } // vazio
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public double Preco { get; set; }

        public void Salvar ()
        {

        }

        public void Mostrar()
        {

        }
     }
}
