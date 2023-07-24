using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO.Aula_5
{
    public class PFisica : Pessoa // classe filha
    {
        public PFisica(string nome)
        {
            this.Nome = nome;
            this.Nome = this.NomePersonalizado();
        }   

        public void Salvar()
        {
            //PFisica.BancoEmMemoriaDePessoasFisicas.Add(this); refatorando
            PFisica.SalvarInstancia(this);
        }

        public string Cpf { get; set; }
        public string Rg { get; set; }

        //public override string NomePersonalizado() - Polimorfismo com virtual
        //{
        //    return base.NomePersonalizado();
        //}

        public new string NomePersonalizado() // polimorfismo - melhorar o codigo, sobrescrever ele
        {
            return $"{base.NomePersonalizado()} - teste";
        }

        public static List<PFisica> BancoEmMemoriaDePessoasFisicas = new List<PFisica>();
        
        public static List<PFisica> Todas()
        {
            return PFisica.BancoEmMemoriaDePessoasFisicas;
        }

        public static void SalvarInstancia(PFisica obj)
        {
            PFisica.BancoEmMemoriaDePessoasFisicas.Add(obj);
        }

        public static List<PFisica> BuscarPorNome(string nome)
        {
            var novaLista = new List<PFisica>();
            foreach(var instan in PFisica.BancoEmMemoriaDePessoasFisicas) 
            {
                if (instan.Nome.Contains(nome))
                {
                    novaLista.Add(instan);
                }
            }

            return novaLista;
        }

    }
}
