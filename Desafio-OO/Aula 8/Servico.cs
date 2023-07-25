using Desafio_OO.Aula_5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO.Aula_8
{
    public class Servico
    {
        public Servico() { }

        public static void Salvar(IPessoa iPessoa)
        {
            iPessoa.Salvar();
        }
    }
}
