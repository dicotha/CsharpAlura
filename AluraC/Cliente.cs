﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC
{
    class Cliente
    {
        public string Nome { get; set; }
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        public Cliente() { }

    }
}
