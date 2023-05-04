using Alunos;
using System;
using System.Collections.Generic;

namespace Desafio_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa danilo = new Pessoa();
            danilo.Id = 1;
            danilo.Nome = "Danilo Aparecido";
            danilo.Endereco = "Rua 1234";

            Pessoa lucas = new Pessoa();
            lucas.Id = 2;
            lucas.Nome = "lucas ducci";
            lucas.Endereco = "Rua 1234";

            Pessoa jean = new Pessoa();
            jean.Id = 3;
            jean.Nome = "jean araujo";
            jean.Endereco = "Rua 1234";

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(danilo);
            pessoas.Add(lucas);
            pessoas.Add(jean);

            Console.WriteLine("Hello World!");
        }
    }
}
