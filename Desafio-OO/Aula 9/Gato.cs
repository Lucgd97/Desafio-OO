using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO.Aula_9
{
    class Gato : IAnimal
    {
        public string Nome { get; set; }
        public void Andar()
        {
            if (string.IsNullOrEmpty(this.Nome)) // mesma coisa que o if abaixo 
            {

            }

            //if (this.Nome == "" || this.Nome != null)
            //{

            //} 
            //throw new NotImplementedException();  exception
        }

        public void Correr()
        {
            throw new NotImplementedException();
        }
    }
}
