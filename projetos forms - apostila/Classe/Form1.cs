using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe
{
    public partial class Form1 : Form
    {
        private Conta c;
        // Para	 que	 a	mesma	 conta	 possa	 ser	
        // utilizada	 em	 diferentes	métodos	 do	 formulário, ela
        // precisa ser declarada como    um atributo    da classe
        // do	formulário que foi gerada  pelo Visual  Studio

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            this.c = new Conta(); //Cria	uma	nova	conta	e	guarda	sua	referência	no	atributo	do	formulário
            c.Numero = 1;

            Cliente cliente = new Cliente("Pedro");
            c.Titular = cliente;

            textoTitular.Text = c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
        } 
        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Depositar(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("valor de deposito: R$ " + this.c.Saldo);
        }
  
        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Sacar(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show($"valor de R$ {valorOperacao} sacado com Sucesso");
            MessageBox.Show($"Seu saldo atual é de R$ {this.c.Saldo} ");
        }
    }
}

//A	Conta que foi criada na	memória
//pelo operador new é	chamada	de instância ou	objeto