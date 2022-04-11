using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque_POO3
{
    [System.Serializable]
    public class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void CadastrarEntrada()
        {
            Console.WriteLine($"adiconar vagas no curso de {nome}");
            Console.WriteLine("digite a quantidade para alocar no estoque: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void CadastrarSaida()
        {
            Console.WriteLine($"Digite quantas vagas deseja ocupar do curso {nome}");
            int ocp = int.Parse(Console.ReadLine());
            vagas -= ocp;
            Console.WriteLine("Preenchimento de vagas registradas");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Dados do curso");
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"preço: {preco}");
            Console.WriteLine($"autor: {autor}");
            Console.WriteLine($"vendas: {vagas}");
        }
    }
}
