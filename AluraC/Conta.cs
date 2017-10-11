using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
        public string cpf;
        public int agencia;


        public void Saca(double valorAserSacado)
        {
            this.saldo -= valorAserSacado;
        }

        public void Deposita(double valorAserDepositado)
        {
            this.saldo += valorAserDepositado;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
