﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_OO.Aula_5
{
    internal class PJuridica : Pessoa // classe filha
    {
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }

        public override void Busca()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
