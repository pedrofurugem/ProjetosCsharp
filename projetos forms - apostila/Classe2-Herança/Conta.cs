using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Conta
    {
        //numero, titular e	saldo são atributos do objeto
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get;  set; }


        /*
         Para acessarmos a referência em que um	determinado	método foi chamado,	 
         utilizamos	a palavra this.
         */      

        public void Depositar(double valorOperacao)
        {
             this.Saldo += valorOperacao;
        }

        public void Sacar(double valor)
        {    
           this.Saldo -= valor;        
        }

       /* public void Transferir(double valor, Conta destino)
        {
            if(this.Sacar(valor))
            {
                destino.Depositar(valor);
            }
        }      

        public double PegaSaldo()
        {
            return this.saldo;
        }

        public void ColocaNumero(int numero)
        {
            this.numero = numero;
        }*/
    }
}


/*
 Além de atributos,	os objetos também
podem possuir métodos.	Os	métodos	 
são	 blocos	 de	 código
que	isolam	lógicas	de	negócio	do	objeto
 */