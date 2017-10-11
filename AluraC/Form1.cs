using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 100;
            double saque = 50;
            double aposSaque = saldo - saque;

            MessageBox.Show("Seu Saldo é :" + aposSaque);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double total = 200;
            double saque = 210;
            bool valida = (saque <= total) && (saque > 0);
            double saldo = total - saque;
            if (valida)
            {
                MessageBox.Show("saque valor: " + saque);
                MessageBox.Show("Saldo: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double saldo = 2000.00;
            /*for (int i = 1; i <= 12; i += 1 )
            {
                saldo = saldo * 1.01;
            }*/
            int i = 1;
            while (i <= 12)
            {
                saldo = saldo * 1.01;
                i +=1;
            }
            MessageBox.Show("Seu Valor " + saldo);

            // exemplo de Do While

            /*int i = 10;
            while (i < 5)
            {
                MessageBox.Show("Entrei no while");
            }

            do
            {
                MessageBox.Show("Entrei no do..while");
            } while (i < 5);*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //criada primeira classe em C# chamada conta
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Joaquim José";
            umaConta.saldo = 1500.0;
            umaConta.cpf = "111.222.333-44";
            umaConta.agencia = 23;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Silva Xavier";
            outraConta.saldo = 2500.0;
            outraConta.cpf = "444.333.222-11";
            outraConta.agencia = 34;

            MessageBox.Show(umaConta.titular + " - " + umaConta.cpf + " - " + umaConta.agencia);
            MessageBox.Show(outraConta.titular + " - " + outraConta.cpf + " - " + outraConta.agencia);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta guilherme = new Conta();
            guilherme.numero = 1;
            guilherme.titular = "Guilherme";
            guilherme.saldo = 1500.0;

            Conta mauricio = new Conta();
            mauricio.numero = 2;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 2500.0;

            guilherme.Transfere(200.0, mauricio);

            MessageBox.Show("Saldo Guilherme: " + guilherme.saldo);
            MessageBox.Show("Saldo Maurício: " + mauricio.saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
