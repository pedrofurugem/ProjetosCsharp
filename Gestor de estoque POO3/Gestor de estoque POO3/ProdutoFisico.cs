using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque_POO3
{
    [System.Serializable]
    public class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void CadastrarEntrada()
        {
            Console.WriteLine($"adiconar entrada no produto {nome}");
            Console.WriteLine("digite a quantidade para alocar no estoque: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void CadastrarSaida()
        {
            Console.WriteLine($"Retirar estoque do produto {nome}");
            Console.WriteLine("digite a quantidade de retirada de estoque: ");
            int saida = int.Parse(Console.ReadLine());
            estoque -= saida;
            Console.WriteLine("Saida registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Dados do Produto fisico");
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"preço: {preco}");
            Console.WriteLine($"frete: {frete}");
            Console.WriteLine($"estoque: {estoque}");
        }
    }
}
