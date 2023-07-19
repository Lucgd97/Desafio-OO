using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO
{
     class Animal
     {
        public Animal(string especie = "") //construtor com req. - podemos tbm usar "" para substituir o vazio como padrao
        {
            this.Especie = especie;
        }
        //public Receita() { } // vazio
        public string Especie { get; set; }
        public string Sexo { get; set; }
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
