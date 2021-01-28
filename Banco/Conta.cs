using System;
using System.Windows.Forms;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta()
        {
        }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public void Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                 this.Saldo -= valor;
            }else
            {
                //MessageBox.Show("Valor Invalido!");
                MessageBox.Show("Você não possui saldo suficiente!");
            }
            
        }
        
    }
}