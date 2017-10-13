using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC
{
    class ContaPoupanca: Conta
    {
        public override bool Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
            return true;
        }
    }
}
