using Alunos;
using System;
using System.Collections.Generic;
using Biblioteca;
using Desafio_OO.Aula_5;

namespace Desafio_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            PFisica usuario = new PFisica("Lucas");
            Console.WriteLine(usuario.NomePersonalizado());
            PFisica.SalvarInstancia(usuario);

            new PFisica("Camila").Salvar();
            new PFisica("Bruno").Salvar();
            new PFisica("Isabela").Salvar();

            // refatorando com o metodo salvar() - aula 7 deixando o codigo persistente = mais inteligente
            //PFisica usuario1 = new PFisica("Camila");
            //PFisica usuario2 = new PFisica("Bruno");
            //PFisica usuario3 = new PFisica("Isabela"); 
            //PFisica.SalvarInstancia(usuario1);
            //PFisica.SalvarInstancia(usuario2);
            //PFisica.SalvarInstancia(usuario3);


            var lista = PFisica.Todas();
            foreach (var pessoa in lista)
            {
                Console.WriteLine(pessoa.Nome);
            }            
            
        }
    }
}
//aula 2
//Pessoa danilo = new Pessoa(); //instancia
//danilo.Id = 1;
//danilo.Nome = "Danilo Aparecido";
//danilo.Endereco = "Rua 1234";

//Pessoa lucas = new Pessoa();
//lucas.Id = 2;
//lucas.Nome = "lucas ducci";
//lucas.Endereco = "Rua 1234";

//Pessoa jean = new Pessoa();
//jean.Id = 3;
//jean.Nome = "jean araujo";
//jean.Endereco = "Rua 1234";

////lista generica 
//List<Pessoa> pessoas = new List<Pessoa>();
//pessoas.Add(danilo);
//pessoas.Add(lucas);
//pessoas.Add(jean);

//Console.WriteLine("Hello World!");

//aula 3
//Receita bolo1 = new Receita();
//bolo1.Nome = "Chocolate";
//bolo1.Peso = 1.5;
//bolo1.Tamanho = "Grande";
//bolo1.Preco = 35.00;

//Receita bolo2 = new Receita();
//bolo2.Nome = "Morango";
//bolo2.Peso = 1.7;
//bolo2.Tamanho = "Medio";
//bolo2.Preco = 25.00;

//Receita bolo3 = new Receita();
//bolo3.Peso = 2.5;
//bolo3.Tamanho = "Pequeno";
//bolo3.Preco = 45.00;

//var livro = new Livro();
//livro.Nome = "Geracao de Valor";
//livro.Versao = "0.01";

//aula 5 e 6
//var empresa = new PJuridica();
//empresa.Nome = Console.ReadLine();
//usuario.NomePersonalizado();
//Console.WriteLine(usuario.Nome);