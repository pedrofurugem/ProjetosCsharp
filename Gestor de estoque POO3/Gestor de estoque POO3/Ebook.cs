using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque_POO3
{
    [System.Serializable]
    public class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void CadastrarEntrada()
        {
            Console.WriteLine("Não é possível alocar entrada no produto Ebook");
        }

        public void CadastrarSaida()
        {
            Console.WriteLine("Acrescentar numero de vendas no Ebook");
            Console.WriteLine($"Digite a quantidade de vendas do Ebook {nome}");
            int qtd = int.Parse(Console.ReadLine());
            vendas += qtd;
            Console.WriteLine("Quantidade Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Dados do Ebook");
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"preço: {preco}");
            Console.WriteLine($"autor: {autor}");
            Console.WriteLine($"vendas: {vendas}");
        }
    }
}
