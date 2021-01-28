using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[3];

            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("osni");
            this.contas[2].Numero = 3;


            

            c.Numero = 1;
            Cliente cliente = new Cliente("Athur Gabriel");
            c.Titular = cliente;        
            
            textoTitular.Text = this.c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            
            if(!string.IsNullOrEmpty(valorDigitado))
            {
                double valorOperacao = Convert.ToDouble(valorDigitado);
                this.c.Deposita(valorOperacao);
                textoSaldo.Text = Convert.ToString(this.c.Saldo);
                textoValor.Text = "";
                MessageBox.Show("Deposito Realizado com Sucesso!");
            }
            else 
            {
                MessageBox.Show("Valor Invalido");
            }


        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {

            string valorDigitado = textoValor.Text;

            if (!string.IsNullOrEmpty(valorDigitado))
            {
                double valorSaque = Convert.ToDouble(valorDigitado);
                this.c.Saca(valorSaque);
                textoSaldo.Text = Convert.ToString(this.c.Saldo);
                textoValor.Text = "";
                MessageBox.Show("Você realizou um saque no valor de " + valorSaque + " reais. O seu saldo agora é " + this.c.Saldo);

            }
            else
            {
                MessageBox.Show("Valor Invalido");
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
            //textoTitular.Text = "Texto da minha caixa de texto";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Conta_Enter(object sender, EventArgs e)
        {

        }
    }
}
